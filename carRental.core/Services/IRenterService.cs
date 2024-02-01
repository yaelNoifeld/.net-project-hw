using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Services
{
    public interface IRenterService
    {
        public List<Renter> GetAll();
        public Renter GetById(int id);
        public Renter Add(Renter renter);
        public Renter Update(int id, Renter renter);
        public void Delete(int id);
    }
}
