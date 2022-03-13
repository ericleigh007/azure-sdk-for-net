// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> HBase server linked service. </summary>
    public partial class HBaseLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of HBaseLinkedService. </summary>
        /// <param name="host"> The IP address or host name of the HBase server. (i.e. 192.168.222.160). </param>
        /// <param name="authenticationType"> The authentication mechanism to use to connect to the HBase server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public HBaseLinkedService(BinaryData host, HBaseAuthenticationType authenticationType)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            Host = host;
            AuthenticationType = authenticationType;
            Type = "HBase";
        }

        /// <summary> Initializes a new instance of HBaseLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The IP address or host name of the HBase server. (i.e. 192.168.222.160). </param>
        /// <param name="port"> The TCP port that the HBase instance uses to listen for client connections. The default value is 9090. </param>
        /// <param name="httpPath"> The partial URL corresponding to the HBase server. (i.e. /gateway/sandbox/hbase/version). </param>
        /// <param name="authenticationType"> The authentication mechanism to use to connect to the HBase server. </param>
        /// <param name="username"> The user name used to connect to the HBase instance. </param>
        /// <param name="password"> The password corresponding to the user name. </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </param>
        /// <param name="allowHostNameCNMismatch"> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal HBaseLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData host, BinaryData port, BinaryData httpPath, HBaseAuthenticationType authenticationType, BinaryData username, SecretBase password, BinaryData enableSsl, BinaryData trustedCertPath, BinaryData allowHostNameCNMismatch, BinaryData allowSelfSignedServerCert, BinaryData encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Port = port;
            HttpPath = httpPath;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EnableSsl = enableSsl;
            TrustedCertPath = trustedCertPath;
            AllowHostNameCNMismatch = allowHostNameCNMismatch;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "HBase";
        }

        /// <summary> The IP address or host name of the HBase server. (i.e. 192.168.222.160). </summary>
        public BinaryData Host { get; set; }
        /// <summary> The TCP port that the HBase instance uses to listen for client connections. The default value is 9090. </summary>
        public BinaryData Port { get; set; }
        /// <summary> The partial URL corresponding to the HBase server. (i.e. /gateway/sandbox/hbase/version). </summary>
        public BinaryData HttpPath { get; set; }
        /// <summary> The authentication mechanism to use to connect to the HBase server. </summary>
        public HBaseAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used to connect to the HBase instance. </summary>
        public BinaryData Username { get; set; }
        /// <summary> The password corresponding to the user name. </summary>
        public SecretBase Password { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </summary>
        public BinaryData EnableSsl { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </summary>
        public BinaryData TrustedCertPath { get; set; }
        /// <summary> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </summary>
        public BinaryData AllowHostNameCNMismatch { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. </summary>
        public BinaryData AllowSelfSignedServerCert { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
