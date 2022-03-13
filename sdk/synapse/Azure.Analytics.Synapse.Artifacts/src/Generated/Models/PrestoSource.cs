// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Presto server source. </summary>
    public partial class PrestoSource : TabularSource
    {
        /// <summary> Initializes a new instance of PrestoSource. </summary>
        public PrestoSource()
        {
            Type = "PrestoSource";
        }

        /// <summary> Initializes a new instance of PrestoSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="query"> A query to retrieve data from source. Type: string (or Expression with resultType string). </param>
        internal PrestoSource(string type, BinaryData sourceRetryCount, BinaryData sourceRetryWait, BinaryData maxConcurrentConnections, IDictionary<string, BinaryData> additionalProperties, BinaryData queryTimeout, BinaryData additionalColumns, BinaryData query) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            Query = query;
            Type = type ?? "PrestoSource";
        }

        /// <summary> A query to retrieve data from source. Type: string (or Expression with resultType string). </summary>
        public BinaryData Query { get; set; }
    }
}
