// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Synapse nested object which contains a flow with data movements and transformations. </summary>
    public partial class DataFlow
    {
        /// <summary> Initializes a new instance of DataFlow. </summary>
        public DataFlow()
        {
            Annotations = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of DataFlow. </summary>
        /// <param name="type"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        internal DataFlow(string type, string description, IList<BinaryData> annotations, DataFlowFolder folder)
        {
            Type = type;
            Description = description;
            Annotations = annotations;
            Folder = folder;
        }

        /// <summary> Type of data flow. </summary>
        internal string Type { get; set; }
        /// <summary> The description of the data flow. </summary>
        public string Description { get; set; }
        /// <summary> List of tags that can be used for describing the data flow. </summary>
        public IList<BinaryData> Annotations { get; }
        /// <summary> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </summary>
        public DataFlowFolder Folder { get; set; }
    }
}
