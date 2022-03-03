using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BL
{
    public static class ManagerLocations
    {
        static DBConection db = new DBConection();

        //פונקציה שמקבלת קטגוריה ונותנת את כל החניות שמכילות את הקטגוריה הנ''ל  
        public static List<DTOStor> GetAllStorOfXContaining(string nameCategory) {
            DTOCategory Scode = db.GetDbSet<DTOCategory>().FirstOrDefault(d => d.NameCategory.Equals(nameCategory)); 
            int code =(int)Scode.CategoryCode;
            List<DTOCategoryForStor> catOfStor = db.GetDbSet<DTOCategoryForStor>().ToList();
            catOfStor.Where(s => s.categoryCode == code);
            return null;
        }



        //מיקום של כל החניות ברשימה 
        public static List<DTOLocations> GetLocations()
        {
            List<Location> list = db.GetDbSet<Location>().ToList();
            List<DTOLocations> dtoList = DTOLocations.DTOlist(list);
         
            return dtoList;
        }
        //החזרת מיקום החנות על ידי הקשת שמה 
        public static DTOLocations LocationForStor(string nameStore)
        {
           List<DTOStor> l = ManagerStor.GetStor();
           long location=   l.Where(s => s.NameStor.Equals(nameStore)).Select(a=>a.PlaceCode).FirstOrDefault();
           return GetLocations().Where(s => s.LocationCode == location).FirstOrDefault();   
        }

    }
}
