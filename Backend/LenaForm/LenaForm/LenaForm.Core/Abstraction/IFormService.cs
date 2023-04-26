using LenaForm.Core.Models;
using System.Collections.Generic;

namespace LenaForm.Core.Services
{
    public interface IFormService
    {
        void AddForm(Form form);

        Form GetFormById(int id);

        List<Form> GetAllForm();
    }
}
