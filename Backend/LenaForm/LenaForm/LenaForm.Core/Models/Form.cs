using LenaForm.Core.Abstraction;
using System;
using System.Collections.Generic;

namespace LenaForm.Core.Models
{
    public class Form : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public virtual ICollection<Field> Fields { get; set; }
    }
}
