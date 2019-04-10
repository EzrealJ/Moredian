using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App
{
    /// <summary>
    /// 获取appToken的有效响应参数模型
    /// </summary>
    public class AppTokenGetResponseModel : IBusinessResponseModel
    {
        /// <summary>
        /// 授权方（企业）appToken，用于其他接口调用时校验使用
        /// </summary>
        public string AppToken { get; set; }

        /// <summary>
        /// 授权方（企业）expires，用于控制appToken失效时间，appToken失效后重新通过该接口获取。默认为7200秒。
        /// </summary>
        public int Expires { get; set; }
    }
}
