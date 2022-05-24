using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTOCategoryForStor
    {
        public long CodeStor { get; set; }
        public long categoryCode { get; set; }
        public string categoryName { get; set; }
        public DTOCategoryForStor()
        {

        }
        public DTOCategoryForStor(CategoryForStor l)
        {
            this.CodeStor =l.CodeStor;
            this.categoryCode = l.categoryCode;
          //  this.categoryName = l.categoryName;
           
        }
        public CategoryForStor ToTable(DTOCategoryForStor l)
        {
            CategoryForStor c = new CategoryForStor();
            c.CodeStor = l.CodeStor;
            c.categoryCode = l.categoryCode;
           // c.categoryName = l.categoryName;
            return c;
        }
        public static List<DTOCategoryForStor> DTOlist(List<CategoryForStor> t)
        {
            List<DTOCategoryForStor> dtolist = new List<DTOCategoryForStor>();
            foreach (var c in t)
            {
                DTOCategoryForStor dto = new DTOCategoryForStor(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }

    }
}
