// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Salesforce Marketing Cloud linked service. </summary>
    public partial class SalesforceMarketingCloudLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of SalesforceMarketingCloudLinkedService. </summary>
        /// <param name="clientId"> The client ID associated with the Salesforce Marketing Cloud application. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientId"/> is null. </exception>
        public SalesforceMarketingCloudLinkedService(BinaryData clientId)
        {
            if (clientId == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            ClientId = clientId;
            Type = "SalesforceMarketingCloud";
        }

        /// <summary> Initializes a new instance of SalesforceMarketingCloudLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionProperties"> Properties used to connect to Salesforce Marketing Cloud. It is mutually exclusive with any other properties in the linked service. Type: object. </param>
        /// <param name="clientId"> The client ID associated with the Salesforce Marketing Cloud application. Type: string (or Expression with resultType string). </param>
        /// <param name="clientSecret"> The client secret associated with the Salesforce Marketing Cloud application. Type: string (or Expression with resultType string). </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal SalesforceMarketingCloudLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData connectionProperties, BinaryData clientId, SecretBase clientSecret, BinaryData useEncryptedEndpoints, BinaryData useHostVerification, BinaryData usePeerVerification, BinaryData encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionProperties = connectionProperties;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "SalesforceMarketingCloud";
        }

        /// <summary> Properties used to connect to Salesforce Marketing Cloud. It is mutually exclusive with any other properties in the linked service. Type: object. </summary>
        public BinaryData ConnectionProperties { get; set; }
        /// <summary> The client ID associated with the Salesforce Marketing Cloud application. Type: string (or Expression with resultType string). </summary>
        public BinaryData ClientId { get; set; }
        /// <summary> The client secret associated with the Salesforce Marketing Cloud application. Type: string (or Expression with resultType string). </summary>
        public SecretBase ClientSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
