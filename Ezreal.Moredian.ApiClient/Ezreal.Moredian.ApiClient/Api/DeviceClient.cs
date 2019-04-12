using Ezreal.Moredian.ApiClient.ApiContract;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Device;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.Device;
using System;
using System.Threading;
using WebApiClient;

namespace Ezreal.Moredian.ApiClient.Api
{
    public class DeviceClient
    {
        public DeviceClient(IDeviceContract deviceContract)
        {
            DeviceContract = deviceContract ?? HttpApi.Resolve<IDeviceContract>();
        }

        public IDeviceContract DeviceContract { get; }

        public ITask<Response<DeviceActivationResponseModel>> Activation(string accessToken, DeviceActivationRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.Activation(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseOfString> GetDeviceId(string accessToken, string deviceSn, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.GetDeviceId(accessToken, deviceSn, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> UpdateControlInfo(string accessToken, DeviceControlInfoUpdateRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.UpdateControlInfo(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> Unbind(string accessToken, DeviceUnbindRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.Unbind(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> GetDynamicPassword(string accessToken, DeviceDynamicPasswordGetRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.GetDynamicPassword(accessToken, requestModel, cancellationToken: cancellationToken);
        }


        public ITask<ResponseModel> BindGroup(string accessToken, DeviceBindGroupRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.BindGroup(accessToken, requestModel, cancellationToken: cancellationToken);
        }
        public ITask<ResponseModel> UnbindGroup(string accessToken, DeviceConfigGroupRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.UnbindGroup(accessToken, requestModel, cancellationToken: cancellationToken);
        }
    }
}