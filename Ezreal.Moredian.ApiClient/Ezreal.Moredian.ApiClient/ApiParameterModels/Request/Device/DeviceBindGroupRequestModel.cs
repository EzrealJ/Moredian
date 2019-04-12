using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Device
{
    public class DeviceBindGroupRequestModel
    {
        public ulong DeviceId { get; set; }
        public List<ulong> GroupIdList { get; set; }
    }
}
