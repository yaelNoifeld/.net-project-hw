using carRental.core.Models;
using carRental.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace carRental.data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;
        public CarRepository(DataContext context)
        {
            _context = context;
        }

        public Car Add(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car;
        }

        public void DeleteById(int id)
        {
            _context.Cars.Remove(GetById(id));
            _context.SaveChanges();
        }

        public Car GetById(int id)
        {
            return _context.Cars.ToList().Find(x => x.Id == id);
        }

        public List<Car> GetList()
        {
            return _context.Cars.ToList();
        }

        public Car Update(int id, Car car)
        {
            Car carToUpdate = _context.Cars.ToList().Find(x => x.Id == id);
            if (carToUpdate != null)
                _context.Cars.Remove(carToUpdate);
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car;
        }
    }
}
