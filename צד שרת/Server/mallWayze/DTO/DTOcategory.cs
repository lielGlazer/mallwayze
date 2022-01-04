using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTOCategory
    {
        public long CategoryCode { get; set; }
        public string NameCategory { get; set; }
        public DTOCategory()
        {

        }
        public DTOCategory(Category c)
        {
            this.CategoryCode = c.CategoryCode;
            this.NameCategory = c.NameCategory;

        }
        public DTOCategory(DTOCategory c)
        {
            this.CategoryCode = c.CategoryCode;
            this.NameCategory = c.NameCategory;

        }
        public static List<DTOCategory> DTOlist(List<Category> t)
        {
            List<DTOCategory> dtolist = new List<DTOCategory>();
            foreach (var c in t)
            {
                DTOCategory dto = new DTOCategory(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }

    }
}
