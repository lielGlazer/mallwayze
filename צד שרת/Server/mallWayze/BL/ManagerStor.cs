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
       List<DTOStor> mapStores= BL.Dijkstra.MapSelectedStores(stores);
            return mapStores;
        }
        //מחזירה רשימה של כל החניות שיש בהם מבצעים
        public static List<DTOStor> GetStorSale()
        {   //רשימה של כל החניות הקניון 
            List<DTOStor> ALLSTOR = GetStor();
            //רשימה שתכיל את כל החניות שיש בהם מבצעים 
            List<DTOStor> SALESTOR =new List<DTOStor>();
          
            foreach (var s in ALLSTOR)
            {
                if (s.Sale==true)
                {
                    SALESTOR.Add(s);
                }
            }
            return SALESTOR;

        }
    }
}
