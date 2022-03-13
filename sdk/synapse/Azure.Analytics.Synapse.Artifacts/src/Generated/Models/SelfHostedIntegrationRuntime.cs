// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Self-hosted integration runtime. </summary>
    public partial class SelfHostedIntegrationRuntime : IntegrationRuntime
    {
        /// <summary> Initializes a new instance of SelfHostedIntegrationRuntime. </summary>
        public SelfHostedIntegrationRuntime()
        {
            Type = IntegrationRuntimeType.SelfHosted;
        }

        /// <summary> Initializes a new instance of SelfHostedIntegrationRuntime. </summary>
        /// <param name="type"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedInfo"> Linked integration runtime type from data factory. </param>
        internal SelfHostedIntegrationRuntime(IntegrationRuntimeType type, string description, IDictionary<string, BinaryData> additionalProperties, LinkedIntegrationRuntimeType linkedInfo) : base(type, description, additionalProperties)
        {
            LinkedInfo = linkedInfo;
            Type = type;
        }

        /// <summary> Linked integration runtime type from data factory. </summary>
        public LinkedIntegrationRuntimeType LinkedInfo { get; set; }
    }
}
