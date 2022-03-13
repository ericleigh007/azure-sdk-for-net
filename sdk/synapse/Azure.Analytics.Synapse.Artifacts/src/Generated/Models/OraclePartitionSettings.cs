// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The settings that will be leveraged for Oracle source partitioning. </summary>
    public partial class OraclePartitionSettings
    {
        /// <summary> Initializes a new instance of OraclePartitionSettings. </summary>
        public OraclePartitionSettings()
        {
        }

        /// <summary> Initializes a new instance of OraclePartitionSettings. </summary>
        /// <param name="partitionNames"> Names of the physical partitions of Oracle table. </param>
        /// <param name="partitionColumnName"> The name of the column in integer type that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionUpperBound"> The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionLowerBound"> The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        internal OraclePartitionSettings(BinaryData partitionNames, BinaryData partitionColumnName, BinaryData partitionUpperBound, BinaryData partitionLowerBound)
        {
            PartitionNames = partitionNames;
            PartitionColumnName = partitionColumnName;
            PartitionUpperBound = partitionUpperBound;
            PartitionLowerBound = partitionLowerBound;
        }

        /// <summary> Names of the physical partitions of Oracle table. </summary>
        public BinaryData PartitionNames { get; set; }
        /// <summary> The name of the column in integer type that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public BinaryData PartitionColumnName { get; set; }
        /// <summary> The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public BinaryData PartitionUpperBound { get; set; }
        /// <summary> The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public BinaryData PartitionLowerBound { get; set; }
    }
}
