using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Services
{
    public interface IRentService
    {
        public List<Rent> GetAll();
        public Rent GetById(int id);
        public Rent Add(Rent rent);
        public Rent Update(int id, Rent rent);
        public void Delete(int id);
    }
}
