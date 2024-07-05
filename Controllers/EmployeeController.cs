using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployee()
        {
            var employee = new
            {
                name = "Nicolas Borrazas",
                jobRole = "IT Helpdesk"
            };

            return Ok(employee);
        }
    }
}
