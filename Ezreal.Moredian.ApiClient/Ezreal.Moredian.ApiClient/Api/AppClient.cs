using Ezreal.Moredian.ApiClient.ApiContract;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.App;
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
    public class AppClient
    {
        public AppClient(IAppContract appContract)
        {
            AppContract = appContract ?? HttpApi.Resolve<IAppContract>();
        }

        public IAppContract AppContract { get; }

        public ITask<Response<AppTokenGetResponseModel>> GetAppToken(AppTokenGetRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            timeout = timeout ?? TimeSpan.FromMilliseconds(10 * 1000);
            return AppContract.GetAppToken(requestModel, timeout.Value.TotalMilliseconds, cancellationToken);
        }
    }
}
