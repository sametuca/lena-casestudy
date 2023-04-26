using LenaForm.Api.Models;
using LenaForm.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LenaForm.Api.Controllers
{
    [Route("api/form/")]
    [ApiController]
    public class FormController :Controller
    {
        private readonly IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpPost("createform")]
        public IActionResult CreateForm(FormModel model)
        {
            //automapper kullanılacak. core katmanında ki form kullanılmayacak
            _formService.AddForm(new Core.Models.Form
            {
                Name = model.Name,
                Description = model.Description,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                Fields = model.Fields.Select(x => new Core.Models.Field
                {
                    Name = x.Name,
                    DataType = x.DataType,
                    Required = x.Required,
                }).ToList()
            });
            return Ok(new { message = "Form başarıyla oluşturuldu." });
        }

        [HttpGet("getform")]
        public async Task<IActionResult> GetForms(int formId)
        {
            var forms = _formService.GetFormById(formId);
            return Ok(forms);
        }
    }


}
