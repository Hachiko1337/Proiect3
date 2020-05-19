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
    interface IProperties
    {
        [OperationContract]
        List<PropertyDTO> GetAllProperties();
        [OperationContract]
        void AddProperty(PropertyDTO property);
    }
}
