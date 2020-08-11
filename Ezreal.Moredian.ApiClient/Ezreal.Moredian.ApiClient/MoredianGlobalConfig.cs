using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient;

namespace Ezreal.Moredian.ApiClient
{
    public class MoredianGlobalConfig
    {

        public static MoredianGlobalConfig DefaultInstance { get; set; } = new MoredianGlobalConfig();
        /// <summary>
        /// 生产环境Uri
        /// </summary>
        public string ProductionEnvironmentApiUri { get; set; } = "https://oapi.moredian.com/";


        /// <summary>
        /// Api地址
        /// </summary>
        public string ApiUri => ProductionEnvironmentApiUri;


        /// <summary>
        /// 启用日志,默认false
        /// <para>
        /// 将会在日志中记录请求内容
        /// </para>
        /// </summary>
        public bool UseLog { get; set; } = false;
        /// <summary>
        /// 默认的Json序列化设置
        /// <para>
        /// 在没有详细阅读代码的情况下请不要改动
        /// </para>
        /// </summary>
        public IJsonFormatter DefaultJsonFormatter { get; set; } = new ApiJsonFormatter();
        /// <summary>
        /// 全局拦截器集合
        /// </summary>
        public List<IApiActionFilter> ApiActionFilters { get; set; } = new List<IApiActionFilter>();
    }
}
