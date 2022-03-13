// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Informix sink. </summary>
    public partial class InformixSink : CopySink
    {
        /// <summary> Initializes a new instance of InformixSink. </summary>
        public InformixSink()
        {
            Type = "InformixSink";
        }

        /// <summary> Initializes a new instance of InformixSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="preCopyScript"> A query to execute before starting the copy. Type: string (or Expression with resultType string). </param>
        internal InformixSink(string type, BinaryData writeBatchSize, BinaryData writeBatchTimeout, BinaryData sinkRetryCount, BinaryData sinkRetryWait, BinaryData maxConcurrentConnections, IDictionary<string, BinaryData> additionalProperties, BinaryData preCopyScript) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            PreCopyScript = preCopyScript;
            Type = type ?? "InformixSink";
        }

        /// <summary> A query to execute before starting the copy. Type: string (or Expression with resultType string). </summary>
        public BinaryData PreCopyScript { get; set; }
    }
}
