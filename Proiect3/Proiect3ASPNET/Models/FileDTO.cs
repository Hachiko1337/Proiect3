using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Proiect3ASPNET.Models
{
    public class FileDTO
    {
        public FileDTO()
        {
            this.Properties = new List<PropertyDTO>();
            this.Metadata = new MetadataDTO();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FilePath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<PropertyDTO> Properties { get; set; }
        [DataMember]
        public virtual MetadataDTO Metadata { get; set; }
    }
}
