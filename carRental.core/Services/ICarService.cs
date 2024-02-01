using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Services
{
    public interface ICarService
    {
        public List<Car> GetAll();
        public Car GetById(int id);
        public Car Add(Car car);
        public Car Update(int id, Car car);
        public void Delete(int id);
    }
}
