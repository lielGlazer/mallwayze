using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net;
using System.IO;
using System.Data;
using DAL;

namespace BL
{
    public static class ManagerCaterory
    {
        static DBConection db = new DBConection();
        public static  List<DTOCategory> GetCategories()
        {
            List<Category> list = db.GetDbSet<Category>().ToList();
            List<DTOCategory> dtoList=DTOCategory.DTOlist(list);
            return dtoList;
        }

    }
}

