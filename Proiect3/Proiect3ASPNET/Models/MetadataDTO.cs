using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Proiect3ASPNET.Models
{
    public class MetadataDTO
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
