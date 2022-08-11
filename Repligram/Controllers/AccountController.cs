using Repligram.IGObjects;
using System.Collections.Generic;
using System.Web.Http;

namespace Repligram.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("api/v1/accounts/get_prefill_candidates/")]
        public IGPrefillCandidateResponse PostPrefillCandidates()
        {
            return new IGPrefillCandidateResponse
            {
                Prefills = new List<IGPrefill>
                {
                    new IGPrefill
                    {
                        Usage = "account_recovery_omnibox",
                        Candidates = new List<IGPrefillCandidate> // can add more prefill candidates if wanted here
                        {
                            new IGPrefillCandidate
                            {
                                Type = "email",
                                Value = "karmawashere@repligram.com",
                                Source = "android_account_manager"
                            }
                        }
                    }
                },
                Status = "ok"
            };
        }

        [HttpPost]
        [Route("api/v1/accounts/contact_point_prefill/")]
        public IGStatus PostContactPrefill()
        {
            return new IGStatus
            {
                Status = "ok"
            };
        }

        [HttpGet]
        [Route("api/v1/multiple_accounts/get_account_family/")]
        public IGAccountFamily GetAccountFamily()
        {
            return new IGAccountFamily
            {
                ChildAccounts = new List<IGUserConcise> { },
                MainAccounts = new List<IGUserConcise> { },
                CurrentAccount = new IGUserConcise
                {
                    Pk = 0,
                    Username = LoginController.currentUsername,
                    FullName = UserController.fullName,
                    IsPrivate = false,
                    ProfilePicUrl = UserController.profilePicURL,
                    IsVerified = UserController.verified,
                    HasPassword = 1
                },
                Status = "ok"
            };
        }
    }
}