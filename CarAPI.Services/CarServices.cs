using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using CarAPI.Domain;
using CarAPI.Domain.Entities;
using CarAPI.Repository;
using CarAPI.Services.Interfaces;
using CarAPI.Business.Interfaces;
using CarAPI.Business;

namespace CarAPI.Services
{
    public sealed class CarServices : ICarServices
    {
        private readonly ICarBusiness _carBusiness;

        public CarServices(ICarBusiness carBusiness)
        {
            _carBusiness = carBusiness;
        }

        public Car FindByKey(Guid key)
        {
            return _carBusiness.FindByKey(key);
        }

        public List<Car> List()
        {
            return _carBusiness.List();
        }

        public void Add(Car car)
        {
            _carBusiness.Add(car);
        }
    }

}
