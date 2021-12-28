using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net;
using System.IO;
using System.Text;
using System.Data;
using DAL;

namespace BL
{
    public static class cateroryManager
    {
        static DBConection db = new DBConection();
        public static  List<DTOcategory> GetCategories()
        {
            List<Category> list = db.GetDbSet<Category>();
            List<DTOcategory> dtoList;
            return dtoList;
        }

    }
}

