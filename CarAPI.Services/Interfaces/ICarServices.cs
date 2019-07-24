using System;
using System.Collections.Generic;
using System.Text;
using CarAPI.Domain;
using CarAPI.Domain.Entities;


namespace CarAPI.Services.Interfaces
{
    public interface ICarServices
    {
        Car FindByKey(Guid key);
        List<Car> List();

        void Add(Car car);
    }
}
