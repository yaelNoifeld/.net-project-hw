using carRental.core.Models;
using carRental.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace carRental.data.Repository
{
    public class RenterRepository : IRenterRepository
    {
        private readonly DataContext _context;

        public RenterRepository(DataContext context)
        {
            _context = context;
        }

        public Renter Add(Renter renter)
        {
            _context.Renters.Add(renter);
            _context.SaveChanges();
            return renter;
        }

        public void Delete(int id)
        {
            _context.Renters.Remove(GetById(id));
            _context.SaveChanges();
        }

        public Renter GetById(int id)
        {
            return _context.Renters.ToList().Find(x => x.Id == id);
        }

        public List<Renter> GetList()
        {
            return _context.Renters.ToList();
        }

        public Renter Update(int id, Renter renter)
        {
            Renter renterToUpdate = _context.Renters.ToList().Find(x => x.Id == id);
            if (renterToUpdate != null)
                _context.Renters.Remove(renterToUpdate);
            _context.Renters.Add(renter);
            _context.SaveChanges();
            return renter;
        }
    }
}
