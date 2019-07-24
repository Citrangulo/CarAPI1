using System;
using System.Collections.Generic;
using System.Text;

namespace CarAPI.Domain.Entities.Interfaces
{
    public interface IEntity
    {
        Guid Key { get; }
    }
}
