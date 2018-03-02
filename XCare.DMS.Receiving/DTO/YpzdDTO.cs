using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class YpzdCreationDTO
    {
        public string Ypjc { get; set; }

        [DataMember(IsRequired = true)]
        public int Xh { get; set; }

        [DataMember(IsRequired = true)]
        public string Ypmc { get; set; }
    }
}