using System.Web.Http;
using TouristAgency.Contracts;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    public class SecurityController : ApiController
    {
        private IRoleService _roleService;
        private IPrivilegeService _privilegeService;

        public SecurityController(IRoleService roleService, IPrivilegeService privilegeService)
        {
            _privilegeService = privilegeService;
            _roleService = roleService;
        }

        // Privilege

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

        // Privilege
        [HttpGet]
        public IHttpActionResult GetPrivileges()
        {
            return Ok(_privilegeService.GetPrivileges());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult GetPrivilege(int id)
        {
            return Ok(_privilegeService.GetPrivilege(id));
        }

        [HttpPost]
        public IHttpActionResult CreatePrivilege([FromBody] Privilege privilege)
        {
            return Ok(_privilegeService.CreatePrivilege(privilege));
        }

        [HttpPut, Route("{privilegeId}")]
        public IHttpActionResult UpdatePrivilege(int privilegeId, [FromBody] Privilege privilege)
        {
            privilege.PrivilegeId = privilegeId;
            return Ok(_privilegeService.UpdatePrivilege(privilege));
        }
    }
}
