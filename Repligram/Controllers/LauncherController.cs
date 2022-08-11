using Repligram.IGObjects;
using System.Web.Http;

namespace Repligram.Controllers
{
    public class LauncherController : ApiController
    {
        // TODO: add config implementation if bored, kek
        [HttpPost]
        [Route("api/v1/launcher/sync/")]
        public IGConfigResponse Post()
        {
            return new IGConfigResponse
            {
                Configs = new IGConfig
                {
                    Killswitch = new IGConfigKillswitch
                    {
                        Params = new IGEnableResponse
                        {
                            IsEnabled = new IGEnable
                            {
                                Value = true
                            }
                        }
                    }
                },
                Status = "ok"
            };
        }
    }
}