using System;
using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class JbxxCreationDTO
    {
        [DataMember(IsRequired = true)]
        public long Zyh { get; set; }

        [DataMember(IsRequired = true)]
        public string Zyhm { get; set; }

        [DataMember(IsRequired = true)]
        public string Brxm { get; set; }

        [DataMember(IsRequired = true)]
        public double Xb { get; set; }

        public int? Nl { get; set; }
        public int? Brqk { get; set; }
        public int? Brxx { get; set; }
        public int? Ryqk { get; set; }
        public string Brzt { get; set; }
        public string Brxz { get; set; }
        public string Ryzd { get; set; }
        public short Zyzt { get; set; }
        public string Sfzh { get; set; }
        public string Xx { get; set; }
        public string Ysqk { get; set; }
        public DateTime Ryrq { get; set; }
        public DateTime? Cyrq { get; set; }
        public byte Ywgm { get; set; }
    }
}