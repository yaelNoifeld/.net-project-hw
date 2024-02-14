using AutoMapper;
using carRental.Api.Models;
using carRental.core.DTOs;
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
        private readonly IMapper _mapper;
        public RenterController(IRenterService renterService, IMapper mapper)
        {
            _renterService = renterService;
            _mapper = mapper;
        }

        // GET: api/<RenterController>
        [HttpGet]
        public ActionResult Get()
        {
            var renters = _renterService.GetAll();
            var rentersDto = _mapper.Map<IEnumerable<Renter>>(renters);
            return Ok(rentersDto);
        }

        // GET api/<RenterController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var renter = _renterService.GetById(id);
            var renterDto= _mapper.Map<Renter>(renter);
            return Ok(renterDto);
        }

        // POST api/<RenterController>
        [HttpPost]
        public ActionResult Post([FromBody] RenterPostModel renter)
        {
            var renterToAdd= new Renter { DiscountPercent=renter.DiscountPercent, Name=renter.Name, SumRents=renter.SumRents};
            _renterService.Add(renterToAdd);
            return Ok(renterToAdd);
        }

        // PUT api/<RenterController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RenterPostModel renter)
        {
            var renterToUpdate = new Renter { DiscountPercent = renter.DiscountPercent, Name = renter.Name, SumRents = renter.SumRents }; 
            return Ok(_renterService.Update(id, renterToUpdate));
        }

        // DELETE api/<RenterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _renterService.Delete(id);
        }
    }
}
