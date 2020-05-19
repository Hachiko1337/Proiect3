using System;
using System.Collections.Generic;
using Proiect1.API;

namespace Proiect1.Service
{
    public class FileService
    {
        private FileRepository fileRepository = new FileRepository();
        public void SaveFile(File file)
        {
            if (GetAllFiles().Exists(f => f.FilePath == file.FilePath))
            {
                throw new Exception("File already in gallery.");
            }
            fileRepository.SaveFile(file);
            }

        public List<File> GetAllFiles()
        {
            return fileRepository.GetAllFiles();
        }

        public List<Metadata> GetAllMedata()
        {
            return fileRepository.GetAllMetadata();
        }

        public List<Property> GetAllProperties()
        {
            return fileRepository.GetAllProperties();
        }

        public List<File> FileFilter(string condition)
        {
            /*Functie/Serviciu ce va fi folosita pentru filtrarea fisierelor dupa criteriile
             oferite de utilizator in aplicatie. Return-ul este pus doar pentru a satisface conditia
             functiei de a returna un List<File>*/
            return new List<File>();
        }

        public void AddProperty(Property property)
        {
            /* Functie/Serviciu folosit pentru a adauga proprietati introduse de utilizator
             in aplicatie pentru un fisier (persoane din fisiere, locuri din fisiere etc. */
        }

        public void DeleteFile(File file)
        {
            /* Functie/Serviciu folosit pentru stergerea unui fisier (marcarea flagului isDeleted din
             tabela Metadata ca fiind True */
        }
    }

}
