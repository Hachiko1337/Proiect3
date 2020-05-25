﻿using System;
using System.Collections.Generic;
using System.Linq;
using SimpleImageGallery.Data.Models;
using System.Threading.Tasks;

namespace SimpleImageGallery.Models
{
    public class GalleryIndexModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }
        public string SearchQuery { get; set; }
    }
}
