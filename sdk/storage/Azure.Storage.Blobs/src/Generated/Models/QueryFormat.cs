// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The QueryFormat. </summary>
    internal partial class QueryFormat
    {
        /// <summary> Initializes a new instance of QueryFormat. </summary>
        /// <param name="type"> The quick query format type. </param>
        public QueryFormat(QueryFormatType type)
        {
            Type = type;
        }

        /// <summary> The quick query format type. </summary>
        public QueryFormatType Type { get; }
        /// <summary> Groups the settings used for interpreting the blob data if the blob is delimited text formatted. </summary>
        public DelimitedTextConfigurationInternal DelimitedTextConfiguration { get; set; }
        /// <summary> json text configuration. </summary>
        public JsonTextConfigurationInternal JsonTextConfiguration { get; set; }
        /// <summary> Groups the settings used for formatting the response if the response should be Arrow formatted. </summary>
        public ArrowTextConfigurationInternal ArrowConfiguration { get; set; }
        /// <summary> Any object. </summary>
        public BinaryData ParquetTextConfiguration { get; set; }
    }
}
