using Microsoft.AspNetCore.Mvc;

namespace Getri_webAPI_FirstProgram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult FetchEmployee()
        {
            return Ok("This is first API call.");
        }
    }
}
