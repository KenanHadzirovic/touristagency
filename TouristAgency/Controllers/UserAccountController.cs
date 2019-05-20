using System.Threading.Tasks;
using System.Web.Http;
using TouristAgency.Contracts;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    [RoutePrefix("api/useraccount")]
    public class UserAccountController : ApiController
    {
        private IUserAccountService _userAccountService;

        public UserAccountController(IUserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        [HttpGet]
        public IHttpActionResult GetUserAccounts()
        {
            return Ok(_userAccountService.GetUserAccounts());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult GetUserAccount(int id)
        {
            return Ok(_userAccountService.GetUserAccount(id));
        }

        [HttpPost]
        public IHttpActionResult CreateUserAccount([FromBody] UserAccount userAccount)
        {
            return Ok(_userAccountService.CreateUserAccount(userAccount));
        }

        [HttpPut, Route("{userAccountId}")]
        public IHttpActionResult UpdateUserAccount(int userAccountId, [FromBody] UserAccount userAccount)
        {
            userAccount.UserAccountId = userAccountId;
            return Ok(_userAccountService.UpdateUserAccount(userAccount));
        }
    }
}
