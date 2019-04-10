using Ezreal.Moredian.ApiClient;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.App;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            MoredianGlobal.InitializeDefaultConfig(config =>
            {
                config.UseLog = true;
            }, new LoggerFactory().AddConsole());
            Console.WriteLine(JsonConvert.SerializeObject(GetAppTokenAsync().Result));
            Console.ReadLine();
        }


        public static async Task<AppTokenGetResponseModel> GetAppTokenAsync()
        {
            AppTokenGetRequestModel requestModel = new AppTokenGetRequestModel()
            {
                AppID = "1630327778383495168",
                AppKey = "bidzXTOptCfmRtF7G8bXZ0FVfXF7OeNs"
            };
            Response<AppTokenGetResponseModel> result = await ApiFactory.CreateAppClient().GetAppToken(requestModel);
            if (result.Result == 0 && result.ExistsBusinessResponseContent)
            {
                return result.BusinessResponseContent;
            }
            return null;
        }
    }
}
