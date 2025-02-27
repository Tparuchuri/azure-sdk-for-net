// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Google AdWords service linked service. </summary>
    public partial class GoogleAdWordsLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of GoogleAdWordsLinkedService. </summary>
        public GoogleAdWordsLinkedService()
        {
            LinkedServiceType = "GoogleAdWords";
        }

        /// <summary> Initializes a new instance of GoogleAdWordsLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionProperties"> Properties used to connect to GoogleAds. It is mutually exclusive with any other properties in the linked service. Type: object. </param>
        /// <param name="clientCustomerId"> The Client customer ID of the AdWords account that you want to fetch report data for. </param>
        /// <param name="developerToken">
        /// The developer token associated with the manager account that you use to grant access to the AdWords API.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="authenticationType"> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </param>
        /// <param name="refreshToken">
        /// The refresh token obtained from Google for authorizing access to AdWords for UserAuthentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="clientId"> The client id of the google application used to acquire the refresh token. Type: string (or Expression with resultType string). </param>
        /// <param name="clientSecret">
        /// The client secret of the google application used to acquire the refresh token.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="email"> The service account email ID that is used for ServiceAuthentication and can only be used on self-hosted IR. </param>
        /// <param name="keyFilePath"> The full path to the .p12 key file that is used to authenticate the service account email address and can only be used on self-hosted IR. </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </param>
        /// <param name="useSystemTrustStore"> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal GoogleAdWordsLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData connectionProperties, BinaryData clientCustomerId, SecretBase developerToken, GoogleAdWordsAuthenticationType? authenticationType, SecretBase refreshToken, BinaryData clientId, SecretBase clientSecret, BinaryData email, BinaryData keyFilePath, BinaryData trustedCertPath, BinaryData useSystemTrustStore, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionProperties = connectionProperties;
            ClientCustomerId = clientCustomerId;
            DeveloperToken = developerToken;
            AuthenticationType = authenticationType;
            RefreshToken = refreshToken;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Email = email;
            KeyFilePath = keyFilePath;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "GoogleAdWords";
        }

        /// <summary> Properties used to connect to GoogleAds. It is mutually exclusive with any other properties in the linked service. Type: object. </summary>
        public BinaryData ConnectionProperties { get; set; }
        /// <summary> The Client customer ID of the AdWords account that you want to fetch report data for. </summary>
        public BinaryData ClientCustomerId { get; set; }
        /// <summary>
        /// The developer token associated with the manager account that you use to grant access to the AdWords API.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase DeveloperToken { get; set; }
        /// <summary> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </summary>
        public GoogleAdWordsAuthenticationType? AuthenticationType { get; set; }
        /// <summary>
        /// The refresh token obtained from Google for authorizing access to AdWords for UserAuthentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase RefreshToken { get; set; }
        /// <summary> The client id of the google application used to acquire the refresh token. Type: string (or Expression with resultType string). </summary>
        public BinaryData ClientId { get; set; }
        /// <summary>
        /// The client secret of the google application used to acquire the refresh token.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase ClientSecret { get; set; }
        /// <summary> The service account email ID that is used for ServiceAuthentication and can only be used on self-hosted IR. </summary>
        public BinaryData Email { get; set; }
        /// <summary> The full path to the .p12 key file that is used to authenticate the service account email address and can only be used on self-hosted IR. </summary>
        public BinaryData KeyFilePath { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </summary>
        public BinaryData TrustedCertPath { get; set; }
        /// <summary> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </summary>
        public BinaryData UseSystemTrustStore { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
