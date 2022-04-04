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
        //רשימה של כל הקטגוריןת לחניות 
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
            DTOCategory Scode = db.GetDbSet<DTOCategory>().FirstOrDefault(d => d.NameCategory.Equals(nameCategory));
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

    }
}
