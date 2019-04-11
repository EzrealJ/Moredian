using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Member
{
   public class MemberDeleteRequestModel
    {
        /// <summary>
        /// *魔点内部的人员id
        /// </summary>
        [ApiParameterName("memberId")]
        public long MemberID { get; set; }
    }
}
