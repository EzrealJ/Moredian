using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Response.Device
{
    public class DeviceActivationResponseModel : IBusinessResponseModel
    {


        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string SN { get; set; }


    }
}
