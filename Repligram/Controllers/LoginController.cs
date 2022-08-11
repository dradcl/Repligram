using Newtonsoft.Json;
using Repligram.IGObjects;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Repligram.Controllers
{
    public class LoginController : ApiController
    {
        public static string currentUsername = "placeholder";

        [HttpGet]
        [Route("api/v1/zr/token/result/")]
        public IGTokenResponse GetTokenResult()
        {
            return new IGTokenResponse
            {
                Token = new IGToken
                {
                    CarrierName = "",
                    CarrierId = 0,
                    TTL = 7200,
                    Features = new List<string> { },
                    RequestTime = 1617583190,
                    TokenHash = "",
                    RewriteRules = new List<string> { },
                    EnabledWalletDefsKeys = new List<string> { },
                    Deadline = "",
                    ZeroCmsFetchIntervalSeconds = 86400,
                    CarrierSignalConfig = new List<string> { }
                },
                Status = "ok"
            };
        }

        [HttpPost]
        [Route("api/v1/accounts/login/")]
        public async Task<IGLoginInfoResponse> PostLogin()
        {
            string reqBody = await Request.Content.ReadAsStringAsync();
            IGLoginRequest r = JsonConvert.DeserializeObject<IGLoginRequest>(FormatRequestBody(reqBody));

            currentUsername = r.Username;

            return new IGLoginInfoResponse
            {
                User = new IGLoginInfo
                {
                    Pk = 0,
                    Username = r.Username,
                    FullName = UserController.fullName,
                    IsPrivate = false,
                    ProfilePicUrl = UserController.profilePicURL,
                    IsVerified = UserController.verified,
                    HasAnonymousProfilePicture = true,
                    CanBoostPost = false,
                    IsBusiness = false,
                    AccountType = 1,
                    ProfessionalConversionSuggestedAccountType = 2,
                    IsCallToActionEnabled = null,
                    CanSeeOrganicInsights = false,
                    ShowInsightsTerms = false,
                    TotalIgtvVideos = 0,
                    ReelAutoArchive = "unset",
                    HasPlacedOrders = false,
                    AllowedCommenterType = "any",
                    Nametag = new IGNametag
                    {
                        Mode = 0,
                        Gradient = 2,
                        Emoji = "😀",
                        SelfieSticker = 0
                    },
                    IsUsingUnifiedInboxForDirect = false,
                    InteropMessagingUserFbid = 0,
                    CanSeePrimaryCountryInSettings = false,
                    AccountBadges = new List<object> { },
                    FbidV2 = 0,
                    AllowContactsSync = false,
                    PhoneNumber = ""
                },
                Status = "ok"
            };
        }

        private string FormatRequestBody(string requestBody)
        {
            requestBody = HttpUtility.UrlDecode(requestBody).Remove(0, 22);
            requestBody = requestBody.Replace("\\", "");
            requestBody = requestBody.Replace(@"""[", "");
            requestBody = requestBody.Replace(@"]""", "");
            requestBody = requestBody.Replace(@":,", ":[],");
            return requestBody;
        }
    }
}