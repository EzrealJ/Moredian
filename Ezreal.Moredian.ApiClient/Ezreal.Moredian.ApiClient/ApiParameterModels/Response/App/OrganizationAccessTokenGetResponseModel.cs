using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App
{
    public class OrganizationAccessTokenGetResponseModel : IBusinessResponseModel
    {
        /// <summary>
        /// 这里获取的是accessToken，在后面的接口中会频繁调用，注意区别appToken的使用。
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 获取accessToken 的有效时间，单位为秒，以接口返回时间为准，当出现accessToken过期提示时，需要重新调用本接口获取。
        /// </summary>
        public int Expires { get; set; }
    }
}
