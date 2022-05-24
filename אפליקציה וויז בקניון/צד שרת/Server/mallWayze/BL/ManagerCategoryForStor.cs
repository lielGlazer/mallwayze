using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
   public class ManagerCategoryForStor

    {
        //הדאטה בייס בעצמו 
        static DBConection db = new DBConection();
        // המיידע מהדאטה בייס רשימה של כל הקטגוריןת לחניות 
        static List<CategoryForStor> list = db.GetDbSet<CategoryForStor>().ToList();
        //מחזירה את כל הרשימה של קטגוריה לחנות 
        public static List<DTOCategoryForStor> GetCategoryForStor()
        {
            List<DTOCategoryForStor> dtoList = DTOCategoryForStor.DTOlist(list);
            return dtoList;
        }
        //פונקציה שמקבלת קטגוריה ונותנת את כל החניות שמכילות את הקטגוריה הנ''ל  
        public static List<DTOStor> GetAllStorOfXContaining(string nameCategory)
        {
            List<Category> list = db.GetDbSet<Category>();
            Category c = list.FirstOrDefault(d => d.NameCategory.Equals(nameCategory));
            DTOCategory Scode =new DTOCategory( c);
            long code = Scode.CategoryCode;
           //רשימת הקודים לחניות  
            List<DTOCategoryForStor> h = GetCategoryForStor().Where(s=>s.categoryCode==code).ToList();
            List<DTOStor> stores = new List<DTOStor>();
            foreach (var s in h)
            {
                stores.Add(new DTOStor(db.GetDbSet<Stor>().Find(store => store.CodeStor == s.CodeStor)));
            }
            return stores;
        }
        //פןנקציה שמקבלת שם  חנות ומביאה את כל בקטגוריות שלה 
        public static List<DTOCategory> GetAllCtegoryForStor(string nameStor)
        {
            DTOStor Scode = db.GetDbSet<DTOStor>().FirstOrDefault(d => d.NameStor.Equals(nameStor));
            long code = Scode.CodeStor;
            //רשימת הקודים של הקטגוריות לחנות שהתקבלה   
            List<DTOCategoryForStor> h = GetCategoryForStor().Where(s => s.CodeStor == code).ToList();//רשימת כל הקודים של הקטגורייות
            List<DTOCategory> categor = new List<DTOCategory>();//רשימה ריקה של קטגוריות
            foreach (var s in h)
            {
              List <Category> all = db.GetDbSet<Category>().ToList();
              List<DTOCategory> dtoList = DTOCategory.DTOlist(all);//רשימה של כל הקטגוריות בקניון 
              categor.Add(dtoList.Find(store => store.CategoryCode == s.categoryCode));
            }
            return categor;
        }

    }
}
