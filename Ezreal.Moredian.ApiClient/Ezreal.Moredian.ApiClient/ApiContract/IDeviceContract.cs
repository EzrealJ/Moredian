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
    public interface IDeviceContract : IHttpApi
    {
        [HttpPost("device/activation")]
        [JsonReturn]
        ITask<Response<DeviceActivationResponseModel>> Activation(
        [PathQuery]string accessToken,
        [JsonContent]DeviceActivationRequestModel requestModel,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));


        [HttpGet("device/deviceId")]
        [JsonReturn]
        ITask<ResponseOfString> GetDeviceId(
        [PathQuery]string accessToken,
        [PathQuery]string deviceSn,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("device/updateControlInfo")]
        [JsonReturn]
        ITask<ResponseModel> UpdateControlInfo(
        [PathQuery]string accessToken,
        [JsonContent]DeviceControlInfoUpdateRequestModel requestModel,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("device/unbind")]
        [JsonReturn]
        ITask<ResponseModel> Unbind(
        [PathQuery]string accessToken,
        [JsonContent]DeviceUnbindRequestModel requestModel,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpGet("device/getDynamicPwd")]
        [JsonReturn]
        ITask<ResponseModel> GetDynamicPassword(
        [PathQuery]string accessToken,
        [JsonContent]DeviceDynamicPasswordGetRequestModel requestModel,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));


        [HttpPost("device/group/binding")]
        [JsonReturn]
        ITask<ResponseModel> BindGroup(
        [PathQuery]string accessToken,
        [JsonContent]DeviceBindGroupRequestModel requestModel,
        [Timeout]TimeSpan? timeout,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("device/group/configuration")]
        [JsonReturn]
        ITask<ResponseModel> UnbindGroup(
        [PathQuery]string accessToken,
        [JsonContent]DeviceConfigGroupRequestModel requestModel,
        [Timeout]TimeSpan? timeout,
        CancellationToken cancellationToken = default(CancellationToken));
    }
}
