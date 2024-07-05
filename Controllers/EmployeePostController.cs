using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpPost]
        public ActionResult<EmployeeResponse> CreateEmployee(EmployeeRequest request)
        {
            var response = new EmployeeResponse
            {
                Name = request.Name,
                JobRole = request.JobRole,
                EmployeeId = new Random().Next(1000, 9999) // Generate a random employee ID
            };

            return Ok(response);
        }
    }
}
