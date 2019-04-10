using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.App;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App;
using System.Threading;
using WebApiClient;
using WebApiClient.Attributes;

namespace Ezreal.Moredian.ApiClient.ApiContract
{
    public interface IAppContract : IHttpApi
    {
        [HttpGet("app/getAppToken")]
        [JsonReturn]
        ITask<Response<AppTokenGetResponseModel>> GetAppToken(
            [PathQuery]AppTokenGetRequestModel requestModel,
            [Timeout]double timeout = 10000,
            CancellationToken cancellationToken = default(CancellationToken));

        [HttpGet("app/createOrg")]
        [JsonReturn]
        ITask<Response<OrganizationCreateResponseModel>> CreateOrganization(
            [PathQuery]string appToken,
            [JsonContent]OrganizationInfoModel requestModel,
            [Timeout]double timeout = 10000,
            CancellationToken cancellationToken = default(CancellationToken));

        [HttpGet("app/getOrgAccessToken")]
        [JsonReturn]
        ITask<Response<OrganizationAccessTokenGetResponseModel>> GetOrganizationAccessToken(
              [PathQuery]string appToken,
        [JsonContent]OrganizationAccessTokenGetRequestModel requestModel,
        [Timeout]double timeout = 10000,
        CancellationToken cancellationToken = default(CancellationToken));


        [HttpGet("org/update")]
        [JsonReturn]
        ITask<ResponseOfStruct<bool>> UpdateOrganization(
            [PathQuery]string accessToken,
            [JsonContent]OrganizationInfoModel requestModel,
            [Timeout]double timeout = 10000,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}