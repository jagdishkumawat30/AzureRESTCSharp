namespace ConsoleApp1
{
    public static class AzureDetails
    {
        public static string ClientID = "<Client ID or App ID>";
        public static string ClientSecret = "<Client Secret or Password>";
        public static string TenantID = "<Tenant ID>";
        public static string SubscriptionID = "<Subscription ID>";
        public static string Response { get; set; }
        public static string Location = "eastus";
        public static string ResourceGroupName = "jdBotsRG";

        public static string AccessToken { get; internal set; }
        
    }
}