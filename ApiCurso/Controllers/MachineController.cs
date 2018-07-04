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
            var envValue = Environment.GetEnvironmentVariable("TIPO_BANCO");
            return Ok(new { nome = Environment.MachineName, data = DateTime.UtcNow, banco = envValue });
        }
    }
}
