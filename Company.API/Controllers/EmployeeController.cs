using Company.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmpService _service;
        public EmployeeController(IEmpService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllEmps()
        {
            return Ok(_service.GetAllEmps());
        }
        [HttpGet]
        public IActionResult GetEmp(int id)
        {
            return Ok(_service.GetEmp(id));
        }
        [HttpDelete]
        public IActionResult DeleteEmp(int id)
        {
            _service.DeleteEmp(id);
            return Ok($"The {id} is deleted successfully..");
        }
    }
}
