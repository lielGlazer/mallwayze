using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;


namespace API2.Controllers
{
    public class CategoryForStorController : ApiController
    {
        public List<DTOCategoryForStor> GetCaterory()
        {
            List<DTOCategoryForStor> u = BL.ManagerCategoryForStor.GetCategoryForStor();
            return u;
        }
        [Route("api/CategoryForStor/GetAllStorsToCategory/{nameOfCategory}")]
        [HttpGet]
        public List<DTOStor> GetAllStorsToCategory(string nameOfCategory)
        {
            List<DTOStor> listOFstor = BL.ManagerCategoryForStor.GetAllStorOfXContaining(nameOfCategory);
            return listOFstor;
        }

    }
}
