using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
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
    public interface IGroupContract : IHttpApi
    {
        [HttpPost("group/create")]
        [JsonReturn]
        ITask<ResponseOfStruct<ulong>> CreateGroup(
        [PathQuery]string accessToken,
        [JsonContent]GroupBaseInfoModel requestModel,
        [Timeout]double timeout = 10000,
        CancellationToken cancellationToken = default(CancellationToken));


        [HttpPost("group/update")]
        [JsonReturn]
        ITask<ResponseOfStruct<ulong>> UpdateGroup(
        [PathQuery]string accessToken,
        [JsonContent]GroupBaseInfoModel requestModel,
        [Timeout]double timeout = 10000,
        CancellationToken cancellationToken = default(CancellationToken));
    }
}
