namespace RingCentral
{
    public partial class CreateSubscriptionRequest
    {
        // Collection of URIs to API resources. For APNS transport type only message event filter is available
        public string[] @eventFilters { get; set; }
        // Notification delivery settings
        public NotificationDeliveryModeRequest @deliveryMode { get; set; }
        // Subscription lifetime in seconds. Max value is 7 days (604800 sec). For *WebHook* transport type max value might be set up to 630720000 seconds (20 years)
        public long? @expiresIn { get; set; }
    }
}
