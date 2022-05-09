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
        //מיקום של כל החניות ברשימה 
        public static List<DTOLocations> GetLocations()
        {
            List<Locations> list = db.GetDbSet<Locations>().ToList();
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
