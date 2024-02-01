﻿using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core.Repositories
{
    public interface IRentRepository
    {
        public List<Rent> GetList();
        public Rent Add(Rent rent);
        public Rent Update(int id, Rent rent);
        public Rent GetById(int id);
        public void DeleteById(int id);
    }
}
