using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BL;

namespace BL.Models
{
   public class UserInformation
    {  //איפה שמים את זה 
       public List<DTOStor>FStor=new List<DTOStor>();
       public string UserName;
       public string Password;
       public UserInformation()
        {
                
        }

    }
}
