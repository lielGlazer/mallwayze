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
    [RoutePrefix("api/location")]
    public class LocationController : ApiController
    {
        [HttpGet]
        [Route("locationForStor/{nameStore}")]
        public DTOLocations LocationForStor(string nameStore)
        {
            return ManagerLocations.LocationForStor(nameStore);
        }
    }
}
