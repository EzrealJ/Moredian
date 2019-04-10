using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Generic
{
    class MemberInfo
    {
        /// <summary>
        /// **企业内的人员id，非魔点内部的人员id
        /// </summary>
        [ApiParameterName("tpUserId")]
        public long TpUserID { get; set; }
        /// <summary>
        /// **魔点内部的人员id
        /// </summary>
        [ApiParameterName("memberId")]
        public long MemberId { get; set; }
        
        /// <summary>
        /// *人员名称
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 识别验证图片（底库图片）
        /// </summary>
        public string VerifyFace { get; set; }

        /// <summary>
        /// 个性图片
        /// </summary>
        public string ShowFace { get; set; }

        /// <summary>
        /// *手机号
        /// </summary>
        public string Mobile { get; set; }


        /// <summary>
        /// *昵称
        /// </summary>
        public string NickName { get; set; }


        /// <summary>
        /// 生日，格式 yyyy-MM-dd
        /// </summary>
        public string Birthday { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// 性别,见性别常量PERSON_SEX
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 证件，见证件常量 CERT_TYPE
        /// </summary>
        public int CertType { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        public string CertNo { get; set; }


        /// <summary>
        /// 个性签名
        /// </summary>
        public string Signature { get; set; }




    }
}
