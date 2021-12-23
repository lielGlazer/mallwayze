using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoteToRemamber.Models.DTO
{
    public class noteDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public bool complte { get; set; }
        public int userId { get; set; }
        public DateTime date { get; set; }
        public noteDTO()
        {
                
        }
        public noteDTO(note nfirst)
        {
            id = nfirst.id;
            title = nfirst.title;
            date =(DateTime) nfirst.date;
            complte = (bool)nfirst.complte;
            userId = (int)nfirst.userId;  
        }
        public static List<noteDTO> todtoparsedtoinloopnote(List<note> listfortocomperdto)
        {
            List<noteDTO>  notelist = new List<noteDTO>();
            foreach (var h in listfortocomperdto)
            {
                notelist.Add(new noteDTO(h));

            }
            return notelist;
        }
    }
}