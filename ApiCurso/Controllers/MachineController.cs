using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiCurso.Controllers
{
    [Route("api/machine")]
    public class MachineController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetMachineName()
        {
            return Ok(new { name = Environment.MachineName });
        }
    }
}
