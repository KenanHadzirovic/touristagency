using System.Threading.Tasks;
using System.Web.Http;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private IUserService _userService;

        UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }
    }
}
