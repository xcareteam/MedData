using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class JybgCreationDTO
    {
        [DataMember(IsRequired = true)]
        public long? Zyh { get; set; }

        public string Txm { get; set; }
        public string Kzxm { get; set; }

        [DataMember(IsRequired = true)]
        public string Ybh { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime DateTest { get; set; }

        [DataMember(IsRequired = true)]
        public long Rowid { get; set; }

        public string Jcmd { get; set; }
        public virtual List<JybgxqCreateionDTO> Items { get; set; }
    }

    public class JybgxqCreateionDTO
    {
        [DataMember(IsRequired = true)]
        public string Xmmc { get; set; }

        [DataMember(IsRequired = true)]
        public string Xmcdz { get; set; }

        public string Ts { get; set; }
        public string Ckfw { get; set; }
        public string Dw { get; set; }
        public DateTime? DateTest { get; set; }
        public string Ybh { get; set; }
        public Guid JybgId { get; set; }
    }
}