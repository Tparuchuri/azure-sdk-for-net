// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the client certificate details using common name. </summary>
    public partial class ClientCertificateCommonName
    {
        /// <summary> Initializes a new instance of ClientCertificateCommonName. </summary>
        /// <param name="isAdmin"> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </param>
        /// <param name="certificateCommonName"> The common name of the client certificate. </param>
        /// <param name="certificateIssuerThumbprint"> The issuer thumbprint of the client certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateCommonName"/> or <paramref name="certificateIssuerThumbprint"/> is null. </exception>
        public ClientCertificateCommonName(bool isAdmin, string certificateCommonName, string certificateIssuerThumbprint)
        {
            if (certificateCommonName == null)
            {
                throw new ArgumentNullException(nameof(certificateCommonName));
            }
            if (certificateIssuerThumbprint == null)
            {
                throw new ArgumentNullException(nameof(certificateIssuerThumbprint));
            }

            IsAdmin = isAdmin;
            CertificateCommonName = certificateCommonName;
            CertificateIssuerThumbprint = certificateIssuerThumbprint;
        }

        /// <summary> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </summary>
        public bool IsAdmin { get; set; }
        /// <summary> The common name of the client certificate. </summary>
        public string CertificateCommonName { get; set; }
        /// <summary> The issuer thumbprint of the client certificate. </summary>
        public string CertificateIssuerThumbprint { get; set; }
    }
}
