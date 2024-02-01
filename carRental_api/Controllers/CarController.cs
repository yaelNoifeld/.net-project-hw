using carRental.core.Models;
using carRental.core.Services;
using carRental.service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        // GET: api/<CarController>
        // GET: api/<CarsController>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _carService.GetAll();
        }

        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _carService.GetById(id);
        }

        // POST api/<CarsController>
        [HttpPost]
        public Car Post([FromBody] Car car)
        {
            _carService.Add(car);
            return car;
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public Car Put(int id, [FromBody] Car car)
        {
            _carService.Update(id, car);
            return car;
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carService.Delete(id);
        }
    }
}
