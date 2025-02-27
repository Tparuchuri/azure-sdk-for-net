// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A Class representing a DeletedConfigurationStore along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DeletedConfigurationStoreResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDeletedConfigurationStoreResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetDeletedConfigurationStore method.
    /// </summary>
    public partial class DeletedConfigurationStoreResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeletedConfigurationStoreResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string configStoreName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deletedConfigurationStoreConfigurationStoresClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _deletedConfigurationStoreConfigurationStoresRestClient;
        private readonly DeletedConfigurationStoreData _data;

        /// <summary> Initializes a new instance of the <see cref="DeletedConfigurationStoreResource"/> class for mocking. </summary>
        protected DeletedConfigurationStoreResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DeletedConfigurationStoreResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeletedConfigurationStoreResource(ArmClient client, DeletedConfigurationStoreData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedConfigurationStoreResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeletedConfigurationStoreResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedConfigurationStoreConfigurationStoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deletedConfigurationStoreConfigurationStoresApiVersion);
            _deletedConfigurationStoreConfigurationStoresRestClient = new ConfigurationStoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedConfigurationStoreConfigurationStoresApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppConfiguration/locations/deletedConfigurationStores";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeletedConfigurationStoreData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeletedConfigurationStoreResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.Get");
            scope.Start();
            try
            {
                var response = await _deletedConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedConfigurationStoreResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.Get");
            scope.Start();
            try
            {
                var response = _deletedConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Permanently deletes the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}/purge
        /// Operation Id: ConfigurationStores_PurgeDeleted
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> PurgeDeletedAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.PurgeDeleted");
            scope.Start();
            try
            {
                var response = await _deletedConfigurationStoreConfigurationStoresRestClient.PurgeDeletedAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation(_deletedConfigurationStoreConfigurationStoresClientDiagnostics, Pipeline, _deletedConfigurationStoreConfigurationStoresRestClient.CreatePurgeDeletedRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Permanently deletes the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}/purge
        /// Operation Id: ConfigurationStores_PurgeDeleted
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation PurgeDeleted(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.PurgeDeleted");
            scope.Start();
            try
            {
                var response = _deletedConfigurationStoreConfigurationStoresRestClient.PurgeDeleted(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                var operation = new AppConfigurationArmOperation(_deletedConfigurationStoreConfigurationStoresClientDiagnostics, Pipeline, _deletedConfigurationStoreConfigurationStoresRestClient.CreatePurgeDeletedRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<DeletedConfigurationStoreResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _deletedConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<DeletedConfigurationStoreResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _deletedConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<DeletedConfigurationStoreResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _deletedConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<DeletedConfigurationStoreResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _deletedConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<DeletedConfigurationStoreResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _deletedConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<DeletedConfigurationStoreResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _deletedConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
