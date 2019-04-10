using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Response
{
    /// <summary>
    /// 简单值类型响应结果
    /// </summary>
    /// <typeparam name="TStruct">值类型</typeparam>
    public class ResponseOfStruct<TStruct> : ResponseModel
          where TStruct : struct
    {
        /// <summary>
        /// 业务返回内容
        /// </summary>

        [ApiParameterName("data")]
        public TStruct BusinessResponseContent { get; set; }
    }
    /// <summary>
    /// 字符串响应结果
    /// </summary>
    public class ResponseOfString : ResponseModel
    {
        /// <summary>
        /// 业务返回内容
        /// </summary>

        [ApiParameterName("data")]
        public string BusinessResponseContent { get; set; }
    }
}
