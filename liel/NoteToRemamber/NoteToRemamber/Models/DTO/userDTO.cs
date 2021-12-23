using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoteToRemamber.Models.DTO
{
    public class userDTO
    {
        public string name { get; set; }
        public string last { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int id { get; set; }
        public userDTO(user ufirst)
        {
            id = ufirst.id;
            email = ufirst.email;
            name = ufirst.name;
            last = ufirst.last;
            password = ufirst.password;
          
        }
        public static List<userDTO> todtoparsedtoinloop(List<user> listfortocomperdto)
        {
            List<userDTO> userlist = new List<userDTO>();
            foreach (var h in listfortocomperdto)
            {
                userlist.Add(new userDTO(h));

            }
            return userlist;
        }
        public user tocomparfromdtotouserorginal()
        {
            user us = new user();
            us.email = email;
            us.id = id;
            us.last = last;
            us.name = name;
            return us;
        }
    }

}