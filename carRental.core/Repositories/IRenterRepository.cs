using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Repositories
{
    public interface IRenterRepository
    {
        public List<Renter> GetList();
        public Renter Add(Renter renter);
        public Renter Update(int id, Renter renter);
        public Renter GetById(int id);
        public void Delete(int id);
    }
}
