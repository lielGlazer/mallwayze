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
        public long FavoriteCode { get; set; }
        public DTOFavoriteStoresForTheUser()
        {

        }
        public DTOFavoriteStoresForTheUser(FavoriteStoresForTheUser l)
        {
            this.UserCode = l.UserCode;
            this.CodeStor = l.CodeStor;
            this.FavoriteCode = l.FavoriteCode;
           
        }
        public FavoriteStoresForTheUser ToTable(DTOFavoriteStoresForTheUser l)
        {
            FavoriteStoresForTheUser c = new FavoriteStoresForTheUser();
            c.UserCode = l.UserCode;
            c.CodeStor = l.CodeStor;
            c.FavoriteCode = l.FavoriteCode;

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
