using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiSolution.Model;

namespace ApiSolution.Controller
{
    public class LocationController : ApiController
    {
        [HttpGet]
        public IEnumerable<Locations> GetAllusers()
        {

            var locations = location.FirstOrDefault(p => p.sartdate == DateTime.Today.AddHours(10) && p.enddate == DateTime.Today.AddHours(13));
            if (locations == null)
            {
                return null;
            }
           // return Ok(locations);
            return location;
        }
        Locations[] location = new Locations[]
       {

        new Locations { locationID = 1, sartdate = DateTime.Today.AddHours(10),enddate=DateTime.Today.AddHours(13)},
        new Locations { locationID = 2, sartdate = DateTime.Today.AddHours(13),enddate=DateTime.Today.AddHours(18) },
        new Locations { locationID = 3, sartdate = DateTime.Today.AddHours(20),enddate=DateTime.Today.AddHours(24) },
       };
        //// GET api/<controller>
        //[HttpGet]
        //public IHttpActionResult Getuses()
        //{

        //    var locations = location.FirstOrDefault(p => p.sartdate == DateTime.Today.AddHours(10) && p.enddate == DateTime.Today.AddHours(13));
        //    if (locations == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(locations);
        //}

    }
}