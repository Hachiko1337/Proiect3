using ImageGalleryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGalleryProject.Infrastructure
{
    public interface IMediaRepo
    {
        List<Media> GetAll();
        Media GetById(int Id);
        void Insert(Media mediaManager);
        void Update(Media mediaManager);
        void Delete(int id);
        void AddRange(List<Media> model);
    }
}
