// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Delete activity. </summary>
    public partial class DeleteActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DeleteActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="dataset"> Delete activity dataset reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataset"/> is null. </exception>
        public DeleteActivity(string name, DatasetReference dataset) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            Dataset = dataset;
            Type = "Delete";
        }

        /// <summary> Initializes a new instance of DeleteActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="recursive"> If true, files or sub-folders under current folder path will be deleted recursively. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="maxConcurrentConnections"> The max concurrent connections to connect data source at the same time. </param>
        /// <param name="enableLogging"> Whether to record detailed logs of delete-activity execution. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="logStorageSettings"> Log storage settings customer need to provide when enableLogging is true. </param>
        /// <param name="dataset"> Delete activity dataset reference. </param>
        /// <param name="storeSettings"> Delete activity store settings. </param>
        internal DeleteActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData recursive, int? maxConcurrentConnections, BinaryData enableLogging, LogStorageSettings logStorageSettings, DatasetReference dataset, StoreReadSettings storeSettings) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Recursive = recursive;
            MaxConcurrentConnections = maxConcurrentConnections;
            EnableLogging = enableLogging;
            LogStorageSettings = logStorageSettings;
            Dataset = dataset;
            StoreSettings = storeSettings;
            Type = type ?? "Delete";
        }

        /// <summary> If true, files or sub-folders under current folder path will be deleted recursively. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData Recursive { get; set; }
        /// <summary> The max concurrent connections to connect data source at the same time. </summary>
        public int? MaxConcurrentConnections { get; set; }
        /// <summary> Whether to record detailed logs of delete-activity execution. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData EnableLogging { get; set; }
        /// <summary> Log storage settings customer need to provide when enableLogging is true. </summary>
        public LogStorageSettings LogStorageSettings { get; set; }
        /// <summary> Delete activity dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary> Delete activity store settings. </summary>
        public StoreReadSettings StoreSettings { get; set; }
    }
}
