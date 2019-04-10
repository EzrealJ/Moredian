using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.App
{
    /// <summary>
    /// 获取appToken的请求参数模型
    /// </summary>
    public class AppTokenGetRequestModel : RequestModel
    {
        /// <summary>
        /// 开发者申请接入后，生成的appid，参见开放平台我的联调页面
        /// </summary>
        [ApiParameterName("appId")]
        public string AppID { get; set; }
        /// <summary>
        /// 开发者申请接入后，生成的appkey，参见开放平台我的联调页面
        /// </summary>
        public string AppKey { get; set; }
    }
}
