using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouristAgency.Contracts;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    [RoutePrefix("api/tourist")]
    public class TouristController : ApiController
    {
        private ITouristService _touristService;

        public TouristController(ITouristService touristService)
        {
            _touristService = touristService;
        }

        [HttpGet]
        public IHttpActionResult GetTourists()
        {
            return Ok(_touristService.GetTourists());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult GetTourist(int id)
        {
            return Ok(_touristService.GetTourist(id));
        }

        [HttpPost]
        public IHttpActionResult CreateTourist([FromBody] Tourist tourist)
        {
            return Ok(_touristService.CreateTourist(tourist));
        }

        [HttpPut, Route("{tourId}")]
        public IHttpActionResult UpdateTourist(int touristId, [FromBody] Tourist tourist)
        {
            tourist.TouristId = touristId;
            return Ok(_touristService.UpdateTourist(tourist));
        }
    }
}