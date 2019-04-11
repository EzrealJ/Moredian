using Ezreal.Moredian.ApiClient.ApiContract;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.App;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App;
using System;
using System.Threading;
using WebApiClient;

namespace Ezreal.Moredian.ApiClient.Api
{
    public class AppClient
    {
        public AppClient(IAppContract appContract)
        {
            AppContract = appContract ?? HttpApi.Resolve<IAppContract>();
        }

        public IAppContract AppContract { get; }

        public ITask<Response<AppTokenGetResponseModel>> GetAppToken(AppTokenGetRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AppContract.GetAppToken(requestModel, cancellationToken: cancellationToken);
        }

        public ITask<Response<OrganizationCreateResponseModel>> CreateOrganization(string appToken, OrganizationInfoModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AppContract.CreateOrganization(appToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<Response<OrganizationAccessTokenGetResponseModel>> GetOrganizationAccessToken(string appToken, OrganizationAccessTokenGetRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AppContract.GetOrganizationAccessToken(appToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseOfStruct<bool>> UpdateOrganization(string accessToken, OrganizationInfoModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return AppContract.UpdateOrganization(accessToken, requestModel, cancellationToken: cancellationToken);
        }
    }
}