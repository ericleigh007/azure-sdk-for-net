// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Format read settings. </summary>
    public partial class FormatReadSettings
    {
        /// <summary> Initializes a new instance of FormatReadSettings. </summary>
        public FormatReadSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of FormatReadSettings. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FormatReadSettings(string type, IDictionary<string, BinaryData> additionalProperties)
        {
            Type = type;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The read setting type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
