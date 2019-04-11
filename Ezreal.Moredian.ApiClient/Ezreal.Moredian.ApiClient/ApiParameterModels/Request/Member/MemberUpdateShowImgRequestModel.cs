using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Member
{
    /// <summary>
    /// 修改个性图片
    /// <para>
    /// 其中showFace文件项需要作为单独的接口参数传递,不能定义在模型中
    /// </para>
    /// </summary>
    public class MemberUpdateShowImgRequestModel
    {
        /// <summary>
        /// *魔点内部的人员id
        /// </summary>
        [ApiParameterName("memberId")]
        public long MemberID { get; set; }
    }
}
