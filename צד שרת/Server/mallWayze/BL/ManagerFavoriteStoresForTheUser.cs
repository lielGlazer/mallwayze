﻿using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class ManagerFavoriteStoresForTheUser
    {
        static DBConection db = new DBConection();
        //רשימת כל החניות האוהובות למשתמש שליפה מהדאטה בייס
        public static List<DTOFavoriteStoresForTheUser> GetFavoriteStoresForTheUser()
        {
            List<FavoriteStoresForTheUser> list = db.GetDbSet<FavoriteStoresForTheUser>().ToList();
            List<DTOFavoriteStoresForTheUser> dtoList = DTOFavoriteStoresForTheUser.DTOlist(list);
            return dtoList;
        }
        //רשימת כל החניות המועדפות תחילה על ידי המשתמש
        public static List<DTOStor> GetAllStorForUser(DTOUsers user)

        {
            List<DTOFavoriteStoresForTheUser> h= GetFavoriteStoresForTheUser().Where(s => s.UserCode == user.UserCode).ToList();
            List<DTOStor> stores = new List<DTOStor>();
            foreach (var s in h)
            {
                stores.Add(new DTOStor(db.GetDbSet<Stor>().Find(store => store.CodeStor == s.CodeStor)));
            }
            return stores;

        }

    }
}
