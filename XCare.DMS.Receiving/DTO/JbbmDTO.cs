using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class JbbmCreationDTO
    {
        [DataMember(IsRequired = true)]
        public int Code { get; set; }

        [DataMember(IsRequired = true)]
        public string Name { get; set; }

        public string Pydm { get; set; }
        public string Zzzz { get; set; }
        public string Icd9 { get; set; }
        public string Icd10 { get; set; }
        public int Dmlb { get; set; }
        public byte Zfpb { get; set; }
        public string Shicd10 { get; set; }
        public string Shjbmc { get; set; }
    }
}