// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Input of the secret to be validated. </summary>
    public partial class ValidateSecretInput
    {
        /// <summary> Initializes a new instance of ValidateSecretInput. </summary>
        /// <param name="secretType"> The secret type. </param>
        /// <param name="secretSource"> Resource reference to the Azure Key Vault secret. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{secretName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretSource"/> is null. </exception>
        public ValidateSecretInput(SecretType secretType, WritableSubResource secretSource)
        {
            if (secretSource == null)
            {
                throw new ArgumentNullException(nameof(secretSource));
            }

            SecretType = secretType;
            SecretSource = secretSource;
        }

        /// <summary> The secret type. </summary>
        public SecretType SecretType { get; }
        /// <summary> Resource reference to the Azure Key Vault secret. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{secretName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​. </summary>
        public WritableSubResource SecretSource { get; }
        /// <summary> Secret version, if customer is using a specific version. </summary>
        public string SecretVersion { get; set; }
    }
}
