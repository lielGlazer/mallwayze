using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class ManagerFavoriteStoresForTheUser
    {
        static DBConection db = new DBConection();
        public static List<DTOFavoriteStoresForTheUser> GetFavoriteStoresForTheUser()
        {
            List<FavoriteStoresForTheUser> list = db.GetDbSet<FavoriteStoresForTheUser>().ToList();
            List<DTOFavoriteStoresForTheUser> dtoList = DTOFavoriteStoresForTheUser.DTOlist(list);
            return dtoList;
        }

    }
}
