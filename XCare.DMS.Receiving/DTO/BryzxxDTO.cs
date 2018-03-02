using System;
using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class BryzxxCreationDTO
    {
        [DataMember(IsRequired = true)]
        public long Rowid { get; set; }

        [DataMember(IsRequired = true)]
        public long Zyh { get; set; }

        public long? Sqdh { get; set; }

        [DataMember(IsRequired = true)]
        public long Yzzh { get; set; }

        [DataMember(IsRequired = true)]
        public byte Lsyz { get; set; }

        [DataMember(IsRequired = true)]
        public string Yzmc { get; set; }

        [DataMember(IsRequired = true)]
        public byte Yzlx { get; set; }

        [DataMember(IsRequired = true)]
        public decimal Ycjl { get; set; }

        [DataMember(IsRequired = true)]
        public string Jldw { get; set; }

        [DataMember(IsRequired = true)]
        public decimal Sl { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime? Kssj { get; set; }

        public DateTime? Tzsj { get; set; }

        [DataMember(IsRequired = true)]
        public string Gytj { get; set; }

        public string Sypc { get; set; }

        [DataMember(IsRequired = true)]
        public short Mrcs { get; set; }

        public short? Mzcs { get; set; }
        public decimal Dj { get; set; }
        public DateTime? Zxsj { get; set; }
        public string Fysx { get; set; }
        public byte? Yjzx { get; set; }

        [DataMember(IsRequired = true)]
        public short Xmlx { get; set; }

        public int? Code { get; set; }

        [DataMember(IsRequired = true)]
        public string Pccode { get; set; }

        public byte Sybz { get; set; }
        public byte? Ystj { get; set; }
        public string Fysj { get; set; }
        public string Yysj { get; set; }
    }
}