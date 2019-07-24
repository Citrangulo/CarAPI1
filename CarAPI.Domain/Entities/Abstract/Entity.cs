using System;
using System.Collections.Generic;
using System.Text;
using CarAPI.Domain.Entities.Interfaces;

namespace CarAPI.Domain.Entities.Abstract
{
    public abstract class Entity : IEntity
    {
        public Guid Key { get;}

        protected Entity()
        {
            Key = Guid.NewGuid();
        }
    }
}
