using carRental.core.Models;
using carRental.core.Repositories;
using carRental.core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car Add(Car car)
        {
            _carRepository.Add(car);
            return car;
        }

        public void Delete(int id)
        {
            _carRepository.DeleteById(id);
            //Car c = cars.Find(x => x.id == id);
            //if (c != null)
            //    cars.Remove(c);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetList();
        }

        public Car GetById(int id)
        {
            return _carRepository.GetById(id);
        }

        public Car Update(int id, Car car)
        {
            _carRepository.Update(id, car);
            return car;
            //Car c = cars.Find(x => x.id == id);
            //if (c != null)
            //{
            //    c.loc = car.loc;
            //    c.status = car.status;
            //    return;
            //}
            //car.id = ++idCounter;
            //cars.Add(car);
        }
    }
}
