// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity source for a Cassandra database. </summary>
    public partial class CassandraSource : TabularSource
    {
        /// <summary> Initializes a new instance of CassandraSource. </summary>
        public CassandraSource()
        {
            Type = "CassandraSource";
        }

        /// <summary> Initializes a new instance of CassandraSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="query"> Database query. Should be a SQL-92 query expression or Cassandra Query Language (CQL) command. Type: string (or Expression with resultType string). </param>
        /// <param name="consistencyLevel"> The consistency level specifies how many Cassandra servers must respond to a read request before returning data to the client application. Cassandra checks the specified number of Cassandra servers for data to satisfy the read request. Must be one of cassandraSourceReadConsistencyLevels. The default value is &apos;ONE&apos;. It is case-insensitive. </param>
        internal CassandraSource(string type, BinaryData sourceRetryCount, BinaryData sourceRetryWait, BinaryData maxConcurrentConnections, IDictionary<string, BinaryData> additionalProperties, BinaryData queryTimeout, BinaryData additionalColumns, BinaryData query, CassandraSourceReadConsistencyLevels? consistencyLevel) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            Query = query;
            ConsistencyLevel = consistencyLevel;
            Type = type ?? "CassandraSource";
        }

        /// <summary> Database query. Should be a SQL-92 query expression or Cassandra Query Language (CQL) command. Type: string (or Expression with resultType string). </summary>
        public BinaryData Query { get; set; }
        /// <summary> The consistency level specifies how many Cassandra servers must respond to a read request before returning data to the client application. Cassandra checks the specified number of Cassandra servers for data to satisfy the read request. Must be one of cassandraSourceReadConsistencyLevels. The default value is &apos;ONE&apos;. It is case-insensitive. </summary>
        public CassandraSourceReadConsistencyLevels? ConsistencyLevel { get; set; }
    }
}
