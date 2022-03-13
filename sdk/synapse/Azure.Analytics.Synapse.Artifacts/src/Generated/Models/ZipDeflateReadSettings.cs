// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The ZipDeflate compression read settings. </summary>
    public partial class ZipDeflateReadSettings : CompressionReadSettings
    {
        /// <summary> Initializes a new instance of ZipDeflateReadSettings. </summary>
        public ZipDeflateReadSettings()
        {
            Type = "ZipDeflateReadSettings";
        }

        /// <summary> Initializes a new instance of ZipDeflateReadSettings. </summary>
        /// <param name="type"> The Compression setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="preserveZipFileNameAsFolder"> Preserve the zip file name as folder path. Type: boolean (or Expression with resultType boolean). </param>
        internal ZipDeflateReadSettings(string type, IDictionary<string, BinaryData> additionalProperties, BinaryData preserveZipFileNameAsFolder) : base(type, additionalProperties)
        {
            PreserveZipFileNameAsFolder = preserveZipFileNameAsFolder;
            Type = type ?? "ZipDeflateReadSettings";
        }

        /// <summary> Preserve the zip file name as folder path. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData PreserveZipFileNameAsFolder { get; set; }
    }
}
