using Ezreal.Moredian.ApiClient.ApiParameterModels.Generic;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Member;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Attributes;
using WebApiClient.Parameterables;

namespace Ezreal.Moredian.ApiClient.ApiContract
{
    public interface IMemberContract : IHttpApi
    {



        [HttpPost("member/create")]
        [JsonReturn]
        ITask<ResponseOfStruct<ulong>> Create(
        [PathQuery]string accessToken,
        [MulitpartContent]MemberBaseInfoModel requestModel,
        MulitpartFile verifyFace = null,
        MulitpartFile showFace = null,
        [Timeout]TimeSpan? timeout=null,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("member/update")]
        [JsonReturn]
        ITask<ResponseOfStruct<ulong>> Update(
        [PathQuery]string accessToken,
        [MulitpartContent]MemberBaseInfoModel requestModel,
        MulitpartFile verifyFace = null,
        MulitpartFile showFace = null,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("member/delete")]
        [JsonReturn]
        ITask<ResponseOfStruct<bool>> Delete(
        [PathQuery]string accessToken,
        [JsonContent]MemberDeleteRequestModel requestModel,
        [Timeout]TimeSpan? timeout,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("member/updateShowImg")]
        [JsonReturn]
        ITask<ResponseModel> UpdateShowImg(
        [PathQuery]string accessToken,
        [MulitpartContent]MemberUpdateShowImgRequestModel requestModel,
        MulitpartFile showFace = null,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));


        [HttpPost("member/updateVerifyImg")]
        [JsonReturn]
        ITask<ResponseModel> UpdateVerifyImg(
        [PathQuery]string accessToken,
        [MulitpartContent]MemberUpdateVerifyImgRequestModel requestModel,
        MulitpartFile verifyFace = null,
        [Timeout]TimeSpan? timeout = null,
        CancellationToken cancellationToken = default(CancellationToken));


        [HttpPost("member/bindGroup")]
        [JsonReturn]
        ITask<ResponseModel> BindGroup(
        [PathQuery]string accessToken,
        [JsonContent]MemberBindGroupRequestModel requestModel,
        [Timeout]TimeSpan? timeout,
        CancellationToken cancellationToken = default(CancellationToken));

        [HttpPost("member/unbindGroup")]
        [JsonReturn]
        ITask<ResponseModel> UnbindGroup(
        [PathQuery]string accessToken,
        [JsonContent]MemberUnBindGroupRequestModel requestModel,
        [Timeout]TimeSpan? timeout,
        CancellationToken cancellationToken = default(CancellationToken));
    }
}
