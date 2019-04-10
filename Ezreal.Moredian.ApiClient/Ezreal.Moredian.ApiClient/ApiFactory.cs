using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient
{
    public class ApiFactory
    {
        public static Api.AppClient CreateAppClient() => new Api.AppClient(null);
    }
}
