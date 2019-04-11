using Ezreal.Moredian.ApiClient;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.App;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Device;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Member;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.Device;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.Member;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            string appToken = GetAppTokenAsync().Result.AppToken;
            //OrganizationCreateResponseModel createOrganizationResult = CreateOrganizationAsync(appToken).Result;

            string accessToken = GetOrganizationAccessToken(appToken).Result.AccessToken;
            //ActivationResponseModel activationResult = Activation(accessToken).Result;
           
        
            //string memberCreateResult = MemberCreate(accessToken).Result.BusinessResponseContent;
            //string memberCreateResult1 = MemberCreate1(accessToken).Result.BusinessResponseContent;
            //string memberUpdateResult = MemberUpdate(accessToken, memberCreateResult).Result.BusinessResponseContent;
            //ResponseModel updateVerifyImgResult = UpdateVerifyImg(accessToken, memberCreateResult).Result;
            //ResponseModel memberDeleteResult = MemberDelete(accessToken, memberCreateResult).Result;
            //Thread.Sleep(5000);
            string deviceId = GetDeviceID(accessToken, "130102181211KN4578").Result.BusinessResponseContent;
            var unbindResult = Unbind(accessToken, deviceId, "130102181211KN4578");
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


        public static async Task<OrganizationCreateResponseModel> CreateOrganizationAsync(string appToken)
        {
            OrganizationInfoModel requestModel = new OrganizationInfoModel()
            {
                Address = "科锐5-306",
                OrganizationName = "鼎图",
                Contact = "姜",
                Phone = "123456"
            };
            Response<OrganizationCreateResponseModel> result = await ApiFactory.CreateAppClient().CreateOrganization(appToken, requestModel);
            if (result.Result == 0 && result.ExistsBusinessResponseContent)
            {
                return result.BusinessResponseContent;
            }
            return null;
        }

        public static async Task<OrganizationAccessTokenGetResponseModel> GetOrganizationAccessToken(string appToken)
        {
            OrganizationAccessTokenGetRequestModel requestModel = new OrganizationAccessTokenGetRequestModel()
            {
                OrganizationAuthKey = "mnDN889nHdVVFWQHSBjzWLouPdKvhJHw",
                OrganizationID = "1630492498977619968"
            };
            Response<OrganizationAccessTokenGetResponseModel> result = await ApiFactory.CreateAppClient().GetOrganizationAccessToken(appToken, requestModel);
            if (result.Result == 0 && result.ExistsBusinessResponseContent)
            {
                return result.BusinessResponseContent;
            }
            return null;
        }

        public static async Task<ActivationResponseModel> Activation(string accessToken)
        {
            string qrCode = Console.ReadLine();
            ActivationRequestModel requestModel = new ActivationRequestModel()
            {
                QRCode = qrCode
            };
            Response<ActivationResponseModel> result = await ApiFactory.CreateDeviceClient().Activation(accessToken, requestModel);
            if (result.Result == 0 && result.ExistsBusinessResponseContent)
            {
                return result.BusinessResponseContent;
            }
            return null;
        }
        public static async Task<ResponseOfString> GetDeviceID(string accessToken, string sn)
        {


            return await ApiFactory.CreateDeviceClient().GetDeviceID(accessToken, sn);

        }
        public static async Task<ResponseModel> Unbind(string accessToken, string deviceId, string sn)
        {

            UnbindRequestModel requestModel = new UnbindRequestModel()
            {
                DeviceId = deviceId,
                DeviceSn = sn
            };
            return await ApiFactory.CreateDeviceClient().Unbind(accessToken, requestModel);

        }

        public static async Task<ResponseOfString> MemberCreate(string accessToken)
        {

            MemberBaseInfo requestModel = new MemberBaseInfo()
            {
                TpUserID = "20190411",
                MemberName = "明星1"
            };
            return await ApiFactory.CreateMemberClient().Create(accessToken, requestModel, new WebApiClient.Parameterables.MulitpartFile("E:\\111.jpg"));

        }

        public static async Task<ResponseOfString> MemberCreate1(string accessToken)
        {

            MemberBaseInfo requestModel = new MemberBaseInfo()
            {
                TpUserID = "20190412",
                MemberName = "明星2"
            };
            return await ApiFactory.CreateMemberClient().Create(accessToken, requestModel, new WebApiClient.Parameterables.MulitpartFile("E:\\111.jpg"));

        }

        public static async Task<ResponseOfString> MemberUpdate(string accessToken, string moredianId)
        {

            MemberBaseInfo requestModel = new MemberBaseInfo()
            {
                MemberID = Convert.ToInt64(moredianId),
                MemberName = "明星1"
            };
            return await ApiFactory.CreateMemberClient().Update(accessToken, requestModel, new WebApiClient.Parameterables.MulitpartFile("E:\\111.jpg"));

        }
        public static async Task<ResponseModel> UpdateVerifyImg(string accessToken, string moredianId)
        {

            MemberUpdateVerifyImgRequestModel requestModel = new MemberUpdateVerifyImgRequestModel()
            {
                MemberID = Convert.ToInt64(moredianId),

            };
            return await ApiFactory.CreateMemberClient().UpdateVerifyImg(accessToken, requestModel, new WebApiClient.Parameterables.MulitpartFile("E:\\111.jpg"));

        }
        public static async Task<ResponseOfStruct<bool>> MemberDelete(string accessToken, string moredianId)
        {

            MemberDeleteRequestModel requestModel = new MemberDeleteRequestModel()
            {
                MemberID = Convert.ToInt64(moredianId),
                
            };
            return await ApiFactory.CreateMemberClient().Delete(accessToken, requestModel);

        }
    }
}
