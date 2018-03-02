using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class JcbgCreationDTO
    {
        [DataMember(IsRequired = true)]
        public long Brbh { get; set; }

        public long Sqdh { get; set; }
        public string Jklb { get; set; }
        public string Jcxm { get; set; }
        public string YjYingxiangsj { get; set; }
        public string YjYingxiangzd { get; set; }
    }
}