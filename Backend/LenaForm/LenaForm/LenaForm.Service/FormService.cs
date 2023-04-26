using LenaForm.Core.Models;
using LenaForm.Core.Services;
using LenaForm.Data;
using LenaForm.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LenaForm.Service
{
    public class FormService : IFormService
    {
        private readonly AppDbContext _dbContext;

        public FormService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void AddForm(Core.Models.Form form)
        {
            //automapper kullanılabilir
            _dbContext.Forms.Add(new Data.Entities.Form
            {
                Id = form.Id,
                Name = form.Name,
                Description = form.Description,
                CreatedAt = form.CreatedAt,
                CreatedBy = form.CreatedBy,
                Fields = form.Fields.Select(f => new Data.Entities.Field
                {
                    Id = f.Id,
                    Name = f.Name,
                    DataType = f.DataType,
                    Required = f.Required
                }).ToList()
            });
            _dbContext.SaveChanges();
        }

        public List<Data.Entities.Form> GetAllForm()
        {
            return _dbContext.Forms.ToList();
        }

        public Data.Entities.Form GetFormById(int id)
        {
            return _dbContext.Forms.FirstOrDefault(f => f.Id == id);
        }

        List<Core.Models.Form> IFormService.GetAllForm()
        {
            //autoMapper kullanılacak
            var result = _dbContext.Forms.Include(f => f.Fields).ToList();
            return result.Select(f => new Core.Models.Form
            {
                Id = f.Id,
                Name = f.Name,
                Description = f.Description,
                CreatedAt = f.CreatedAt,
                CreatedBy = f.CreatedBy,
                Fields = f.Fields.Select(x => new Core.Models.Field
                {
                    Id = x.Id,
                    Name = x.Name,
                    DataType = x.DataType,
                    Required = x.Required,
                    FormId = x.FormId
                }).ToList()
            }).ToList();
        }

        Core.Models.Form IFormService.GetFormById(int id)
        {
            //autoMapper kullanılacak
            var result = _dbContext.Forms.Include(f => f.Fields).FirstOrDefault(f => f.Id == id);
            return new Core.Models.Form
            {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description,
                CreatedAt = result.CreatedAt,
                CreatedBy = result.CreatedBy,
                Fields = result.Fields.Select(x => new Core.Models.Field
                {
                    Id = x.Id,
                    Name = x.Name,
                    DataType = x.DataType,
                    Required = x.Required,
                    FormId = x.FormId
                }).ToList()
            };
        }
    }
}
