using Ezreal.Moredian.ApiClient.ApiContract;
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

namespace Ezreal.Moredian.ApiClient.Api
{
    public class OrganizationClient
    {
        public OrganizationClient(IOrganizationContract organizationContract)
        {
            OrganizationContract = organizationContract ?? HttpApi.Resolve<IOrganizationContract>();
        }

        public IOrganizationContract OrganizationContract { get; }

        public ITask<Response<OrganizationCreateResponseModel>> CreateOrganization(string appToken, OrganizationBaseInfoModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return OrganizationContract.CreateOrganization(appToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<Response<OrganizationAccessTokenGetResponseModel>> GetOrganizationAccessToken(string appToken, OrganizationAccessTokenGetRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return OrganizationContract.GetOrganizationAccessToken(appToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseOfStruct<bool>> UpdateOrganization(string accessToken, OrganizationBaseInfoModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return OrganizationContract.UpdateOrganization(accessToken, requestModel, cancellationToken: cancellationToken);
        }
    }
}
