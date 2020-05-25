using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SimpleImageGallery.Models;
using SimpleImageGallery.Services;

namespace SimpleImageGallery.Controllers
{
    public class ImageController : Controller
    {
        private IConfiguration _config;
        private ImageService _imageService;
        private string AzureConnectionString { get;  }
        public ImageController(IConfiguration config, ImageService imageService)
        {
            _config = config;
            _imageService = imageService;
            AzureConnectionString = _config["AzureConnectionString"];
        }
        public IActionResult Upload()
        {
            var model = new UploadImageModel();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadNewImage(IFormFile file, string tags, string title)
        {
            var container = _imageService.GetBlobContainer(AzureConnectionString, "images");
            var content = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
            var fileName = content.FileName.Trim('"');

            var blockBlob = container.GetBlockBlobReference(fileName);
            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());
            await _imageService.SetImage(title, tags, blockBlob.Uri);
            return Ok();
        }
    }
}