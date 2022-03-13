// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SSIS property override. </summary>
    public partial class SsisPropertyOverride
    {
        /// <summary> Initializes a new instance of SsisPropertyOverride. </summary>
        /// <param name="value"> SSIS package property override value. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SsisPropertyOverride(BinaryData value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        /// <summary> Initializes a new instance of SsisPropertyOverride. </summary>
        /// <param name="value"> SSIS package property override value. Type: string (or Expression with resultType string). </param>
        /// <param name="isSensitive"> Whether SSIS package property override value is sensitive data. Value will be encrypted in SSISDB if it is true. </param>
        internal SsisPropertyOverride(BinaryData value, bool? isSensitive)
        {
            Value = value;
            IsSensitive = isSensitive;
        }

        /// <summary> SSIS package property override value. Type: string (or Expression with resultType string). </summary>
        public BinaryData Value { get; set; }
        /// <summary> Whether SSIS package property override value is sensitive data. Value will be encrypted in SSISDB if it is true. </summary>
        public bool? IsSensitive { get; set; }
    }
}
