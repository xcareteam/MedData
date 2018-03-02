using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class GyzdCreationDTO
    {
        [DataMember(IsRequired = true)]
        public int Dmlb { get; set; }

        [DataMember(IsRequired = true)]
        public int Dmsb { get; set; }

        [DataMember(IsRequired = true)]
        public string Dmmc { get; set; }

        public string Srdm { get; set; }
    }
}