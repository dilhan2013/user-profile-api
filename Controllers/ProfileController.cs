using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserProfileApi.Service;

namespace user_profile_api.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        private readonly DocumentDbTester _dbTester;

        public ProfileController(DocumentDbTester dbTester)
        {
            _dbTester = dbTester;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            try
            {
                await _dbTester.Test();
            }
            catch (Exception e)
            {
                
            }
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
