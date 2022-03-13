// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> The resource management error additional info. </summary>
    internal partial class ErrorAdditionalInfo
    {
        /// <summary> Initializes a new instance of ErrorAdditionalInfo. </summary>
        internal ErrorAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of ErrorAdditionalInfo. </summary>
        /// <param name="type"> The additional info type. </param>
        /// <param name="info"> The additional info. </param>
        internal ErrorAdditionalInfo(string type, BinaryData info)
        {
            Type = type;
            Info = info;
        }

        /// <summary> The additional info type. </summary>
        public string Type { get; }
        /// <summary> The additional info. </summary>
        public BinaryData Info { get; }
    }
}
