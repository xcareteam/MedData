using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class TwdCreationDTO
    {
        [DataMember(IsRequired = true)]
        public long Zyh { get; set; }

        public string Dbcs { get; set; }
        public string Xbcs { get; set; }
        public string Prl { get; set; }
        public string Pcl { get; set; }
        public string Xy { get; set; }
        public string Tz { get; set; }
        public string Shts { get; set; }

        [DataMember(IsRequired = true)]
        public decimal Xh { get; set; }

        public decimal Mb { get; set; }
        public decimal Tw { get; set; }
        public decimal Hx { get; set; }
        public decimal? Tt { get; set; }
        public decimal? Jwhtw { get; set; }
        public decimal? Qbqmb { get; set; }
        public decimal? Hxjhx { get; set; }
        public string Ywgm { get; set; }
    }
}