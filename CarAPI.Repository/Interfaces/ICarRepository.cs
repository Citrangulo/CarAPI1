using System;
using System.Collections.Generic;
using System.Text;
using CarAPI.Domain.Entities;
using CarAPI.Domain.Entities.Interfaces;

namespace CarAPI.Repository.Interfaces
{
    public interface ICarRepository<T> where T : IEntity
    {
        Car FindByKey(Guid key);
        List<T> List();

        void Add(T obj);
    }
}
