using System.Web.Http;
using TouristAgency.Contracts;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    [RoutePrefix("api/hotel")]
    public class HotelController : ApiController
    {
        private IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public IHttpActionResult GetHotels()
        {
            return Ok(_hotelService.GetHotels());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult GetHotel(int id)
        {
            return Ok(_hotelService.GetHotel(id));
        }

        [HttpPost]
        public IHttpActionResult CreateHotel([FromBody] Hotel hotel)
        {
            return Ok(_hotelService.CreateHotel(hotel));
        }

        [HttpPut, Route("{hotelId}")]
        public IHttpActionResult UpdateHotel(int hotelId, [FromBody] Hotel hotel)
        {
            hotel.HotelId = hotelId;
            return Ok(_hotelService.UpdateHotel(hotel));
        }
    }
}
