using System;
using System.Linq;
using System.Collections.Generic;
using CarAPI.Domain;
using CarAPI.Domain.Entities;
using CarAPI.Repository.Interfaces;

namespace CarAPI.Repository
{
    public class CarRepository : ICarRepository<Car>

    {
        private readonly List<Car> _data;

        public CarRepository()
        {
            _data = new List<Car>();
        }

        public Car FindByKey(Guid key)
        {
            return _data.FirstOrDefault(w => w.Key == key);
        }

        public List<Car> List()
        {
            return _data;
        } 

        public void Add(Car car)
        {
            _data.Add(car);
        }
    }
}
