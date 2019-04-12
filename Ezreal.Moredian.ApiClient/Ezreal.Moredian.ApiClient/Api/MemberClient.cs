using Ezreal.Moredian.ApiClient.ApiContract;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Member;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using System;
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

        public ITask<ResponseOfStruct<ulong>> Create(string accessToken, MemberBaseInfoModel requestModel, MulitpartFile verifyFace = null, MulitpartFile showFace = null, TimeSpan? timeout = null,CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.Create(accessToken, requestModel, verifyFace, showFace, cancellationToken: cancellationToken);
        }

        public ITask<ResponseOfStruct<ulong>> Update(string accessToken, MemberBaseInfoModel requestModel, MulitpartFile verifyFace = null, MulitpartFile showFace = null, TimeSpan? timeout = null,CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.Update(accessToken, requestModel, verifyFace, showFace, cancellationToken: cancellationToken);
        }

        public ITask<ResponseOfStruct<bool>> Delete(string accessToken, MemberDeleteRequestModel requestModel, TimeSpan? timeout = null,CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.Delete(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> UpdateShowImg(string accessToken, MemberUpdateShowImgRequestModel requestModel, MulitpartFile showFace = null, TimeSpan? timeout = null,CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.UpdateShowImg(accessToken, requestModel, showFace, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> UpdateVerifyImg(string accessToken, MemberUpdateVerifyImgRequestModel requestModel, MulitpartFile verifyFace = null, TimeSpan? timeout = null,CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.UpdateVerifyImg(accessToken, requestModel, verifyFace, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> BindGroup(string accessToken, MemberBindGroupRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.BindGroup(accessToken, requestModel, cancellationToken: cancellationToken);
        }

        public ITask<ResponseModel> UnbindGroup(string accessToken, MemberUnBindGroupRequestModel requestModel, TimeSpan? timeout = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MemberContract.UnbindGroup(accessToken, requestModel, cancellationToken: cancellationToken);
        }
    }
}