// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Google Cloud Storage read settings. </summary>
    public partial class GoogleCloudStorageReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of GoogleCloudStorageReadSettings. </summary>
        public GoogleCloudStorageReadSettings()
        {
            Type = "GoogleCloudStorageReadSettings";
        }

        /// <summary> Initializes a new instance of GoogleCloudStorageReadSettings. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> Google Cloud Storage wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> Google Cloud Storage wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="prefix"> The prefix filter for the Google Cloud Storage object name. Type: string (or Expression with resultType string). </param>
        /// <param name="fileListPath"> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. </param>
        /// <param name="partitionRootPath"> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </param>
        /// <param name="deleteFilesAfterCompletion"> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="modifiedDatetimeStart"> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        internal GoogleCloudStorageReadSettings(string type, BinaryData maxConcurrentConnections, IDictionary<string, BinaryData> additionalProperties, BinaryData recursive, BinaryData wildcardFolderPath, BinaryData wildcardFileName, BinaryData prefix, BinaryData fileListPath, bool? enablePartitionDiscovery, BinaryData partitionRootPath, BinaryData deleteFilesAfterCompletion, BinaryData modifiedDatetimeStart, BinaryData modifiedDatetimeEnd) : base(type, maxConcurrentConnections, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            Prefix = prefix;
            FileListPath = fileListPath;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            PartitionRootPath = partitionRootPath;
            DeleteFilesAfterCompletion = deleteFilesAfterCompletion;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            Type = type ?? "GoogleCloudStorageReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData Recursive { get; set; }
        /// <summary> Google Cloud Storage wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public BinaryData WildcardFolderPath { get; set; }
        /// <summary> Google Cloud Storage wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public BinaryData WildcardFileName { get; set; }
        /// <summary> The prefix filter for the Google Cloud Storage object name. Type: string (or Expression with resultType string). </summary>
        public BinaryData Prefix { get; set; }
        /// <summary> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </summary>
        public BinaryData FileListPath { get; set; }
        /// <summary> Indicates whether to enable partition discovery. </summary>
        public bool? EnablePartitionDiscovery { get; set; }
        /// <summary> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </summary>
        public BinaryData PartitionRootPath { get; set; }
        /// <summary> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData DeleteFilesAfterCompletion { get; set; }
        /// <summary> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public BinaryData ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public BinaryData ModifiedDatetimeEnd { get; set; }
    }
}
