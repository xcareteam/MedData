using System;
using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class BrzdCreationDTO
    {
        [DataMember(IsRequired = true)]
        public long Zyh { get; set; }

        [DataMember(IsRequired = true)]
        public string Zd { get; set; }

        [DataMember(IsRequired = true)]
        public string Zdlb { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime Zdsj { get; set; }

        public string Name { get; set; }
        public string Jbzg { get; set; }
    }
}