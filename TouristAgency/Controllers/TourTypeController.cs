using System.Web.Http;
using TouristAgency.Contracts;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    [RoutePrefix("api/tourType")]
    public class TourTypeController : ApiController
    {
        private ITourTypeService _tourTypeService;

        public TourTypeController(ITourTypeService tourTypeService)
        {
            _tourTypeService = tourTypeService;
        }

        [HttpGet]
        public IHttpActionResult GetTourTypes()
        {
            return Ok(_tourTypeService.GetTourTypes());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult GetTourType(int id)
        {
            return Ok(_tourTypeService.GetTourType(id));
        }

        [HttpPost]
        public IHttpActionResult CreateTourType([FromBody] TourType tourType)
        {
            return Ok(_tourTypeService.CreateTourType(tourType));
        }

        [HttpPut, Route("{tourTypeId}")]
        public IHttpActionResult UpdateTourType(int tourTypeId, [FromBody] TourType tourType)
        {
            tourType.TourTypeId = tourTypeId;
            return Ok(_tourTypeService.UpdateTourType(tourType));
        }
    }
}
