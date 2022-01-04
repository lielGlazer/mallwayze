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
        public static List<DTOLocations> GetLocations()
        {
            List<Locations> list = db.GetDbSet<Locations>().ToList();
            List<DTOLocations> dtoList = DTOLocations.DTOlist(list);
            return dtoList;
        }

    }
}
