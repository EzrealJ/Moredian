using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Generic
{
    public class GroupBaseInfoModel
    {
        /// <summary>
        /// 第三方企业内部的群组id
        /// </summary>
        public string TpGroupId { get; set; }
        /// <summary>
        /// 魔点内部的群组id
        /// </summary>
        public ulong GroupId { get; set; }
        /// <summary>
        /// 群组名称
        /// </summary>
        public string GroupName { get; set; }
    }
}
