using AutoMapper;
using Proiect1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2ObjectWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class FileMetadataProperty : IFileMetadataProperty
    {
        MapperConfiguration config;
        private IMapper iMapper;
        public FileMetadataProperty()
        {
            config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<File, FileDTO>();
                    cfg.CreateMap<FileDTO, File>();
                    cfg.CreateMap<MetadataDTO, Metadata>();
                    cfg.CreateMap<PropertyDTO, Property>();
                    cfg.CreateMap<Metadata, MetadataDTO>();
                    cfg.CreateMap<Property, PropertyDTO>();
                });
            iMapper = config.CreateMapper();
        }
        void IProperties.AddProperty(PropertyDTO property)
        {
            MediaGalleryAPI.MediaGalleryAPI.AddProperty(iMapper.Map<PropertyDTO, Property>(property));
        }

        void IFile.DeleteFile(FileDTO file)
        {
            MediaGalleryAPI.MediaGalleryAPI.DeleteFile(iMapper.Map<FileDTO, File>(file));
        }

        List<FileDTO> IFile.FileFilter(string condition)
        {
            return iMapper.Map<List<File>, List<FileDTO>>(MediaGalleryAPI.MediaGalleryAPI.FileFilter(condition));
        }

        List<FileDTO> IFile.GetAllFiles()
        {
            return iMapper.Map<List<File>, List<FileDTO>>(MediaGalleryAPI.MediaGalleryAPI.GetAllFiles());
        }

        List<MetadataDTO> IMetadata.GetAllMedata()
        {
            return iMapper.Map<List<Metadata>, List<MetadataDTO>>(MediaGalleryAPI.MediaGalleryAPI.GetAllMedata());
        }

        List<PropertyDTO> IProperties.GetAllProperties()
        {
            return iMapper.Map<List<Property>, List<PropertyDTO>>(MediaGalleryAPI.MediaGalleryAPI.GetAllProperties());
        }

        void IFile.SaveFile(FileDTO file)
        {
            MediaGalleryAPI.MediaGalleryAPI.SaveFile(iMapper.Map<FileDTO, File>(file));
        }
    }
}
