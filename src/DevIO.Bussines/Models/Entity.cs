using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Bussines.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
