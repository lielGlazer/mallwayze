using DTO;
using BL;
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
    //[Route("api/location")]
    public class LocationsController : ApiController
    {
      
        [HttpGet]
        //מקבל שם חנות ולבסוף מחזיר את המיקום שלה 
       
        
        [Route("locationForStor/{nameStore}")]
        public DTOLocations LocationForStor(string nameStore)
        {
            return ManagerLocations.LocationForStor(nameStore);
        }
    }
}
