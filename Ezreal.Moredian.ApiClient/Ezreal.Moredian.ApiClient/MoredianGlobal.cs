using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient;

namespace Ezreal.Moredian.ApiClient
{
    public class MoredianGlobal
    {
        /// <summary>
        /// 静态的全局配置信息
        /// </summary>
        public static MoredianGlobalConfig GlobalConfig { get; set; } = new MoredianGlobalConfig();
        /// <summary>
        /// 初始化全局配置
        /// <para>在没有DI的情况下可以使用它来初始化配置</para>
        /// </summary>
        /// <param name="action"></param>   
        /// <param name="loggerFactory">日志工厂</param>
        public static void InitializeDefaultConfig(Action<MoredianGlobalConfig> action, ILoggerFactory loggerFactory = null)
        {
            action.Invoke(GlobalConfig);
            Action<HttpApiConfig> configAction = config =>
            {
                config.JsonFormatter = GlobalConfig.DefaultJsonFormatter;
                config.HttpHost = new Uri(GlobalConfig.ApiUri);
                
                config.FormatOptions.UseCamelCase = true;
                GlobalConfig.ApiActionFilters.ToList().ForEach(filter => config.GlobalFilters.Add(filter));
                if (GlobalConfig.UseLog)
                {
                    config.GlobalFilters.Add(new WebApiClient.Attributes.TraceFilterAttribute());
                }
                config.FormatOptions.DateTimeFormat = WebApiClient.DateTimeFormats.ISO8601_WithMillisecond;
                config.LoggerFactory = loggerFactory;
            };
            HttpApi.Register<ApiContract.IAppContract>().ConfigureHttpApiConfig(configAction);
            HttpApi.Register<ApiContract.IOrganizationContract>().ConfigureHttpApiConfig(configAction);
            HttpApi.Register<ApiContract.IDeviceContract>().ConfigureHttpApiConfig(configAction);
            HttpApi.Register<ApiContract.IMemberContract>().ConfigureHttpApiConfig(configAction);
        }
    }
}
