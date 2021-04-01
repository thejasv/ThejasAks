using CustomerManagementProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepo<Customer> repository;

        public CustomerController(IRepo<Customer> _repo)
        {
            repository = _repo;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            try
            {
                var customers = repository.GetItems();
                return Ok(customers);
            }
            catch(Exception)
            {
                return BadRequest("no values");
            }
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer customer)
        {
            try
            {
                repository.AddItem(customer);
                return Ok(customer);
            }
            catch(Exception)
            {
                return BadRequest("not possible");
            }
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
