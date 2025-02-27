// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

[assembly: CodeGenSuppressType("CassandraClusterData")]
namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing the CassandraCluster data model. </summary>
    public partial class CassandraClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of CassandraClusterData. </summary>
        /// <param name="location"> The location. </param>
        public CassandraClusterData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of CassandraClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of a managed Cassandra cluster. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned, None.</param>
        internal CassandraClusterData(ResourceIdentifier id, string name, ResourceType resourceType, ResourceManager.Models.SystemData systemData, IDictionary<string, string> tags, AzureLocation location, CassandraClusterProperties properties, ResourceManager.Models.ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            Identity = identity;
        }

        /// <summary> Properties of a managed Cassandra cluster. </summary>
        public CassandraClusterProperties Properties { get; set; }
        /// <summary> Identity for the resource. Current supported identity types: SystemAssigned, None.</summary>
        public ResourceManager.Models.ManagedServiceIdentity Identity { get; set; }
    }
}
