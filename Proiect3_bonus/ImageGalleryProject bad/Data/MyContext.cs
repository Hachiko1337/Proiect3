using ImageGalleryProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGalleryProject.ViewModels.CategoryViewModels;
using ImageGalleryProject.ViewModels.MediaViewModels;

namespace ImageGalleryProject.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<ImageGalleryProject.ViewModels.CategoryViewModels.CategoryViewModel> CategoryViewModel { get; set; }
        public DbSet<ImageGalleryProject.ViewModels.CategoryViewModels.CreateCategoryViewModel> CreateCategoryViewModel { get; set; }
        public DbSet<ImageGalleryProject.ViewModels.MediaViewModels.MediaViewModel> MediaViewModel { get; set; }
    }
}
