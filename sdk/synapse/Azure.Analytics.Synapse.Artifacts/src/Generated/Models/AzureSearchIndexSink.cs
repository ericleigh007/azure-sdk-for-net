// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Azure Search Index sink. </summary>
    public partial class AzureSearchIndexSink : CopySink
    {
        /// <summary> Initializes a new instance of AzureSearchIndexSink. </summary>
        public AzureSearchIndexSink()
        {
            Type = "AzureSearchIndexSink";
        }

        /// <summary> Initializes a new instance of AzureSearchIndexSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="writeBehavior"> Specify the write behavior when upserting documents into Azure Search Index. </param>
        internal AzureSearchIndexSink(string type, BinaryData writeBatchSize, BinaryData writeBatchTimeout, BinaryData sinkRetryCount, BinaryData sinkRetryWait, BinaryData maxConcurrentConnections, IDictionary<string, BinaryData> additionalProperties, AzureSearchIndexWriteBehaviorType? writeBehavior) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            WriteBehavior = writeBehavior;
            Type = type ?? "AzureSearchIndexSink";
        }

        /// <summary> Specify the write behavior when upserting documents into Azure Search Index. </summary>
        public AzureSearchIndexWriteBehaviorType? WriteBehavior { get; set; }
    }
}
