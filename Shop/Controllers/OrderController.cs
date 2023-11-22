using Microsoft.AspNetCore.Mvc;
using Shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly static List<Order> orders=new List<Order>();
        // GET: api/<OrderController>
        [HttpGet]
        public List<Order> Get()
        {
            return orders;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var order = orders.Find(o => o.Id == id);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            orders.Add(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Order order)
        {
            var order2 = orders.Find(o => o.Id == id);
            if (order2 == null)
                return NotFound();
            orders.Remove(orders.Find(o => o.Id == id));
            orders.Add(order);
            return Ok();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = orders.Find(e => e.Id == id);
            if (employee == null)
                return NotFound();
            orders.Remove(employee);
            return Ok();
        }
    }
}
