using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Repositories
{
    public interface ICarRepository
    {
        public List<Car> GetList();
        public Car Add(Car car);
        public Car Update(int id, Car car);
        public Car GetById(int id);
        public void DeleteById(int id);
    }
}
