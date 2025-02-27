// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> The Custom Locations patchable resource definition. </summary>
    public partial class CustomLocationPatch
    {
        /// <summary> Initializes a new instance of CustomLocationPatch. </summary>
        public CustomLocationPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ClusterExtensionIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Identity for the resource. </summary>
        public SystemAssignedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> This is optional input that contains the authentication that should be used to generate the namespace. </summary>
        public CustomLocationAuthentication Authentication { get; set; }
        /// <summary> Contains the reference to the add-on that contains charts to deploy CRDs and operators. </summary>
        public IList<ResourceIdentifier> ClusterExtensionIds { get; }
        /// <summary> Display name for the Custom Locations location. </summary>
        public string DisplayName { get; set; }
        /// <summary> Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions. </summary>
        public ResourceIdentifier HostResourceId { get; set; }
        /// <summary> Type of host the Custom Locations is referencing (Kubernetes, etc...). </summary>
        public CustomLocationHostType? HostType { get; set; }
        /// <summary> Kubernetes namespace that will be created on the specified cluster. </summary>
        public string Namespace { get; set; }
        /// <summary> Provisioning State for the Custom Location. </summary>
        public string ProvisioningState { get; set; }
    }
}
