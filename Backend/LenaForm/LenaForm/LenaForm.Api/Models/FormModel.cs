using LenaForm.Api.Controllers;
using System.Collections.Generic;
using System;

namespace LenaForm.Api.Models
{
    public class FormModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public List<FormFieldModel> Fields { get; set; }
    }
}
