using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Organization
{
   public class OrganizationAccessTokenGetRequestModel
    {

        [ApiParameterName("orgId")]
        public string OrganizationId { get; set; }
        [ApiParameterName("orgAuthKey")]
        public string OrganizationAuthKey { get; set; }
    }
}
