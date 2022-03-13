// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The Azure MySQL database dataset. </summary>
    public partial class AzureMySqlTableDataset : Dataset
    {
        /// <summary> Initializes a new instance of AzureMySqlTableDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public AzureMySqlTableDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "AzureMySqlTable";
        }

        /// <summary> Initializes a new instance of AzureMySqlTableDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="tableName"> The Azure MySQL database table name. Type: string (or Expression with resultType string). </param>
        /// <param name="table"> The name of Azure MySQL database table. Type: string (or Expression with resultType string). </param>
        internal AzureMySqlTableDataset(string type, string description, BinaryData structure, BinaryData schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, BinaryData tableName, BinaryData table) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            TableName = tableName;
            Table = table;
            Type = type ?? "AzureMySqlTable";
        }

        /// <summary> The Azure MySQL database table name. Type: string (or Expression with resultType string). </summary>
        public BinaryData TableName { get; set; }
        /// <summary> The name of Azure MySQL database table. Type: string (or Expression with resultType string). </summary>
        public BinaryData Table { get; set; }
    }
}
