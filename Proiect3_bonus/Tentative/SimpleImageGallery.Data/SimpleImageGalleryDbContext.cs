using Microsoft.EntityFrameworkCore;
using SimpleImageGallery.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleImageGallery.Data
{
    class SimpleImageGalleryDbContext : DbContext
    {
        public SimpleImageGalleryDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}
