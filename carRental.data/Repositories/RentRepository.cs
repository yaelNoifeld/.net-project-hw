using carRental.core.Models;
using carRental.core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace carRental.data.Repository
{
    public class RentRepository : IRentRepository
    {
        private readonly DataContext _context;
        public RentRepository(DataContext context)
        {
            _context = context;
        }

        public Rent Add(Rent rent)
        {
            _context.Rents.Add(rent);
            _context.SaveChanges();
            return rent;
        }

        public void DeleteById(int id)
        {
            _context.Rents.Remove(GetById(id));
            _context.SaveChanges();
        }

        public Rent GetById(int id)
        {
            return _context.Rents.Include(r=>r.Car).Include(r=>r.Renter).ToList().Find(x => x.Id == id);
        }

        public List<Rent> GetList()
        {
            return _context.Rents.Include(r => r.Car).Include(r => r.Renter).ToList();
        }

        public Rent Update(int id, Rent rent)
        {
            Rent rentToUpdate = _context.Rents.ToList().Find(x => x.Id == id);
            if (rentToUpdate != null)
                _context.Rents.Remove(rentToUpdate);
            _context.Rents.Add(rent);
            _context.SaveChanges();
            return rent;
        }
    }
}
