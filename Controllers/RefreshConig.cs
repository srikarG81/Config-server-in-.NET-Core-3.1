using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Steeltoe.Extensions.Configuration.CloudFoundry;
using Microsoft.Extensions.Options;
namespace MyCompany.SteeltoeExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefreshConigController : ControllerBase
    {
        IConfiguration _configuration;
        public RefreshConigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            if (_configuration is IConfigurationRoot root)
            {
                root.Reload();
            }
            return "value";
        }
       
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
