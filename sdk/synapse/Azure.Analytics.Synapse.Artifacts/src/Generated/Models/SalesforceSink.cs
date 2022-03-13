// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Salesforce sink. </summary>
    public partial class SalesforceSink : CopySink
    {
        /// <summary> Initializes a new instance of SalesforceSink. </summary>
        public SalesforceSink()
        {
            Type = "SalesforceSink";
        }

        /// <summary> Initializes a new instance of SalesforceSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="writeBehavior"> The write behavior for the operation. Default is Insert. </param>
        /// <param name="externalIdFieldName"> The name of the external ID field for upsert operation. Default value is &apos;Id&apos; column. Type: string (or Expression with resultType string). </param>
        /// <param name="ignoreNullValues"> The flag indicating whether or not to ignore null values from input dataset (except key fields) during write operation. Default value is false. If set it to true, it means ADF will leave the data in the destination object unchanged when doing upsert/update operation and insert defined default value when doing insert operation, versus ADF will update the data in the destination object to NULL when doing upsert/update operation and insert NULL value when doing insert operation. Type: boolean (or Expression with resultType boolean). </param>
        internal SalesforceSink(string type, BinaryData writeBatchSize, BinaryData writeBatchTimeout, BinaryData sinkRetryCount, BinaryData sinkRetryWait, BinaryData maxConcurrentConnections, IDictionary<string, BinaryData> additionalProperties, SalesforceSinkWriteBehavior? writeBehavior, BinaryData externalIdFieldName, BinaryData ignoreNullValues) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            WriteBehavior = writeBehavior;
            ExternalIdFieldName = externalIdFieldName;
            IgnoreNullValues = ignoreNullValues;
            Type = type ?? "SalesforceSink";
        }

        /// <summary> The write behavior for the operation. Default is Insert. </summary>
        public SalesforceSinkWriteBehavior? WriteBehavior { get; set; }
        /// <summary> The name of the external ID field for upsert operation. Default value is &apos;Id&apos; column. Type: string (or Expression with resultType string). </summary>
        public BinaryData ExternalIdFieldName { get; set; }
        /// <summary> The flag indicating whether or not to ignore null values from input dataset (except key fields) during write operation. Default value is false. If set it to true, it means ADF will leave the data in the destination object unchanged when doing upsert/update operation and insert defined default value when doing insert operation, versus ADF will update the data in the destination object to NULL when doing upsert/update operation and insert NULL value when doing insert operation. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData IgnoreNullValues { get; set; }
    }
}
