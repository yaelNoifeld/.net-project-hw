using carRental.core.Models;
using carRental.core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly IRentService _rentService;

        public RentController(IRentService rentService)
        {
            _rentService = rentService;
        }

        // GET: api/<RentController>
        [HttpGet]
        public IEnumerable<Rent> Get()
        {
            return _rentService.GetAll();
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public Rent Get(int id)
        {
            return _rentService.GetById(id);
        }

        // POST api/<RentController>
        [HttpPost]
        public Rent Post([FromBody] Rent rent)
        {
            _rentService.Add(rent);
            return rent;
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public Rent Put(int id, [FromBody] Rent rent)
        {
            _rentService.Update(id, rent);
            return rent;
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _rentService.Delete(id);
        }
    }
}
