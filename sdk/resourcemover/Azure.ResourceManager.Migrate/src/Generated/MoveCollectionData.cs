// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Migrate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Migrate
{
    /// <summary> A class representing the MoveCollection data model. </summary>
    public partial class MoveCollectionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of MoveCollectionData. </summary>
        /// <param name="location"> The location. </param>
        public MoveCollectionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of MoveCollectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The etag of the resource. </param>
        /// <param name="identity"> Defines the MSI properties of the Move Collection. </param>
        /// <param name="properties"> Defines the move collection properties. </param>
        internal MoveCollectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, Identity identity, MoveCollectionProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            Identity = identity;
            Properties = properties;
        }

        /// <summary> The etag of the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Defines the MSI properties of the Move Collection. </summary>
        public Identity Identity { get; set; }
        /// <summary> Defines the move collection properties. </summary>
        public MoveCollectionProperties Properties { get; set; }
    }
}
