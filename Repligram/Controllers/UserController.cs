using Repligram.IGObjects;
using System.Collections.Generic;
using System.Web.Http;

namespace Repligram.Controllers
{
    public class UserController : ApiController
    {
        public static string fullName = "";
        public static string profilePicURL = "https://www.jing.fm/clipimg/detail/27-273902_instagram-cool-instagram-logo-png.png";
        public static string bio = "A back-end recreation of Instagram by Karma Kitten";
        public static int followers = 2147483647;
        public static int posts = 1;
        public static int following = 0;
        public static bool verified = true;

        [HttpGet]
        [Route("api/v1/users/{pk}/info")]
        public IGUserResponse GetUserInfo(long pk)
        {
            return new IGUserResponse
            {
                User = new IGUser
                {
                    Pk = pk,
                    Username = LoginController.currentUsername,
                    FullName = "",
                    IsPrivate = false,
                    ProfilePicUrl = profilePicURL,
                    IsVerified = verified,
                    HasAnonymousProfilePicture = true,
                    MediaCount = posts,
                    GeoMediaCount = 0,
                    FollowerCount = followers,
                    FollowingCount = following,
                    FollowingTagCount = 0,
                    Biography = bio,
                    CanLinkEntitiesInBio = true,
                    BiographyWithEntities = new IGBiography
                    {
                        RawText = bio,
                        Entities = new List<object> { }
                    },
                    BiographyProductMentions = new List<object> { },
                    ExternalUrl = "https://www.karmaisbased.ml/repligram",
                    CanBoostPost = false,
                    CanSeeOrganicInsights = false,
                    ShowInsightsTerms = false,
                    CanConvertToBusiness = true,
                    CanCreateSponsorTags = false,
                    IsAllowedToCreateStandaloneNonprofitFundraisers = false,
                    IsAllowedToCreateStandalonePersonalFundraisers = false,
                    CanCreateNewStandaloneFundraiser = true,
                    CanCreateNewStandalonePersonalFundraiser = true,
                    CanBeTaggedAsSponsor = false,
                    CanSeeSupportInbox = false,
                    TotalIgtvVideos = 0,
                    TotalVideoCount = 0,
                    HasSavedItems = false,
                    TotalArEffects = 0,
                    ReelAutoArchive = "unset",
                    IsProfileActionNeeded = false,
                    UsertagsCount = 0,
                    UsertagReviewEnabled = false,
                    IsNeedy = true,
                    IsInterestAccount = false,
                    HasChaining = false,
                    HdProfilePicVersions = new List<IGProfilePicVersion>
                    {
                        new IGProfilePicVersion
                        {
                            Width = 320,
                            Height = 320,
                            Url = ""
                        },
                        new IGProfilePicVersion
                        {
                            Width = 640,
                            Height = 640,
                            Url = ""
                        }
                    },
                    HdProfilePicUrlInfo = new IGProfilePicUrlInfo
                    {
                        Url = "",
                        Width = 150,
                        Height = 150
                    },
                    HasPlacedOrders = false,
                    CanTagProductsFromMerchants = false,
                    FbpayExperienceEnabled = false,
                    ShowConversionEditEntry = true,
                    AggregatePromoteEngagement = true,
                    AllowedCommenterType = "any",
                    IsVideoCreator = false,
                    HasProfileVideoFeed = false,
                    HasHighlightReels = false,
                    HasGuides = false,
                    IsEligibleToShowFbCrossSharingNux = false,
                    PageIdForNewSumaBizAccount = null,
                    EligibleShoppingSignupEntrypoints = new List<object> { },
                    ServiceShopOnboardingStatus = null,
                    ServiceShopMerchantEntrypointAppId = "com.bloks.www.service.merchant.entrypoint",
                    CanBeReportedAsFraud = false,
                    IsBusiness = false,
                    AccountType = 1,
                    ProfessionalConversionSuggestedAccountType = 2,
                    IsCallToActionEnabled = null,
                    InteropMessagingUserFbid = 0,
                    LinkedFbInfo = new LinkedFbInfo { },
                    StandaloneFundraiserInfo = new IGFundraiserInfo
                    {
                        HasActiveFundraiser = false,
                        FundraiserId = null,
                        FundraiserTitle = null,
                        FundraiserType = null,
                        FormattedGoalAmount = null,
                        BeneficiaryUsername = null,
                        FormattedFundraiserProgressInfoText = null,
                        PercentRaised = null
                    },
                    AllowMentionSetting = "everyone",
                    AllowTagSetting = "everyone",
                    CanSeePrimaryCountryInSettings = false,
                    PersonalAccountAdsPageName = "",
                    PersonalAccountAdsPageId = "",
                    AccountBadges = new List<object> { },
                    WhatsappNumber = "",
                    HasEligibleWhatsappLinkingCategory = null,
                    FbidV2 = 0,
                    IsEligibleForAppointmentCreationInDirectThread = false,
                    IncludeDirectBlacklistStatus = true,
                    CanFollowHashtag = true,
                    IsPotentialBusiness = false,
                    ShowPostInsightsEntryPoint = true,
                    FeedPostReshareDisabled = false,
                    BestiesCount = 0,
                    ShowBestiesBadge = false,
                    RecentlyBestiedByCount = 0,
                    Nametag = new IGNametag
                    {
                        Mode = 0,
                        Gradient = 2,
                        Emoji = "😀",
                        SelfieSticker = 0
                    },
                    ExistingUserAgeCollectionEnabled = false,
                    AboutYourAccountBloksEntrypointEnabled = false,
                    AutoExpandChaining = false,
                    HighlightReshareDisabled = false,
                    IsMemorialized = false,
                    OpenExternalUrlWithInAppBrowser = true,
                },
                Status = "ok"
            };
        }
    }
}