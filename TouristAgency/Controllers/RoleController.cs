using System.Threading.Tasks;
using System.Web.Http;
using TouristAgency.Contracts;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    [RoutePrefix("api/useraccount")]
    public class RoleController : ApiController
    {
        private IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public IHttpActionResult GetRoles()
        {
            return Ok(_roleService.GetRoles());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult GetRole(int id)
        {
            return Ok(_roleService.GetRole(id));
        }

        [HttpPost]
        public IHttpActionResult CreateRole([FromBody] Role role)
        {
            return Ok(_roleService.CreateRole(role));
        }

        [HttpPut, Route("{roleId}")]
        public IHttpActionResult UpdateRole(int roleId, [FromBody] Role role)
        {
            role.RoleId = roleId;
            return Ok(_roleService.UpdateRole(role));
        }
    }
}
