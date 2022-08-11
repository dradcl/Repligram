using Newtonsoft.Json;
using System.Collections.Generic;

namespace Repligram.IGObjects
{
    public class IGLoginInfoResponse
    {
        [JsonProperty("logged_in_user")]
        public IGLoginInfo User { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IGLoginInfo
    {
        // Some sort of identifier, will be needed later
        [JsonProperty("pk")]
        public long Pk { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("profile_pic_url")]
        public string ProfilePicUrl { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("has_anonymous_profile_picture")]
        public bool HasAnonymousProfilePicture { get; set; }

        [JsonProperty("can_boost_post")]
        public bool CanBoostPost { get; set; }

        [JsonProperty("is_business")]
        public bool IsBusiness { get; set; }

        [JsonProperty("account_type")]
        public int AccountType { get; set; }

        [JsonProperty("professional_conversion_suggested_account_type")]
        public int ProfessionalConversionSuggestedAccountType { get; set; }

        [JsonProperty("is_call_to_action_enabled")]
        public object IsCallToActionEnabled { get; set; }

        [JsonProperty("can_see_organic_insights")]
        public bool CanSeeOrganicInsights { get; set; }

        [JsonProperty("show_insights_terms")]
        public bool ShowInsightsTerms { get; set; }

        [JsonProperty("total_igtv_videos")]
        public int TotalIgtvVideos { get; set; }

        [JsonProperty("reel_auto_archive")]
        public string ReelAutoArchive { get; set; }

        [JsonProperty("has_placed_orders")]
        public bool HasPlacedOrders { get; set; }

        [JsonProperty("allowed_commenter_type")]
        public string AllowedCommenterType { get; set; }

        [JsonProperty("nametag")]
        public IGNametag Nametag { get; set; }

        [JsonProperty("is_using_unified_inbox_for_direct")]
        public bool IsUsingUnifiedInboxForDirect { get; set; }

        [JsonProperty("interop_messaging_user_fbid")]
        public long InteropMessagingUserFbid { get; set; }

        [JsonProperty("can_see_primary_country_in_settings")]
        public bool CanSeePrimaryCountryInSettings { get; set; }

        [JsonProperty("account_badges")]
        public List<object> AccountBadges { get; set; }

        [JsonProperty("fbid_v2")]
        public long FbidV2 { get; set; }

        [JsonProperty("allow_contacts_sync")]
        public bool AllowContactsSync { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class IGCountryCode
    {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("source")]
        public List<string> Source { get; set; }
    }

    public class IGLoginRequest
    {
        [JsonProperty("jazoest")]
        public string Jazoest { get; set; }

        [JsonProperty("country_codes")]
        public IGCountryCode CountryCodes { get; set; }

        [JsonProperty("phone_id")]
        public string PhoneId { get; set; }

        [JsonProperty("enc_password")]
        public string EncPassword { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("adid")]
        public string Adid { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("google_tokens")]
        public List<string> GoogleTokens { get; set; }

        [JsonProperty("login_attempt_count")]
        public string LoginAttemptCount { get; set; }
    }
}