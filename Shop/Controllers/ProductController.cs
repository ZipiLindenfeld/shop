using Microsoft.AspNetCore.Mvc;
using Shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DataContext context;
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Product> Get()
        {
            return context.Products;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{price}")]
        public IActionResult Get(int price)
        {
            var product = context.Products.Find(e => e.Price == price);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            context.Products.Add(product);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            var product2 = context.Products.Find(e => e.Id == id);
            if (product2 == null)
                return NotFound();
            context.Products.Remove(context.Products.Find(e => e.Id == id));
            context.Products.Add(product);
            return Ok();
        }
        // PUT api/<EmployeeController>/5
        [HttpPut("{id}/price")]
        public IActionResult Put(int id, [FromBody] int price)
        {
            var product2 = context.Products.Find(e => e.Id == id);
            if (product2 == null)
                return NotFound();
            context.Products.Find(e => e.Id == id).Price=price;
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(e => e.Id == id);
            if (product == null)
                return NotFound();
            context.Products.Remove(product);
            return Ok();
        }
    }
}
