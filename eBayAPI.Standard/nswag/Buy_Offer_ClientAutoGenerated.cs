﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.0.6.0 (NJsonSchema v10.0.23.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace eBayApi.Buy.Offer
{
    using System = global::System;
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.6.0 (NJsonSchema v10.0.23.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class Client 
    {
        private string _baseUrl = "https://api.ebay.com{basePath}";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
    
        public Client(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient; 
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() => 
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }
    
        public string BaseUrl 
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
    
        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }
    
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
    
        /// <param name="item_id">The eBay RESTful identifier of an item that you want the buyer's bidding information. This ID is returned by the Browse and Feed API methods. RESTful Item ID example: v1|272394640372|0 For more information about item ID for RESTful APIs, see the Legacy API compatibility section of the Buy APIs Overview. Restriction: The buyer must have placed a bid for this item.</param>
        /// <param name="x_EBAY_C_MARKETPLACE_ID">The ID of the eBay marketplace where the buyer is based. Note: This value is case sensitive. For example: &amp;nbsp;&amp;nbsp;X-EBAY-C-MARKETPLACE-ID = EBAY_US For a list of supported sites see, API Restrictions.</param>
        /// <returns>OK</returns>
        /// <exception cref="eBayApi.ApiException">A server side error occurred.</exception>
        public Bidding GetBidding(string item_id, string x_EBAY_C_MARKETPLACE_ID)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetBiddingAsync(item_id, x_EBAY_C_MARKETPLACE_ID, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="item_id">The eBay RESTful identifier of an item that you want the buyer's bidding information. This ID is returned by the Browse and Feed API methods. RESTful Item ID example: v1|272394640372|0 For more information about item ID for RESTful APIs, see the Legacy API compatibility section of the Buy APIs Overview. Restriction: The buyer must have placed a bid for this item.</param>
        /// <param name="x_EBAY_C_MARKETPLACE_ID">The ID of the eBay marketplace where the buyer is based. Note: This value is case sensitive. For example: &amp;nbsp;&amp;nbsp;X-EBAY-C-MARKETPLACE-ID = EBAY_US For a list of supported sites see, API Restrictions.</param>
        /// <returns>OK</returns>
        /// <exception cref="eBayApi.ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Bidding> GetBiddingAsync(string item_id, string x_EBAY_C_MARKETPLACE_ID, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            if (item_id == null)
                throw new System.ArgumentNullException("item_id");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bidding/{item_id}");
            urlBuilder_.Replace("{item_id}", System.Uri.EscapeDataString(ConvertToString(item_id, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    if (x_EBAY_C_MARKETPLACE_ID == null)
                        throw new System.ArgumentNullException("x_EBAY_C_MARKETPLACE_ID");
                    request_.Headers.TryAddWithoutValidation("X-EBAY-C-MARKETPLACE-ID", ConvertToString(x_EBAY_C_MARKETPLACE_ID, System.Globalization.CultureInfo.InvariantCulture));
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Bidding>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new eBayApi.ApiException("Bad Request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "404") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new eBayApi.ApiException("Not found", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new eBayApi.ApiException("Internal Server Error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new eBayApi.ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(Bidding);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <param name="item_id">The eBay RESTful identifier of an item you want to bid on. This ID is returned by the Browse and Feed API methods. RESTful Item ID Example: v1|272394640372|0 For more information about item ID for RESTful APIs, see the Legacy API compatibility section of the Buy APIs Overview.</param>
        /// <param name="x_EBAY_C_MARKETPLACE_ID">The ID of the eBay marketplace where the buyer is based. Note: This value is case sensitive. For example: &amp;nbsp;&amp;nbsp;X-EBAY-C-MARKETPLACE-ID = EBAY_US For a list of supported sites see, API Restrictions.</param>
        /// <returns>OK</returns>
        /// <exception cref="eBayApi.ApiException">A server side error occurred.</exception>
        public PlaceProxyBidResponse PlaceProxyBid(string item_id, string x_EBAY_C_MARKETPLACE_ID, PlaceProxyBidRequest body = null)
        {
            return System.Threading.Tasks.Task.Run(async () => await PlaceProxyBidAsync(item_id, x_EBAY_C_MARKETPLACE_ID, body, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="item_id">The eBay RESTful identifier of an item you want to bid on. This ID is returned by the Browse and Feed API methods. RESTful Item ID Example: v1|272394640372|0 For more information about item ID for RESTful APIs, see the Legacy API compatibility section of the Buy APIs Overview.</param>
        /// <param name="x_EBAY_C_MARKETPLACE_ID">The ID of the eBay marketplace where the buyer is based. Note: This value is case sensitive. For example: &amp;nbsp;&amp;nbsp;X-EBAY-C-MARKETPLACE-ID = EBAY_US For a list of supported sites see, API Restrictions.</param>
        /// <returns>OK</returns>
        /// <exception cref="eBayApi.ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<PlaceProxyBidResponse> PlaceProxyBidAsync(string item_id, string x_EBAY_C_MARKETPLACE_ID, PlaceProxyBidRequest body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            if (item_id == null)
                throw new System.ArgumentNullException("item_id");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bidding/{item_id}/place_proxy_bid");
            urlBuilder_.Replace("{item_id}", System.Uri.EscapeDataString(ConvertToString(item_id, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    if (x_EBAY_C_MARKETPLACE_ID == null)
                        throw new System.ArgumentNullException("x_EBAY_C_MARKETPLACE_ID");
                    request_.Headers.TryAddWithoutValidation("X-EBAY-C-MARKETPLACE-ID", ConvertToString(x_EBAY_C_MARKETPLACE_ID, System.Globalization.CultureInfo.InvariantCulture));
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<PlaceProxyBidResponse>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        if (status_ == "400") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new eBayApi.ApiException("Bad request", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "404") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new eBayApi.ApiException("Not found", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "409") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new eBayApi.ApiException("Conflict", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            string responseText_ = ( response_.Content == null ) ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new eBayApi.ApiException("Internal Server Error", (int)response_.StatusCode, responseText_, headers_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new eBayApi.ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(PlaceProxyBidResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                this.Object = responseObject;
                this.Text = responseText;
            }
    
            public T Object { get; }
    
            public string Text { get; }
        }
    
        public bool ReadResponseAsString { get; set; }
        
        protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default(T), string.Empty);
            }
        
            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new eBayApi.ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new System.IO.StreamReader(responseStream))
                    using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {
                        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new eBayApi.ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }
    
        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is System.Enum)
            {
                string name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute)) 
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }
                }
            }
            else if (value is bool) {
                return System.Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[]) value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array) value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }
        
            return System.Convert.ToString(value, cultureInfo);
        }
    }

    /// <summary>The type that defines the fields for a monetary value and its currency.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Amount 
    {
        /// <summary>The three-letter ISO 4217 code representing the currency of the amount in the value field. For implementation help, refer to &lt;a href='https://developer.ebay.com/devzone/rest/api-ref/offer/types/CurrencyCodeEnum.html'&gt;eBay API documentation&lt;/a&gt;</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }
    
        /// <summary>The monetary amount.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The type the defines the field for the auction details.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Bidding 
    {
        /// <summary>The date the auction will end.</summary>
        [Newtonsoft.Json.JsonProperty("auctionEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuctionEndDate { get; set; }
    
        /// <summary>An enumeration value that represents the current state of the auction, such as ENDED or LIVE. For implementation help, refer to &lt;a href='https://developer.ebay.com/devzone/rest/api-ref/offer/types/AuctionStatusEnum.html'&gt;eBay API documentation&lt;/a&gt;</summary>
        [Newtonsoft.Json.JsonProperty("auctionStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuctionStatus { get; set; }
    
        /// <summary>The number of proxy bids that have been placed for the auction.</summary>
        [Newtonsoft.Json.JsonProperty("bidCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int BidCount { get; set; }
    
        /// <summary>The amount of the highest bid, which is the current price of the item.</summary>
        [Newtonsoft.Json.JsonProperty("currentPrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Amount CurrentPrice { get; set; }
    
        /// <summary>The buyer's proxy bid, which is the maxAmount specified in the request.</summary>
        [Newtonsoft.Json.JsonProperty("currentProxyBid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProxyBid CurrentProxyBid { get; set; }
    
        /// <summary>Indicates if the buyer is the highest bidder.</summary>
        [Newtonsoft.Json.JsonProperty("highBidder", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool HighBidder { get; set; }
    
        /// <summary>The eBay RESTful identifier of an item being bid on, which was submitted in the request.</summary>
        [Newtonsoft.Json.JsonProperty("itemId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemId { get; set; }
    
        /// <summary>This indicates if the reserve price of the item has been met. A reserve price is set by the seller and is the minimum amount the seller is willing to sell the item for. If the highest bid is not equal to or higher than the reserve price when the auction ends, the listing ends and the item is not sold. Note: This is returned only for auctions that have a reserve price.</summary>
        [Newtonsoft.Json.JsonProperty("reservePriceMet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ReservePriceMet { get; set; }
    
        /// <summary>The suggested bid amount for the next bid. Note: These are generated suggestions and do not guarantee the buyer will win the bid. This means these suggestions do not take into account the max bid amount of other bidders. The buyer can be outbid even if they submit the highest suggested bid.</summary>
        [Newtonsoft.Json.JsonProperty("suggestedBidAmounts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Amount> SuggestedBidAmounts { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>This type defines the fields that can be returned in an error.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Error 
    {
        /// <summary>Identifies the type of erro.</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }
    
        /// <summary>Name for the primary system where the error occurred. This is relevant for application errors.</summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }
    
        /// <summary>A unique number to identify the error.</summary>
        [Newtonsoft.Json.JsonProperty("errorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ErrorId { get; set; }
    
        /// <summary>An array of request elements most closely associated to the error.</summary>
        [Newtonsoft.Json.JsonProperty("inputRefIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> InputRefIds { get; set; }
    
        /// <summary>A more detailed explanation of the error.</summary>
        [Newtonsoft.Json.JsonProperty("longMessage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LongMessage { get; set; }
    
        /// <summary>Information on how to correct the problem, in the end user's terms and language where applicable.</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }
    
        /// <summary>An array of request elements most closely associated to the error.</summary>
        [Newtonsoft.Json.JsonProperty("outputRefIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> OutputRefIds { get; set; }
    
        /// <summary>An array of name/value pairs that describe details the error condition. These are useful when multiple errors are returned.</summary>
        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ErrorParameter> Parameters { get; set; }
    
        /// <summary>Further helps indicate which subsystem the error is coming from. System subcategories include: Initialization, Serialization, Security, Monitoring, Rate Limiting, etc.</summary>
        [Newtonsoft.Json.JsonProperty("subdomain", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subdomain { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ErrorParameter 
    {
        /// <summary>The object of the error.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>The value of the object.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The type that defines the fields for placing a proxy bid.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PlaceProxyBidRequest 
    {
        /// <summary>The amount of the proxy bid to be placed. This is the maximum amount the buyer is willing to pay for the item. Note: Currency for the bid must be the currency specified by the seller when listing the item. If the currency has been converted, the seller's currency will be returned in the convertedFromCurrency field. VAT (value added tax) does not need to be added to the proxy bid amount even if VAT applies.</summary>
        [Newtonsoft.Json.JsonProperty("maxAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Amount MaxAmount { get; set; }
    
        /// <summary>Specifics whether buyer wants to give their consent to bid on adult-only items. For a buyer to bid on an adult-only item, you must collect their consent using this field and they must agree to the Terms of Use. For more information about adult-only items on eBay, see Adult-Only items on eBay. Default: false</summary>
        [Newtonsoft.Json.JsonProperty("userConsent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserConsent UserConsent { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The type that defines the fields for the place proxy bid response.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PlaceProxyBidResponse 
    {
        /// <summary>Identifier of the proxy bid created by the request. This indicates that the bid was placed and is not used for anything else.</summary>
        [Newtonsoft.Json.JsonProperty("proxyBidId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProxyBidId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The type the defines the fields for the proxy bid information.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ProxyBid 
    {
        /// <summary>The maximum amount the buyer is willing to pay for the item.</summary>
        [Newtonsoft.Json.JsonProperty("maxAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Amount MaxAmount { get; set; }
    
        /// <summary>Identifier of a specific proxy bid.</summary>
        [Newtonsoft.Json.JsonProperty("proxyBidId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProxyBidId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>The type that defines the fields for collecting the buyers consent.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UserConsent 
    {
        /// <summary>The type that defines the fields for buyer consent to bid on adult-only items. For more information about adult-only items on eBay, see Adult-Only items on eBay.</summary>
        [Newtonsoft.Json.JsonProperty("adultOnlyItem", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool AdultOnlyItem { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108