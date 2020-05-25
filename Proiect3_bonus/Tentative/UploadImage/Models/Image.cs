using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace UploadImage.Models
{
    public class Image
    {
        public int ImageId {get; set;}
        public string Title { get; set; }
        [DisplayName("Upload File")]
        public string ImagePath { get; set; }
        public HttpPostedFileBase MyProperty { get; set; }
        public object ImageFile { get;  set; }
    }
}
