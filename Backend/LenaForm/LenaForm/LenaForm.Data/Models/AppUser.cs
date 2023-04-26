using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LenaForm.Data.Models
{
    public enum Gender { Unknown, Male, Female }
    public class AppUser : IdentityUser
    {
        public Gender Gender { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
