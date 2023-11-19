using Microsoft.AspNetCore.Mvc;
using Shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly static List<Employee> employees=new List<Employee>();
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
                return NotFound();
            return Ok(employee);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            employees.Add(employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Employee employee)
        {
            var employee2 = employees.Find(e => e.Id == id);
            if (employee2 == null)
                return NotFound();
            employees.Remove(employees.Find(e => e.Id == id));
            employees.Add(employee);
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<Employee> Delete(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
                return NotFound();
            employees.Remove(employee);
            return Ok();
        }
    }
}
