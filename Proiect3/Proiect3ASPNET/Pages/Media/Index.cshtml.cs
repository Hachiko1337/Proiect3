using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect3ASPNET.Models;
using ServiceReferenceProiect3;
//using MediaGalleryModels.API;


namespace Proiect3ASPNET.Pages.Media
{
    public  class IndexModel : PageModel
    {
        FileMetadataPropertyClient p2c = new FileMetadataPropertyClient();

        /*private readonly MediaGalleryModels.API.FileContext _context;*/

        public List<Models.FileDTO> Files { get; set; }
        [BindProperty(SupportsGet = true)]
        public string searchString { get; set; }
        public int numberOfResults { get; set; }

        public IndexModel(/*MediaGalleryModels.API.FileContext context*/)
        {
            Files = new List<Models.FileDTO>();
            //_context = context;
        }
        public  async Task OnGetAsync()
        {
            var files2 = await p2c.GetAllFilesAsync();
            foreach (var item in files2)
            {
                Models.FileDTO fd = new Models.FileDTO();
                fd.Id = item.Id;
                fd.FilePath = item.FilePath;
                foreach(var pp in item.Properties)
                {
                    Models.PropertyDTO pdto = new Models.PropertyDTO();
                    pdto.EventName = pp.EventName;
                    pdto.LandscapeName = pp.LandscapeName;
                    pdto.PersonName = pp.PersonName;
                    pdto.PlaceName = pp.PlaceName;
                    pdto.FileId1 = pp.FileId1;
                    fd.Properties.Add(pdto);
                }
                Files.Add(fd);
            }

            //var file1 = new Models.FileDTO
            //{
            //    Id = 1,
            //    FilePath = "E:\\Wallpapers\\712437.jpg"
            //};
            //var file2 = new Models.FileDTO
            //{
            //    Id = 2,
            //    FilePath = "E:\\Wallpapers\\861304.jpg"
            //};
            //var file3 = new Models.FileDTO
            //{
            //    Id = 3,
            //    FilePath = "E:\\Wallpapers\\lost-paradise-wallpaper.jpg"
            //};
            //Files.Add(file1);
            //Files.Add(file2);
            //Files.Add(file3);


            numberOfResults = Files.Count();
            var files = from f in Files select f; //_context.Files
            if (!string.IsNullOrEmpty(searchString))
            {
                files = files.Where(s => s.FilePath.Contains(searchString));
            }
            //Files = await files.GetAllFilesAsync();
        }

        public async Task OnPostAsync()
        {
            /* Codul pentru filtrare poate fi mutat in OnPostAsync din motive de securitate, deoarece prin metoda GET se poate vedea la URL-ul
             * aplicatiei  acel searchString. Nu reprezinta o problema prea mare in acest caz, insa nu am dori ca informatii mai sensibile precum nume
             * de utilizatori sa apara in URL */
        }
    }
}