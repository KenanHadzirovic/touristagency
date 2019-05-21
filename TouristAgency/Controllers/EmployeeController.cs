using System.Threading.Tasks;
using System.Web.Http;
using TouristAgency.Contracts;
using TouristAgency.Services;

namespace TouristAgency.Controllers
{
    [RoutePrefix("api/useraccount")]
    public class EmployeeController : ApiController
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IHttpActionResult GetEmployees()
        {
            return Ok(_employeeService.GetEmployees());
        }

        [Route("{id}"), HttpGet]
        public IHttpActionResult GetEmployee(int id)
        {
            return Ok(_employeeService.GetEmployee(id));
        }

        [HttpPost]
        public IHttpActionResult CreateEmployee([FromBody] Employee employee)
        {
            return Ok(_employeeService.CreateEmployee(employee));
        }

        [HttpPut, Route("{employeeId}")]
        public IHttpActionResult UpdateEmployee(int employeeId, [FromBody] Employee employee)
        {
            employee.EmployeeId = employeeId;
            return Ok(_employeeService.UpdateEmployee(employee));
        }
    }
}
