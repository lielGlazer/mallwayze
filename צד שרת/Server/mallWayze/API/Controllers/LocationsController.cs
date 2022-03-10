﻿using DTO;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [Route("api/location")]
    public class LocationsController : ApiController
    {
        // GET: api/Locations
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Locations/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Locations
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Locations/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Locations/5
        public void Delete(int id)
        {
        }
        [HttpGet]
        [Route("locationForStor/{nameStore}")]
        public static DTOLocations LocationForStor(string nameStore)
        {
          return  ManagerLocations.LocationForStor(nameStore);
        }
    }
}
