using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            var now = DateTime.Now;
            CreatedAt = now;
            UpdatedAt = now;
            IsActive = true;
        }
    }
}
