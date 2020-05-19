using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect1;


namespace MediaGalleryAPI
{
    public static class MediaGalleryAPI
    {
        public static void SaveFile(File file)
        {
            using (var ctx = new Proiect1.Model1Container())
            {
                if (GetAllFiles().Exists(f => f.FilePath == file.FilePath))
                {
                    throw new Exception("File already in gallery.");
                }

                ctx.Files.Add(file);
                ctx.SaveChanges();
            }
        }

        public static List<File> GetAllFiles()
        {
            using (var ctx = new Proiect1.Model1Container())
            {
                return ctx.Files.Include(f => f.Metadata).Include(f => f.Properties).ToList();
            }
        }
    

        public static List<Metadata> GetAllMedata()
        {
            using (var ctx = new Proiect1.Model1Container())
            {
                return ctx.Metadata.ToList();
            }
        }

        public static List<Property> GetAllProperties()
        {
            using (var ctx = new Proiect1.Model1Container())
            {
                return ctx.Properties.ToList();
            }
        }

        public static List<File> FileFilter(string condition)
        {
            /*Functie/Serviciu ce va fi folosita pentru filtrarea fisierelor dupa criteriile
             oferite de utilizator in aplicatie. Return-ul este pus doar pentru a satisface conditia
             functiei de a returna un List<File>*/
            return new List<File>();
        }

        public static void AddProperty(Property property)
        {
            /* Functie/Serviciu folosit pentru a adauga proprietati introduse de utilizator
             in aplicatie pentru un fisier (persoane din fisiere, locuri din fisiere etc. */
            using (var ctx = new Proiect1.Model1Container())
            {
                ctx.Properties.Add(property);
                ctx.SaveChanges();
            }
        }

        public static void DeleteFile(File file)
        {
            /* Functie/Serviciu folosit pentru stergerea unui fisier (marcarea flagului isDeleted din
             tabela Metadata ca fiind True */
            using (var ctx = new Proiect1.Model1Container())
            {
                ctx.Files.Remove(file);
                ctx.SaveChanges();
            }
        }
    }
}
