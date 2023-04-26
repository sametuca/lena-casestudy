using System.ComponentModel.DataAnnotations;

namespace LenaForm.Api.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Rol adı zorunludur.")]
        public string Name { get; set; }
    }

}
