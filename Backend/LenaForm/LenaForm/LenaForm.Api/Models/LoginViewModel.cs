using System.ComponentModel.DataAnnotations;

namespace LenaForm.Api.Models
{
    public class LoginViewModel
    {
        public string username { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

    }

}
