using System.ComponentModel;
using System.Runtime.Serialization;

namespace XCare.DMS.Receiving.DTO
{
    public class BrxzCreationDTO
    {
        /// <summary>
        ///     编码
        /// </summary>
        [DataMember(IsRequired = true)]
        public int Brxz { get; set; }

        /// <summary>
        ///     名称
        /// </summary>
        [DataMember(IsRequired = true)]
        public string Xzmc { get; set; }

        /// <summary>
        ///     拼音首字母代码
        /// </summary>
        [DataMember(IsRequired = true)]
        public string Pydm { get; set; }

        [DataMember(IsRequired = true)]
        public int Sjxz { get; set; }

        [DataMember(IsRequired = true)]
        public int Gsxz { get; set; }
    }
}