// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The authentication mode which the Batch service will use to manage the auto-storage account. </summary>
    public enum AutoStorageAuthenticationMode
    {
        /// <summary> The Batch service will authenticate requests to auto-storage using storage account keys. </summary>
        StorageKeys,
        /// <summary> The Batch service will authenticate requests to auto-storage using the managed identity assigned to the Batch account. </summary>
        BatchAccountManagedIdentity
    }
}
