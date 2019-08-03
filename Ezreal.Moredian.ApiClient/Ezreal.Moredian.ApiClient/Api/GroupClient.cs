using Ezreal.Moredian.ApiClient.ApiContract;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApiClient;

namespace Ezreal.Moredian.ApiClient.Api
{
    public class GroupClient
    {
        public GroupClient(IGroupContract groupContract)
        {
            GroupContract = groupContract ?? HttpApi.Resolve<IGroupContract>();
        }

        public IGroupContract GroupContract { get; }



        public ITask<ResponseOfStruct<ulong>> CreateGroup(string accessToken, GroupBaseInfoModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GroupContract.CreateGroup(accessToken, requestModel);
        }


        public ITask<ResponseOfStruct<ulong>> UpdateGroup(string accessToken, GroupBaseInfoModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GroupContract.UpdateGroup(accessToken, requestModel);
        }
    }
}
