﻿using Newtonsoft.Json;

namespace WixSharp.Entities
{
    public class VariantInventoryRequestResponse
    {
        /// <summary>
        /// Inventory item ID
        /// </summary>
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        /// <summary>
        /// Variant ID
        /// </summary>
        [JsonProperty("variantId")]
        public string VariantId { get; set; }

        /// <summary>
        /// Whether the product is listed as in stock
        /// </summary>
        [JsonProperty("inStock")]
        public bool? InStock { get; set; }

        /// <summary>
        /// Quantity currently left in inventory(only returned when inventory is being tracked).
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
    public class VariantInventoryResponse
    {
        [JsonProperty("variant")]
        public VariantInventoryRequestResponse Variant { get; set; }
    }
}