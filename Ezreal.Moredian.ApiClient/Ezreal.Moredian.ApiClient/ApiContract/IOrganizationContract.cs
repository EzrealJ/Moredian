using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.App;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Organization;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Attributes;

namespace Ezreal.Moredian.ApiClient.ApiContract
{
    public interface IOrganizationContract : IHttpApi
    {
        [HttpPost("app/createOrg")]
        [JsonReturn]
        ITask<Response<OrganizationCreateResponseModel>> CreateOrganization(
        [PathQuery]string appToken,
        [JsonContent]OrganizationBaseInfoModel requestModel,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpGet("app/getOrgAccessToken")]
        [JsonReturn]
        ITask<Response<OrganizationAccessTokenGetResponseModel>> GetOrganizationAccessToken(
        [PathQuery]string appToken,
        [PathQuery]OrganizationAccessTokenGetRequestModel requestModel,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));


        [HttpPost("org/update")]
        [JsonReturn]
        ITask<ResponseOfStruct<bool>> UpdateOrganization(
            [PathQuery]string accessToken,
            [JsonContent]OrganizationBaseInfoModel requestModel,
            [Timeout]TimeSpan? timeout = null,
            CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("callback/addOrgCallback")]
        [JsonReturn]
        ITask<ResponseModel> RegisterOrganizationCallback(
        [PathQuery]string accessToken,
        [JsonContent]OrganizationCallBackRegisterRequestModel requestModel,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("callback/updateOrgCallback")]
        [JsonReturn]
        ITask<ResponseModel> UpdateOrganizationCallBack(
        [PathQuery]string accessToken,
        [JsonContent]OrganizationCallBackUpdateRequestModel requestModel,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));
    }
}
