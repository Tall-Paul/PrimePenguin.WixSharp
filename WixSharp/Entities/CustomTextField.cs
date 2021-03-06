﻿using Newtonsoft.Json;

namespace WixSharp.Entities
{
    public class CustomTextFieldForProduct
    {
        /// <summary>
        /// Custom text field name
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Whether this text box is mandatory
        /// </summary>
        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        /// <summary>
        /// Whether this text box is mandatory
        /// </summary>
        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }
    }
}