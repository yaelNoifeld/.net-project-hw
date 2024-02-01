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
    public class RenterService : IRenterService
    {
        private readonly IRenterRepository _renterRepository;
        public RenterService(IRenterRepository renterRepository)
        {
            _renterRepository = renterRepository;
        }

        public Renter Add(Renter renter)
        {
            _renterRepository.Add(renter);
            return renter;
        }

        public void Delete(int id)
        {
            _renterRepository.Delete(id);
        }

        public List<Renter> GetAll()
        {
            return _renterRepository.GetList();
        }

        public Renter GetById(int id) => _renterRepository.GetById(id);

        public Renter Update(int id, Renter renter)
        {
            _renterRepository.Update(id, renter);
            return renter;
        }
    }

}
