using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Member
{
    /// <summary>
    /// 修改识别照片
    /// <para>
    /// 其中verifyFace文件项需要作为单独的接口参数传递,不能定义在模型中
    /// </para>
    /// </summary>
    public class MemberUpdateVerifyImgRequestModel
    {
        /// <summary>
        /// *魔点内部的人员id
        /// </summary>
        public long MemberId { get; set; }
    }
}
