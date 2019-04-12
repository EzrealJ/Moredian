using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Device
{
 public   class DeviceConfigGroupRequestModel
    {
        public string DayBeginTime { get; set; }
        public string DayEndTime { get; set; }
        public int[] Weekdays { get; set; }
        public ulong GroupId { get; set; }
    }
}
