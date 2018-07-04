using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ApiCurso.Controllers
{
    [Route("api/google")]
    public class GoogleController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDotnetInfo()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var data =  await client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            client?.Dispose();
            return Ok(data);
        }
    }
}
