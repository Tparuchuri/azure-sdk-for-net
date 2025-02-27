// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary> A class representing the BatchAccount data model. </summary>
    public partial class BatchAccountData : ResourceData
    {
        /// <summary> Initializes a new instance of BatchAccountData. </summary>
        internal BatchAccountData()
        {
            PrivateEndpointConnections = new ChangeTrackingList<BatchPrivateEndpointConnectionData>();
            DedicatedCoreQuotaPerVmFamily = new ChangeTrackingList<VirtualMachineFamilyCoreQuota>();
            AllowedAuthenticationModes = new ChangeTrackingList<AuthenticationMode>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of BatchAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The identity of the Batch account. </param>
        /// <param name="accountEndpoint"> The account endpoint used to interact with the Batch service. </param>
        /// <param name="nodeManagementEndpoint"> The endpoint used by compute node to connect to the Batch node management service. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="poolAllocationMode"> The allocation mode for creating pools in the Batch account. </param>
        /// <param name="keyVaultReference"> Identifies the Azure key vault associated with a Batch account. </param>
        /// <param name="publicNetworkAccess"> If not specified, the default value is &apos;enabled&apos;. </param>
        /// <param name="networkProfile"> The network profile only takes effect when publicNetworkAccess is enabled. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the Batch account. </param>
        /// <param name="autoStorage"> Contains information about the auto-storage account associated with a Batch account. </param>
        /// <param name="encryption"> Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft managed key. For additional control, a customer-managed key can be used instead. </param>
        /// <param name="dedicatedCoreQuota"> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="lowPriorityCoreQuota"> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="dedicatedCoreQuotaPerVmFamily"> A list of the dedicated core quota per Virtual Machine family for the Batch account. For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </param>
        /// <param name="dedicatedCoreQuotaPerVmFamilyEnforced"> If this flag is true, dedicated core quota is enforced via both the dedicatedCoreQuotaPerVMFamily and dedicatedCoreQuota properties on the account. If this flag is false, dedicated core quota is enforced only via the dedicatedCoreQuota property on the account and does not consider Virtual Machine family. </param>
        /// <param name="poolQuota"> The pool quota for the Batch account. </param>
        /// <param name="activeJobAndJobScheduleQuota"> The active job and job schedule quota for the Batch account. </param>
        /// <param name="allowedAuthenticationModes"> List of allowed authentication modes for the Batch account that can be used to authenticate with the data plane. This does not affect authentication with the control plane. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="tags"> The tags of the resource. </param>
        internal BatchAccountData(ResourceIdentifier id, string name, Core.ResourceType resourceType, SystemData systemData, BatchAccountIdentity identity, string accountEndpoint, string nodeManagementEndpoint, ProvisioningState? provisioningState, PoolAllocationMode? poolAllocationMode, KeyVaultReference keyVaultReference, PublicNetworkAccessType? publicNetworkAccess, BatchVirtualMachineNetworkProfile networkProfile, IReadOnlyList<BatchPrivateEndpointConnectionData> privateEndpointConnections, AutoStorageProperties autoStorage, Models.EncryptionProperties encryption, int? dedicatedCoreQuota, int? lowPriorityCoreQuota, IReadOnlyList<VirtualMachineFamilyCoreQuota> dedicatedCoreQuotaPerVmFamily, bool? dedicatedCoreQuotaPerVmFamilyEnforced, int? poolQuota, int? activeJobAndJobScheduleQuota, IReadOnlyList<AuthenticationMode> allowedAuthenticationModes, AzureLocation? location, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            AccountEndpoint = accountEndpoint;
            NodeManagementEndpoint = nodeManagementEndpoint;
            ProvisioningState = provisioningState;
            PoolAllocationMode = poolAllocationMode;
            KeyVaultReference = keyVaultReference;
            PublicNetworkAccess = publicNetworkAccess;
            NetworkProfile = networkProfile;
            PrivateEndpointConnections = privateEndpointConnections;
            AutoStorage = autoStorage;
            Encryption = encryption;
            DedicatedCoreQuota = dedicatedCoreQuota;
            LowPriorityCoreQuota = lowPriorityCoreQuota;
            DedicatedCoreQuotaPerVmFamily = dedicatedCoreQuotaPerVmFamily;
            DedicatedCoreQuotaPerVmFamilyEnforced = dedicatedCoreQuotaPerVmFamilyEnforced;
            PoolQuota = poolQuota;
            ActiveJobAndJobScheduleQuota = activeJobAndJobScheduleQuota;
            AllowedAuthenticationModes = allowedAuthenticationModes;
            Location = location;
            Tags = tags;
        }

        /// <summary> The identity of the Batch account. </summary>
        public BatchAccountIdentity Identity { get; }
        /// <summary> The account endpoint used to interact with the Batch service. </summary>
        public string AccountEndpoint { get; }
        /// <summary> The endpoint used by compute node to connect to the Batch node management service. </summary>
        public string NodeManagementEndpoint { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The allocation mode for creating pools in the Batch account. </summary>
        public PoolAllocationMode? PoolAllocationMode { get; }
        /// <summary> Identifies the Azure key vault associated with a Batch account. </summary>
        public KeyVaultReference KeyVaultReference { get; }
        /// <summary> If not specified, the default value is &apos;enabled&apos;. </summary>
        public PublicNetworkAccessType? PublicNetworkAccess { get; }
        /// <summary> The network profile only takes effect when publicNetworkAccess is enabled. </summary>
        public BatchVirtualMachineNetworkProfile NetworkProfile { get; }
        /// <summary> List of private endpoint connections associated with the Batch account. </summary>
        public IReadOnlyList<BatchPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Contains information about the auto-storage account associated with a Batch account. </summary>
        public AutoStorageProperties AutoStorage { get; }
        /// <summary> Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft managed key. For additional control, a customer-managed key can be used instead. </summary>
        public Models.EncryptionProperties Encryption { get; }
        /// <summary> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </summary>
        public int? DedicatedCoreQuota { get; }
        /// <summary> For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </summary>
        public int? LowPriorityCoreQuota { get; }
        /// <summary> A list of the dedicated core quota per Virtual Machine family for the Batch account. For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not returned. </summary>
        public IReadOnlyList<VirtualMachineFamilyCoreQuota> DedicatedCoreQuotaPerVmFamily { get; }
        /// <summary> If this flag is true, dedicated core quota is enforced via both the dedicatedCoreQuotaPerVMFamily and dedicatedCoreQuota properties on the account. If this flag is false, dedicated core quota is enforced only via the dedicatedCoreQuota property on the account and does not consider Virtual Machine family. </summary>
        public bool? DedicatedCoreQuotaPerVmFamilyEnforced { get; }
        /// <summary> The pool quota for the Batch account. </summary>
        public int? PoolQuota { get; }
        /// <summary> The active job and job schedule quota for the Batch account. </summary>
        public int? ActiveJobAndJobScheduleQuota { get; }
        /// <summary> List of allowed authentication modes for the Batch account that can be used to authenticate with the data plane. This does not affect authentication with the control plane. </summary>
        public IReadOnlyList<AuthenticationMode> AllowedAuthenticationModes { get; }
        /// <summary> The location of the resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The tags of the resource. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
