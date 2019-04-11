using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Response.Member
{
    public class MemberCreateResponseModel:IBusinessResponseModel
    {
        /// <summary>
        /// 相似人员魔点ID
        /// </summary>
        public string SimilarMemberID { get; set; }

    }
}
