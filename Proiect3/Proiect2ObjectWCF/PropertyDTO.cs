using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2ObjectWCF
{
    [DataContract(IsReference=true)]
    public partial class PropertyDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int FileId1 { get; set; }
        [DataMember]
        public string EventName { get; set; }
        [DataMember]
        public string PersonName { get; set; }
        [DataMember]
        public string LandscapeName { get; set; }
        [DataMember]
        public string PlaceName { get; set; }
        [DataMember]
        public virtual FileDTO File { get; set; }
    }
}
