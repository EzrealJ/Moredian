using Ezreal.Moredian.ApiClient.ApiContract;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Member;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.Member;
using System.Threading;
using WebApiClient;
using WebApiClient.Parameterables;

namespace Ezreal.Moredian.ApiClient.Api
{
    public class MemberClient
    {
        public MemberClient(IMemberContract memberContract)
        {
            MemberContract = memberContract ?? HttpApi.Resolve<IMemberContract>();
        }

        public IMemberContract MemberContract { get; }

        public ITask<ResponseOfString> Create(string accessToken, MemberBaseInfo requestModel, MulitpartFile verifyFace = null, MulitpartFile showFace = null, double timeout = 30 * 1000, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.Create(accessToken, requestModel, verifyFace, showFace, cancellationToken: cancellationToken);
        }

        public ITask<ResponseOfString> Update(string accessToken, MemberBaseInfo requestModel, MulitpartFile verifyFace = null, MulitpartFile showFace = null, double timeout = 30 * 1000, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.Update(accessToken, requestModel, verifyFace, showFace, cancellationToken: cancellationToken);
        }

        public ITask<ResponseOfStruct<bool>> Delete(string accessToken, MemberDeleteRequestModel requestModel, double timeout = 10 * 1000, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.Delete(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> UpdateShowImg(string accessToken, MemberUpdateShowImgRequestModel requestModel, MulitpartFile showFace = null, double timeout = 30 * 1000, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.UpdateShowImg(accessToken, requestModel, showFace, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> UpdateVerifyImg(string accessToken, MemberUpdateVerifyImgRequestModel requestModel, MulitpartFile verifyFace = null, double timeout = 30 * 1000, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.UpdateVerifyImg(accessToken, requestModel, verifyFace, cancellationToken: cancellationToken);
        }
    }
}