﻿using System.ComponentModel.DataAnnotations;

namespace LenaForm.Api.Models
{
    public class RegisterViewModel
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public string email { get; set; }

        public string password { get; set; }
    }

}
