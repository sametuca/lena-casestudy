
using LenaForm.Core.Abstraction;
using System.Collections.Generic;
using System;

namespace LenaForm.Core.Models
{
    public class Field : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool Required { get; set; }
        public int FormId { get; set; }
        public virtual Form Form { get; set; }
    }

}
