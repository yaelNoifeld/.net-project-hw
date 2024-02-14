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
    public class RentController : ControllerBase
    {
        private readonly IRentService _rentService;
        private readonly IMapper _mapper;

        public RentController(IRentService rentService, IMapper mapper)
        {
            _rentService = rentService;
            _mapper = mapper;
        }

        // GET: api/<RentController>
        [HttpGet]
        public ActionResult Get()
        {
            var rents = _rentService.GetAll();
            var rentsDto = _mapper.Map<IEnumerable<RentDto>>(rents);
            return Ok(rentsDto);
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var rent= _rentService.GetById(id);
            var rentDto = _mapper.Map<RentDto>(rent);
            return Ok(rentDto);
        }

        // POST api/<RentController>
        [HttpPost]
        public ActionResult Post([FromBody] RentPostModel rent)
        {
            var rentToAdd = new Rent { Car = rent.Car, date = rent.date };
            _rentService.Add(rentToAdd);
            return Ok(rentToAdd);
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RentPostModel rent)
        {
            var rentToUpdate= new Rent { Car = rent.Car, date = rent.date };
            _rentService.Update(id, rentToUpdate);
            return Ok(rentToUpdate);
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _rentService.Delete(id);
        }
    }
}
