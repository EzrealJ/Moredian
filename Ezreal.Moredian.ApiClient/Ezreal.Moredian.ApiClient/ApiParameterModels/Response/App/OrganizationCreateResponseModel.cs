using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Response.App
{
    public class OrganizationCreateResponseModel:IBusinessResponseModel
    {

        [ApiParameterName("orgId")]
        public string OrganizationID { get; set; }
        [ApiParameterName("orgAuthKey")]
        public string OrganizationAuthKey { get; set; }


    }
}
