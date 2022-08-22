using Buoi5.Dto;
using Buoi5.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buoi5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentServices _studentService;

        public StudentsController(IStudentServices studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public IActionResult PostStudent(CreateStudentsDto input)
        {
            try
            {
                _studentService.CreateStudent(input);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_studentService.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult GetById(int Id)
        {
            try
            {
                return Ok(_studentService.GetById(Id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult PutById(UpdateStudentsDto input)
        {
            try
            {
                return Ok(_studentService.UpdateStudent(input));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteById(int Id)
        {
            try
            {
                _studentService.DeleteById(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
            return Ok();
        }



    }
}
