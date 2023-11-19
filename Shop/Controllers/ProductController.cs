using Microsoft.AspNetCore.Mvc;
using Shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly static List<Product> products = new List<Product>();
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Product> Get()
        {
            return products;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = products.Find(e => e.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            products.Add(product);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product product)
        {
            var product2 = products.Find(e => e.Id == id);
            if (product2 == null)
                return NotFound();
            products.Remove(products.Find(e => e.Id == id));
            products.Add(product);
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            var product = products.Find(e => e.Id == id);
            if (product == null)
                return NotFound();
            products.Remove(product);
            return Ok();
        }
    }
}
