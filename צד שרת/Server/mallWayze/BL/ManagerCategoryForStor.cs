using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class ManagerCategoryForStor
    {
        static DBConection db = new DBConection();
        public static List<DTOCategoryForStor> GetCategoryForStor()
        {
            List<CategoryForStor> list = db.GetDbSet<CategoryForStor>().ToList();
            List<DTOCategoryForStor> dtoList = DTOCategoryForStor.DTOlist(list);
            return dtoList;
        }

    }
}
