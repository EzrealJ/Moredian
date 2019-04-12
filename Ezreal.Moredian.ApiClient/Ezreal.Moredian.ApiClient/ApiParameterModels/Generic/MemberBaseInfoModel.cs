using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Generic
{
    /// <summary>
    /// 成员基础信息
    /// <para>
    /// 其中verifyFace和showFace文件项需要作为单独的接口参数传递,不能定义在模型中
    /// </para>
    /// </summary>
    public class MemberBaseInfoModel
    {
        /// <summary>
        /// **企业内的人员id，非魔点内部的人员id,在创建人员的时候必须
        /// <para>
        /// 文档描述是long类型，经过确认实际为varchar(128)
        /// </para>
        /// </summary>
   
        public string TpUserId { get; set; }
        /// <summary>
        /// **魔点内部的人员id，在修改人员的时候必须 
        /// </summary>
      
        public ulong MemberId { get; set; }

        /// <summary>
        /// *人员名称
        /// </summary>
        public string MemberName { get; set; }

        ///// <summary>
        ///// 识别验证图片（底库图片）
        ///// </summary>
        //public string VerifyFace { get; set; }

        ///// <summary>
        ///// 个性图片
        ///// </summary>
        //public string ShowFace { get; set; }

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
        /// 性别
        /// </summary>
        public Enums.EnumSex Sex { get; set; }

        /// <summary>
        /// 证件
        /// </summary>
        public Enums.EnumCertType CertType { get; set; }

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
