// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity translator. </summary>
    public partial class CopyTranslator
    {
        /// <summary> Initializes a new instance of CopyTranslator. </summary>
        public CopyTranslator()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of CopyTranslator. </summary>
        /// <param name="type"> Copy translator type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CopyTranslator(string type, IDictionary<string, BinaryData> additionalProperties)
        {
            Type = type;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Copy translator type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
