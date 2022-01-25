using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class DTOFavoriteStoresForTheUser
    {
        public long UserCode { get; set; }
        public long CodeStor { get; set; }
        public bool LikeStor { get; set; }
        public DTOFavoriteStoresForTheUser()
        {

        }
        public DTOFavoriteStoresForTheUser(FavoriteStoresForTheUser l)
        {
            this.UserCode = l.UserCode;
            this.CodeStor = l.CodeStor;
            this.LikeStor = l.LikeStor;
           
        }
        public FavoriteStoresForTheUser ToTable(DTOFavoriteStoresForTheUser l)
        {
            FavoriteStoresForTheUser c = new FavoriteStoresForTheUser();
            c.UserCode = l.UserCode;
            c.CodeStor = l.CodeStor;
            c.LikeStor = l.LikeStor;

            return c;
        }

       
        public static List<DTOFavoriteStoresForTheUser> DTOlist(List<FavoriteStoresForTheUser> t)
        {
            List<DTOFavoriteStoresForTheUser> dtolist = new List<DTOFavoriteStoresForTheUser>();
            foreach (var c in t)
            {
                DTOFavoriteStoresForTheUser dto = new DTOFavoriteStoresForTheUser(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }

    }
}
