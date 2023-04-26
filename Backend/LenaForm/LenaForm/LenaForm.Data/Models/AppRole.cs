using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaForm.Data.Models
{
    public class AppRole : IdentityRole
    {
        public DateTime CreatedOn { get; set; }
    }
}
