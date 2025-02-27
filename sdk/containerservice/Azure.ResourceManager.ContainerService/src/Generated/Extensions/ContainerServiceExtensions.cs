// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ContainerService. </summary>
    public static partial class ContainerServiceExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets a list of managed clusters in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/managedClusters
        /// Operation Id: ManagedClusters_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedClusterResource> GetManagedClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of managed clusters in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/managedClusters
        /// Operation Id: ManagedClusters_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedClusterResource> GetManagedClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedClusters(cancellationToken);
        }

        /// <summary>
        /// Gets a list of snapshots in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/snapshots
        /// Operation Id: Snapshots_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AgentPoolSnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AgentPoolSnapshotResource> GetAgentPoolSnapshotsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAgentPoolSnapshotsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of snapshots in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/snapshots
        /// Operation Id: Snapshots_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AgentPoolSnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AgentPoolSnapshotResource> GetAgentPoolSnapshots(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAgentPoolSnapshots(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ManagedClusterResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ManagedClusterResources and their operations over a ManagedClusterResource. </returns>
        public static ManagedClusterCollection GetManagedClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetManagedClusters();
        }

        /// <summary>
        /// Gets a managed cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
        /// Operation Id: ManagedClusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedClusterResource>> GetManagedClusterAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetManagedClusters().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a managed cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
        /// Operation Id: ManagedClusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedClusterResource> GetManagedCluster(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetManagedClusters().Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of AgentPoolSnapshotResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AgentPoolSnapshotResources and their operations over a AgentPoolSnapshotResource. </returns>
        public static AgentPoolSnapshotCollection GetAgentPoolSnapshots(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetAgentPoolSnapshots();
        }

        /// <summary>
        /// Gets a snapshot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/snapshots/{resourceName}
        /// Operation Id: Snapshots_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AgentPoolSnapshotResource>> GetAgentPoolSnapshotAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetAgentPoolSnapshots().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a snapshot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/snapshots/{resourceName}
        /// Operation Id: Snapshots_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AgentPoolSnapshotResource> GetAgentPoolSnapshot(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetAgentPoolSnapshots().Get(resourceName, cancellationToken);
        }

        #region OSOptionProfileResource
        /// <summary>
        /// Gets an object representing an <see cref="OSOptionProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OSOptionProfileResource.CreateResourceIdentifier" /> to create an <see cref="OSOptionProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OSOptionProfileResource" /> object. </returns>
        public static OSOptionProfileResource GetOSOptionProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OSOptionProfileResource.ValidateResourceId(id);
                return new OSOptionProfileResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedClusterUpgradeProfileResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedClusterUpgradeProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedClusterUpgradeProfileResource.CreateResourceIdentifier" /> to create a <see cref="ManagedClusterUpgradeProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedClusterUpgradeProfileResource" /> object. </returns>
        public static ManagedClusterUpgradeProfileResource GetManagedClusterUpgradeProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedClusterUpgradeProfileResource.ValidateResourceId(id);
                return new ManagedClusterUpgradeProfileResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedClusterResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ManagedClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedClusterResource" /> object. </returns>
        public static ManagedClusterResource GetManagedClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedClusterResource.ValidateResourceId(id);
                return new ManagedClusterResource(client, id);
            }
            );
        }
        #endregion

        #region MaintenanceConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="MaintenanceConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MaintenanceConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="MaintenanceConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MaintenanceConfigurationResource" /> object. </returns>
        public static MaintenanceConfigurationResource GetMaintenanceConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MaintenanceConfigurationResource.ValidateResourceId(id);
                return new MaintenanceConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region AgentPoolResource
        /// <summary>
        /// Gets an object representing an <see cref="AgentPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgentPoolResource.CreateResourceIdentifier" /> to create an <see cref="AgentPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgentPoolResource" /> object. </returns>
        public static AgentPoolResource GetAgentPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AgentPoolResource.ValidateResourceId(id);
                return new AgentPoolResource(client, id);
            }
            );
        }
        #endregion

        #region AgentPoolUpgradeProfileResource
        /// <summary>
        /// Gets an object representing an <see cref="AgentPoolUpgradeProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgentPoolUpgradeProfileResource.CreateResourceIdentifier" /> to create an <see cref="AgentPoolUpgradeProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgentPoolUpgradeProfileResource" /> object. </returns>
        public static AgentPoolUpgradeProfileResource GetAgentPoolUpgradeProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AgentPoolUpgradeProfileResource.ValidateResourceId(id);
                return new AgentPoolUpgradeProfileResource(client, id);
            }
            );
        }
        #endregion

        #region ContainerServicePrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="ContainerServicePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerServicePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="ContainerServicePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerServicePrivateEndpointConnectionResource" /> object. </returns>
        public static ContainerServicePrivateEndpointConnectionResource GetContainerServicePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContainerServicePrivateEndpointConnectionResource.ValidateResourceId(id);
                return new ContainerServicePrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region AgentPoolSnapshotResource
        /// <summary>
        /// Gets an object representing an <see cref="AgentPoolSnapshotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgentPoolSnapshotResource.CreateResourceIdentifier" /> to create an <see cref="AgentPoolSnapshotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgentPoolSnapshotResource" /> object. </returns>
        public static AgentPoolSnapshotResource GetAgentPoolSnapshotResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AgentPoolSnapshotResource.ValidateResourceId(id);
                return new AgentPoolSnapshotResource(client, id);
            }
            );
        }
        #endregion
    }
}
