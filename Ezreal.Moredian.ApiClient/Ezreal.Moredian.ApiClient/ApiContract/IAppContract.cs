﻿using Ezreal.Moredian.ApiClient.ApiParameterModels.Request.App;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response;
using Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebApiClient;
using WebApiClient.Attributes;

namespace Ezreal.Moredian.ApiClient.ApiContract
{
    public interface IAppContract : IHttpApi
    {

        [HttpGet("app/getAppToken")]
        [JsonReturn]
        ITask<Response<AppTokenGetResponseModel>> GetAppToken(
            [PathQuery]AppTokenGetRequestModel requestModel,
            [Timeout]double timeout = 10000,
            CancellationToken cancellationToken = default(CancellationToken));

        [HttpGet("app/createOrg")]
        [JsonReturn]
        ITask<ResponseOfStruct<bool>> CreateOrganization(
    [PathQuery]OrganizationCreateRequestModel requestModel,
    [Timeout]double timeout = 10000,
    CancellationToken cancellationToken = default(CancellationToken));
    }
}
