using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Proiect1;

namespace Proiect2ObjectWCF
{
    [DataContract(IsReference = true)]
    public partial class MetadataDTO
    {
        [DataMember]
        public int FileID { get; set; }
        [DataMember]
        public string FIleType { get; set; }
        [DataMember]
        public System.DateTime CreatedAt { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }
        [DataMember]
        public virtual FileDTO File { get; set; }
    }
}
