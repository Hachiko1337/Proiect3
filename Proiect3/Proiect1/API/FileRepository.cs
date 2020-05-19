using System.Collections.Generic;
using System.Linq;

namespace Proiect1.API
{
    class FileRepository
    {
        public void SaveFile(File fileToSave)
        {
            using (var ctx = new FileContext())
            {
                ctx.Files.Add(fileToSave);
                ctx.SaveChanges();
            }
        }

        public List<File> GetAllFiles()
        {
            using (var ctx = new FileContext())
            {
                return ctx.Files.ToList();
            }
        }

        public List<Metadata> GetAllMetadata()
        {
            using (var ctx = new FileContext())
            {
                return ctx.Metadata.ToList();
            }
        }

        public List<Property> GetAllProperties()
        {
            using (var ctx = new FileContext())
            {
                return ctx.Properties.ToList();
            }
        }
    }
}
