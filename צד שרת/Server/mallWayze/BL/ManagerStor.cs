using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class ManagerStor
    {
        static DBConection db = new DBConection();
        //מחזירה את הרשימה של כל החניות 
        public static List<DTOStor> GetStor()
        {
            List<Stor> list = db.GetDbSet<Stor>().ToList();
            List<DTOStor> dtoList = DTOStor.DTOlist(list);
            return dtoList;
        }
        //מקבלת רשימת חניות ומחזירה גרף קצר ביותר
        public static List<DTOStor> CreatePath(List<DTOStor> stores)
        {
            //להפעיל את הפונקציה המורכבת של הדיאקסטרה
            List<DTOStor> mapStores = Dijkstra.Dijkstra.MapSelectedStores(stores);
            return null;
        }


    }
}
