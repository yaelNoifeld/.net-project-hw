using carRental.core.Models;
using carRental.core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenterController : ControllerBase
    {
        private readonly IRenterService _renterService;
        public RenterController(IRenterService renterService)
        {
            _renterService = renterService;
        }

        // GET: api/<RenterController>
        [HttpGet]
        public IEnumerable<Renter> Get()
        {
            return _renterService.GetAll();
        }

        // GET api/<RenterController>/5
        [HttpGet("{id}")]
        public Renter Get(int id)
        {
            return _renterService.GetById(id);
        }

        // POST api/<RenterController>
        [HttpPost]
        public Renter Post([FromBody] Renter renter)
        {
            _renterService.Add(renter);
            return renter;
        }

        // PUT api/<RenterController>/5
        [HttpPut("{id}")]
        public Renter Put(int id, [FromBody] Renter renter)
        {
            _renterService.Update(id, renter);
            return renter;
        }

        // DELETE api/<RenterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _renterService.Delete(id);
        }
    }
}
