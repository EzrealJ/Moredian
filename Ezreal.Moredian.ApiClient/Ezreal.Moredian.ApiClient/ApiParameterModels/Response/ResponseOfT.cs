using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Response
{
    /// <summary>
    /// 响应结果
    /// </summary>
    /// <typeparam name="T">业务响应模型</typeparam>
    public class Response<T> : ResponseModel where T : class, IBusinessResponseModel
    {

        /// <summary>
        /// 业务返回内容
        /// </summary>

        [ApiParameterName("data")]
        public T BusinessResponseContent { get; set; }
        /// <summary>
        /// 存在有效的业务响应
        /// </summary>
        public bool ExistsBusinessResponseContent { get => this.BusinessResponseContent != null; }

    }
}
