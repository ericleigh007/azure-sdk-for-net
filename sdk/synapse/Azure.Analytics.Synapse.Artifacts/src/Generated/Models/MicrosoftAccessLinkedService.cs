// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Microsoft Access linked service. </summary>
    public partial class MicrosoftAccessLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of MicrosoftAccessLinkedService. </summary>
        /// <param name="connectionString"> The non-access credential portion of the connection string as well as an optional encrypted credential. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public MicrosoftAccessLinkedService(BinaryData connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            ConnectionString = connectionString;
            Type = "MicrosoftAccess";
        }

        /// <summary> Initializes a new instance of MicrosoftAccessLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The non-access credential portion of the connection string as well as an optional encrypted credential. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the Microsoft Access as ODBC data store. Possible values are: Anonymous and Basic. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The access credential portion of the connection string specified in driver-specific property-value format. </param>
        /// <param name="userName"> User name for Basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for Basic authentication. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal MicrosoftAccessLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData connectionString, BinaryData authenticationType, SecretBase credential, BinaryData userName, SecretBase password, BinaryData encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            AuthenticationType = authenticationType;
            Credential = credential;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "MicrosoftAccess";
        }

        /// <summary> The non-access credential portion of the connection string as well as an optional encrypted credential. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public BinaryData ConnectionString { get; set; }
        /// <summary> Type of authentication used to connect to the Microsoft Access as ODBC data store. Possible values are: Anonymous and Basic. Type: string (or Expression with resultType string). </summary>
        public BinaryData AuthenticationType { get; set; }
        /// <summary> The access credential portion of the connection string specified in driver-specific property-value format. </summary>
        public SecretBase Credential { get; set; }
        /// <summary> User name for Basic authentication. Type: string (or Expression with resultType string). </summary>
        public BinaryData UserName { get; set; }
        /// <summary> Password for Basic authentication. </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
