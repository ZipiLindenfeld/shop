using Microsoft.AspNetCore.Mvc;
using Shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        DataContext context;
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Provider> Get()
        {
            return context.Providers;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var provider = context.Providers.Find(e => e.Id == id);
            if (provider == null)
                return NotFound();
            return Ok(provider);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Provider provider)
        {
            context.Providers.Add(provider);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Provider provider)
        {
            var provider2 = context.Providers.Find(e => e.Id == id);
            if (provider2 == null)
                return NotFound();
            context.Providers.Remove(context.Providers.Find(e => e.Id == id));
            context.Providers.Add(provider);
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var provider = context.Providers.Find(e => e.Id == id);
            if(provider == null)
                return NotFound();
            context.Providers.Remove(provider);
            return Ok();
        }
    }
}
