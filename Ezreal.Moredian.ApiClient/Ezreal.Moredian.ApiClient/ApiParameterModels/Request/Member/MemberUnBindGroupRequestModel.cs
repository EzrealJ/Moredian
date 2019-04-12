using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Member
{
    public class MemberUnBindGroupRequestModel
    {

        public ulong MemberId { get; set; }
        public ulong GroupId { get; set; }

    }
}
