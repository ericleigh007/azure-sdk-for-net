// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The location of azure blob dataset. </summary>
    public partial class AzureBlobStorageLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of AzureBlobStorageLocation. </summary>
        public AzureBlobStorageLocation()
        {
            Type = "AzureBlobStorageLocation";
        }

        /// <summary> Initializes a new instance of AzureBlobStorageLocation. </summary>
        /// <param name="type"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="container"> Specify the container of azure blob. Type: string (or Expression with resultType string). </param>
        internal AzureBlobStorageLocation(string type, BinaryData folderPath, BinaryData fileName, IDictionary<string, BinaryData> additionalProperties, BinaryData container) : base(type, folderPath, fileName, additionalProperties)
        {
            Container = container;
            Type = type ?? "AzureBlobStorageLocation";
        }

        /// <summary> Specify the container of azure blob. Type: string (or Expression with resultType string). </summary>
        public BinaryData Container { get; set; }
    }
}
