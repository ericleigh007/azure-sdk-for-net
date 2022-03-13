// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity source for a MongoDB database. </summary>
    public partial class MongoDbV2Source : CopySource
    {
        /// <summary> Initializes a new instance of MongoDbV2Source. </summary>
        public MongoDbV2Source()
        {
            Type = "MongoDbV2Source";
        }

        /// <summary> Initializes a new instance of MongoDbV2Source. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="filter"> Specifies selection filter using query operators. To return all documents in a collection, omit this parameter or pass an empty document ({}). Type: string (or Expression with resultType string). </param>
        /// <param name="cursorMethods"> Cursor methods for Mongodb query. </param>
        /// <param name="batchSize"> Specifies the number of documents to return in each batch of the response from MongoDB instance. In most cases, modifying the batch size will not affect the user or the application. This property&apos;s main purpose is to avoid hit the limitation of response size. Type: integer (or Expression with resultType integer). </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal MongoDbV2Source(string type, BinaryData sourceRetryCount, BinaryData sourceRetryWait, BinaryData maxConcurrentConnections, IDictionary<string, BinaryData> additionalProperties, BinaryData filter, MongoDbCursorMethodsProperties cursorMethods, BinaryData batchSize, BinaryData queryTimeout, BinaryData additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            Filter = filter;
            CursorMethods = cursorMethods;
            BatchSize = batchSize;
            QueryTimeout = queryTimeout;
            AdditionalColumns = additionalColumns;
            Type = type ?? "MongoDbV2Source";
        }

        /// <summary> Specifies selection filter using query operators. To return all documents in a collection, omit this parameter or pass an empty document ({}). Type: string (or Expression with resultType string). </summary>
        public BinaryData Filter { get; set; }
        /// <summary> Cursor methods for Mongodb query. </summary>
        public MongoDbCursorMethodsProperties CursorMethods { get; set; }
        /// <summary> Specifies the number of documents to return in each batch of the response from MongoDB instance. In most cases, modifying the batch size will not affect the user or the application. This property&apos;s main purpose is to avoid hit the limitation of response size. Type: integer (or Expression with resultType integer). </summary>
        public BinaryData BatchSize { get; set; }
        /// <summary> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public BinaryData QueryTimeout { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public BinaryData AdditionalColumns { get; set; }
    }
}
