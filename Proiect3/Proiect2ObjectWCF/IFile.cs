using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Proiect1;

namespace Proiect2ObjectWCF
{
    [ServiceContract]
    interface IFile
    {
        [OperationContract]
        void SaveFile(FileDTO file);
        [OperationContract]
        List<FileDTO> GetAllFiles();
        [OperationContract]
        List<FileDTO> FileFilter(string condition);
        [OperationContract]
        void DeleteFile(FileDTO file);
    }
}
