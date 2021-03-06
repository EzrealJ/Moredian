﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Defaults;

namespace Ezreal.Moredian.ApiClient
{
    /// <summary>
    /// Api使用的Json格式化配置
    /// </summary>
    public class ApiJsonFormatter : JsonFormatter
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected override JsonSerializerSettings CreateSerializerSettings(FormatOptions options)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            JsonSerializerSettings jsonSerializerSettings = base.CreateSerializerSettings(options);
            jsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            return jsonSerializerSettings;
        }
    }
}
