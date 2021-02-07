using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebAPI.DTO
{
    [JsonObject]
    public class Order
    {
        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }
        [JsonProperty("products")]
        public List<Product> Products { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }

    [JsonObject]
    public class Product
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("comment")]
        public string Comment { get; set; }
        [JsonProperty("quantity")]
        public string Quantity { get; set; }
        [JsonProperty("paidPrice")]
        public string PaidPrice { get; set; }
        [JsonProperty("unitPrice")]
        public string UnitPrice { get; set; }
        [JsonProperty("remoteCode")]
        public string RemoteCode { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("vatPercentage")]
        public string VatPercentage { get; set; }
        [JsonProperty("discountAmount")]
        public string DiscountAmount { get; set; }
    }
}
