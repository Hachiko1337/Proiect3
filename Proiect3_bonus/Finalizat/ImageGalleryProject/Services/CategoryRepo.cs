using ImageGalleryProject.Data;
using ImageGalleryProject.Infrastructure;
using ImageGalleryProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Services
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly MyContext _context;
        public CategoryRepo(MyContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var category = GetById(id);
            _context.Categories.Remove(category);
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public Category GetById(int Id)
        {
            return _context.Categories.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void Insert(Category category)
        {
            _context.Categories.Add(category);
        }
        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }

    }
}
