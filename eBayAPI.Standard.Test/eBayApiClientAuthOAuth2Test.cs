using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class eBayApiClientAuthOAuth2Test
    {
        public eBayApiClientAuthOAuth2Test()
        {
            OAuth2Initialize.Initialize();
        }
        [TestMethod]
        public void CredentialUtilTest()
        {
            var Production_AppId = eBay.ApiClient.Auth.OAuth2.CredentialUtil.GetCredentials(eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.PRODUCTION)?.Get(eBay.ApiClient.Auth.OAuth2.Model.CredentialType.APP_ID);
            var Production_CertId = eBay.ApiClient.Auth.OAuth2.CredentialUtil.GetCredentials(eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.PRODUCTION)?.Get(eBay.ApiClient.Auth.OAuth2.Model.CredentialType.CERT_ID);
            var Production_DevId = eBay.ApiClient.Auth.OAuth2.CredentialUtil.GetCredentials(eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.PRODUCTION)?.Get(eBay.ApiClient.Auth.OAuth2.Model.CredentialType.DEV_ID);
            var Production_RedirectUrl = eBay.ApiClient.Auth.OAuth2.CredentialUtil.GetCredentials(eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.PRODUCTION)?.Get(eBay.ApiClient.Auth.OAuth2.Model.CredentialType.REDIRECT_URI);

            var Sandbox_AppId = eBay.ApiClient.Auth.OAuth2.CredentialUtil.GetCredentials(eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.SANDBOX)?.Get(eBay.ApiClient.Auth.OAuth2.Model.CredentialType.APP_ID);
            var Sandbox_CertId = eBay.ApiClient.Auth.OAuth2.CredentialUtil.GetCredentials(eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.SANDBOX)?.Get(eBay.ApiClient.Auth.OAuth2.Model.CredentialType.CERT_ID);
            var Sandbox_DevId = eBay.ApiClient.Auth.OAuth2.CredentialUtil.GetCredentials(eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.SANDBOX)?.Get(eBay.ApiClient.Auth.OAuth2.Model.CredentialType.DEV_ID);
            var Sandbox_RedirectUrl = eBay.ApiClient.Auth.OAuth2.CredentialUtil.GetCredentials(eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.SANDBOX)?.Get(eBay.ApiClient.Auth.OAuth2.Model.CredentialType.REDIRECT_URI);

            Assert.IsNotNull(Production_AppId);
            Assert.IsNotNull(Production_CertId);
            Assert.IsNotNull(Production_DevId);
            Assert.IsNotNull(Production_RedirectUrl);
            Assert.IsNotNull(Sandbox_AppId);
            Assert.IsNotNull(Sandbox_CertId);
            Assert.IsNotNull(Sandbox_DevId);
            Assert.IsNotNull(Sandbox_RedirectUrl);
        }
        //[Ignore]
        [TestMethod]
        public void CredentialUtilTest11()
        {
            var oAuth2Api = new eBay.ApiClient.Auth.OAuth2.OAuth2Api();
            var environment = eBay.ApiClient.Auth.OAuth2.Model.OAuthEnvironment.PRODUCTION;
            var scopes = new System.Collections.Generic.List<string>()
            {
                //授权代码授权类型
                "https://api.ebay.com/oauth/api_scope",//查看来自易趣的公共数据
                //"https://api.ebay.com/oauth/api_scope/sell.marketing.readonly",//查看您的易趣营销活动，例如广告系列和列表促销
                //"https://api.ebay.com/oauth/api_scope/sell.marketing",//查看和管理您的易趣营销活动，例如广告系列和列表促销
                //"https://api.ebay.com/oauth/api_scope/sell.inventory.readonly",//查看您的库存和优惠
                //"https://api.ebay.com/oauth/api_scope/sell.inventory",//查看和管理您的广告资源和优惠
                //"https://api.ebay.com/oauth/api_scope/sell.account.readonly",//查看您的帐户设置
                //"https://api.ebay.com/oauth/api_scope/sell.account",//	查看和管理您的帐户设置
                //"https://api.ebay.com/oauth/api_scope/sell.fulfillment.readonly",//查看您的订单履行
                //"https://api.ebay.com/oauth/api_scope/sell.fulfillment",//查看和管理您的订单履行
                //"https://api.ebay.com/oauth/api_scope/sell.analytics.readonly",//查看您的销售分析数据，例如效果报告
                //"https://api.ebay.com/oauth/api_scope/sell.finances"//查看和管理您的付款和订单信息，以便向您显示此信息，并允许您使用第三方应用程序启动退款
                ////客户凭证授予类型
                //"https://api.ebay.com/oauth/api_scope"//查看来自易趣的公共数据
            };
            var authorizationUrl = oAuth2Api.GenerateUserAuthorizationUrl(environment, scopes, "state");
            var applicationToken = oAuth2Api.GetApplicationToken(environment, scopes);
            var accessToken1 = oAuth2Api.ExchangeCodeForAccessToken(environment, "code");
            var accessToken2 = oAuth2Api.GetAccessToken(environment, "refreshToken", scopes);
        }
    }
}
