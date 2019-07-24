using System;
using System.Collections.Generic;
using CarAPI.Business.Interfaces;
using CarAPI.Domain.Entities;
using CarAPI.Domain;
using CarAPI.Repository.Interfaces;

namespace CarAPI.Business
{
    public class CarBusiness : ICarBusiness
    {
        private readonly ICarRepository<Car> _carRepository;

        public CarBusiness(ICarRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public Car FindByKey(Guid key)
        {
            return _carRepository.FindByKey(key);

        }

        public List<Car> List()
        {
            return _carRepository.List();
        }

        public void Add(Car car)
        {
            _carRepository.Add(car);
        }
    }
}
