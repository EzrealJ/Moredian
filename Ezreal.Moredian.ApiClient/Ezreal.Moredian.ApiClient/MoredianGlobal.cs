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
        /// 初始化全局配置
        /// <para>在没有DI的情况下可以使用它来初始化配置</para>
        /// </summary>
        /// <param name="action"></param>   
        public static void InitializeDefaultConfig(Action<MoredianGlobalConfig> action = null)
        {
            action?.Invoke(MoredianGlobalConfig.DefaultInstance);
            Action<HttpApiConfig> configAction = config =>
            {
                config.JsonFormatter = MoredianGlobalConfig.DefaultInstance.DefaultJsonFormatter;
                config.HttpHost = new Uri(MoredianGlobalConfig.DefaultInstance.ApiUri);

                config.FormatOptions.UseCamelCase = true;
                MoredianGlobalConfig.DefaultInstance.ApiActionFilters.ToList().ForEach(filter => config.GlobalFilters.Add(filter));
                if (MoredianGlobalConfig.DefaultInstance.UseLog)
                {
                    config.GlobalFilters.Add(new WebApiClient.Attributes.TraceFilterAttribute());
                }
                config.FormatOptions.DateTimeFormat = WebApiClient.DateTimeFormats.ISO8601_WithMillisecond;
            };
            HttpApi.Register<ApiContract.IAppContract>().ConfigureHttpApiConfig(configAction);
            HttpApi.Register<ApiContract.IOrganizationContract>().ConfigureHttpApiConfig(configAction);
            HttpApi.Register<ApiContract.IDeviceContract>().ConfigureHttpApiConfig(configAction);
            HttpApi.Register<ApiContract.IMemberContract>().ConfigureHttpApiConfig(configAction);
            HttpApi.Register<ApiContract.IGroupContract>().ConfigureHttpApiConfig(configAction);
        }
    }
}
