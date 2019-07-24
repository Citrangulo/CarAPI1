using System;
using System.Collections.Generic;
using System.Text;
using CarAPI.Domain.Entities;

namespace CarAPI.Business.Interfaces
{
    public interface ICarBusiness
    {
        Car FindByKey(Guid key);
        List<Car> List();

        void Add(Car car);
    }
}
