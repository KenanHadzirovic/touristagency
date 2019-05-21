using System.Web.Http;
using TouristAgency.Contracts;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    public class TourController : ApiController
    {
        private ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpGet]
        public IHttpActionResult GetTours()
        {
            return Ok(_tourService.GetTours());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult GetTour(int id)
        {
            return Ok(_tourService.GetTour(id));
        }

        [HttpPost]
        public IHttpActionResult CreateTour([FromBody] Tour tour)
        {
            return Ok(_tourService.CreateTour(tour));
        }

        [HttpPut, Route("{tourId}")]
        public IHttpActionResult UpdateTour(int tourId, [FromBody] Tour tour)
        {
            tour.TourId = tourId;
            return Ok(_tourService.UpdateTour(tour));
        }
    }
}
