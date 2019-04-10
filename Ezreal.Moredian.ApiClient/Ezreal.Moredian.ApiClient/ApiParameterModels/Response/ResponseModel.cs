using System;
using System.Collections.Generic;
using System.Text;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Response
{
    /// <summary>
    /// 响应模型
    /// </summary>
    public  class ResponseModel : ApiParameterModelBase
    {
        /// <summary>
        /// 响应码
        /// </summary>
        public int Result { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { get; set; }
    }
}
