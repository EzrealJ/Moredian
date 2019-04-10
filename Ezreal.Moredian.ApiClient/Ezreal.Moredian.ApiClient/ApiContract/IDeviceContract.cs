using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Device;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.Device;
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
    interface IDeviceContract:IHttpApi
    {
        [HttpGet("device/activation")]
        [JsonReturn]
        ITask<Response<ActivationResponseModel>> Activation(
    [PathQuery]string accessToken,
    [JsonContent]ActivationRequestModel requestModel,
    [Timeout]double timeout = 10000,
    CancellationToken cancellationToken = default(CancellationToken));


        [HttpGet("device/deviceId")]
        [JsonReturn]
        ITask<ResponseOfString> GetDeviceID(
[PathQuery]string accessToken,
[PathQuery]string deviceSn,
[Timeout]double timeout = 10000,
CancellationToken cancellationToken = default(CancellationToken));

        [HttpGet("device/updateControlInfo")]
        [JsonReturn]
        ITask<ResponseModel> UpdateControlInfo(
[PathQuery]string accessToken,
[JsonContent]ControlInfoUpdateRequestModel requestModel,
[Timeout]double timeout = 10000,
CancellationToken cancellationToken = default(CancellationToken));

        [HttpGet("device/unbind")]
        [JsonReturn]
        ITask<ResponseModel> Unbind(
[PathQuery]string accessToken,
[JsonContent]UnbindRequestModel requestModel,
[Timeout]double timeout = 10000,
CancellationToken cancellationToken = default(CancellationToken));

        [HttpGet("device/getDynamicPwd")]
        [JsonReturn]
        ITask<ResponseModel> GetDynamicPassword(
[PathQuery]string accessToken,
[JsonContent]DynamicPasswordGetRequestModel requestModel,
[Timeout]double timeout = 10000,
CancellationToken cancellationToken = default(CancellationToken));
    }
}
