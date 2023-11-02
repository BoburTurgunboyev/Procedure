using Microsoft.AspNetCore.Mvc;
using Procedure2.Entities;
using Procedure2.Services;

namespace Procedure2.Controllers

{
    [Route("api/ [Controller]")]
    [ApiController]
    public class StudentkaController:ControllerBase
    {
        StudentkaService studentkaService = new StudentkaService();

        [HttpGet]

        public IActionResult GetStudentsByYear(int a,int b) 
        {
            var studentka = studentkaService.GetStudentkabyYear(a,b);
            return Ok(studentka);
        }
    }
}
