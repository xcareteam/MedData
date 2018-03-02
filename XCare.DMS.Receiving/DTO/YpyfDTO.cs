using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class YpyfCreationDTO
    {
        [DataMember(IsRequired = true)]
        public int Code { get; set; }

        [DataMember(IsRequired = true)]
        public string Name { get; set; }

        public short? Lb { get; set; }
    }
}