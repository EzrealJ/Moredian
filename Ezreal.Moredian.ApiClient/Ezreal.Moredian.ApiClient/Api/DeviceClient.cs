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

        public ITask<Response<ActivationResponseModel>> Activation(string accessToken, ActivationRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.Activation(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseOfString> GetDeviceID(string accessToken, string deviceSn, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.GetDeviceID(accessToken, deviceSn, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> UpdateControlInfo(string accessToken, ControlInfoUpdateRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.UpdateControlInfo(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> Unbind(string accessToken, UnbindRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.Unbind(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> GetDynamicPassword(string accessToken, DynamicPasswordGetRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeviceContract.GetDynamicPassword(accessToken, requestModel, cancellationToken: cancellationToken);
        }
    }
}