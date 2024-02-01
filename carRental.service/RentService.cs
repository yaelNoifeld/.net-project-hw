using carRental.core.Models;
using carRental.core.Repositories;
using carRental.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.service
{
    public class RentService : IRentService
    {
        private readonly IRentRepository _rentRepository;
        public RentService(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }

        public Rent Add(Rent rent)
        {
            _rentRepository.Add(rent);
            return rent;
        }

        public void Delete(int id)
        {
            _rentRepository.DeleteById(id);
        }

        public List<Rent> GetAll()
        {
            return _rentRepository.GetList();
        }

        public Rent GetById(int id) => _rentRepository.GetById(id);

        public Rent Update(int id, Rent rent)
        {
            _rentRepository.Update(id, rent);
            return rent;
        }
    }
}
