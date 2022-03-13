// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Spark job definition. </summary>
    public partial class SparkJobDefinition
    {
        /// <summary> Initializes a new instance of SparkJobDefinition. </summary>
        /// <param name="targetBigDataPool"> Big data pool reference. </param>
        /// <param name="jobProperties"> The properties of the Spark job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetBigDataPool"/> or <paramref name="jobProperties"/> is null. </exception>
        public SparkJobDefinition(BigDataPoolReference targetBigDataPool, SparkJobProperties jobProperties)
        {
            if (targetBigDataPool == null)
            {
                throw new ArgumentNullException(nameof(targetBigDataPool));
            }
            if (jobProperties == null)
            {
                throw new ArgumentNullException(nameof(jobProperties));
            }

            TargetBigDataPool = targetBigDataPool;
            JobProperties = jobProperties;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of SparkJobDefinition. </summary>
        /// <param name="description"> The description of the Spark job definition. </param>
        /// <param name="targetBigDataPool"> Big data pool reference. </param>
        /// <param name="requiredSparkVersion"> The required Spark version of the application. </param>
        /// <param name="language"> The language of the Spark application. </param>
        /// <param name="jobProperties"> The properties of the Spark job. </param>
        /// <param name="folder"> The folder that this Spark job definition is in. If not specified, this Spark job definition will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SparkJobDefinition(string description, BigDataPoolReference targetBigDataPool, string requiredSparkVersion, string language, SparkJobProperties jobProperties, SparkJobDefinitionFolder folder, IDictionary<string, BinaryData> additionalProperties)
        {
            Description = description;
            TargetBigDataPool = targetBigDataPool;
            RequiredSparkVersion = requiredSparkVersion;
            Language = language;
            JobProperties = jobProperties;
            Folder = folder;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The description of the Spark job definition. </summary>
        public string Description { get; set; }
        /// <summary> Big data pool reference. </summary>
        public BigDataPoolReference TargetBigDataPool { get; set; }
        /// <summary> The required Spark version of the application. </summary>
        public string RequiredSparkVersion { get; set; }
        /// <summary> The language of the Spark application. </summary>
        public string Language { get; set; }
        /// <summary> The properties of the Spark job. </summary>
        public SparkJobProperties JobProperties { get; set; }
        /// <summary> The folder that this Spark job definition is in. If not specified, this Spark job definition will appear at the root level. </summary>
        public SparkJobDefinitionFolder Folder { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
