using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiClient;

namespace Ezreal.Moredian.ApiClient.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加HttpApi
        /// 返回HttpApi工厂
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static void AddMoredianApiClient(this IServiceCollection services, Action<MoredianGlobalConfig> action = null)

        {
            services.TryAddSingleton(MoredianGlobalConfig.DefaultInstance);
            action?.Invoke(MoredianGlobalConfig.DefaultInstance);

            Action<HttpApiConfig> configAction = config =>
            {
                config.HttpHost = new Uri(MoredianGlobalConfig.DefaultInstance.ApiUri);
                config.FormatOptions.IgnoreNullProperty = true;
                config.FormatOptions.UseCamelCase = true;
                MoredianGlobalConfig.DefaultInstance.ApiActionFilters.ToList().ForEach(filter => config.GlobalFilters.Add(filter));
                if (MoredianGlobalConfig.DefaultInstance.UseLog)
                {
                    config.GlobalFilters.Add(new WebApiClient.Attributes.TraceFilterAttribute());
                }
                config.FormatOptions.DateTimeFormat = WebApiClient.DateTimeFormats.ISO8601_WithMillisecond;
            };

            services.AddHttpApiFactory<ApiContract.IAppContract>(configAction);
            services.AddHttpApiFactory<ApiContract.IOrganizationContract>(configAction);
            services.AddHttpApiFactory<ApiContract.IDeviceContract>(configAction);
            services.AddHttpApiFactory<ApiContract.IMemberContract>(configAction);
            services.AddHttpApiFactory<ApiContract.IGroupContract>(configAction);
        }


        /// <summary>
        /// HttpApi实例工厂创建器
        /// </summary>
        /// <param name="services"></param>
        private static void AddHttpApiFactory<TInterface>(this IServiceCollection services, Action<HttpApiConfig> configAction)
            where TInterface : class, IHttpApi
        {
            services.AddSingleton<IHttpApiFactory<TInterface>, HttpApiFactory<TInterface>>(p =>
            {
                return new HttpApiFactory<TInterface>()
                .ConfigureHttpApiConfig(c => configAction?.Invoke(c));
            });

            services.AddTransient(p =>
            {
                var factory = p.GetRequiredService<IHttpApiFactory<TInterface>>();
                return factory.CreateHttpApi();
            });
        }
    }
}
