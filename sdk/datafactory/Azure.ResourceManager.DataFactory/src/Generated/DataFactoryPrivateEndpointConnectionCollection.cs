// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="DataFactoryPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="DataFactoryPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="DataFactoryResource" />.
    /// To get a <see cref="DataFactoryPrivateEndpointConnectionCollection" /> instance call the GetDataFactoryPrivateEndpointConnections method from an instance of <see cref="DataFactoryResource" />.
    /// </summary>
    public partial class DataFactoryPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<DataFactoryPrivateEndpointConnectionResource>, IAsyncEnumerable<DataFactoryPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics;
        private readonly PrivateEndpointConnectionRestOperations _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionRestClient;
        private readonly ClientDiagnostics _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsClientDiagnostics;
        private readonly PrivateEndPointConnectionsRestOperations _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected DataFactoryPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataFactoryPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryPrivateEndpointConnectionResource.ResourceType, out string dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionApiVersion);
            _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionRestClient = new PrivateEndpointConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionApiVersion);
            _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryPrivateEndpointConnectionResource.ResourceType, out string dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsApiVersion);
            _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsRestClient = new PrivateEndPointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataFactoryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataFactoryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Approves or rejects a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnection_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. </param>
        /// <param name="content"> The DataFactoryPrivateEndpointConnectionCreateOrUpdateContent to use. </param>
        /// <param name="ifMatch"> ETag of the private endpoint connection entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, DataFactoryPrivateEndpointConnectionCreateOrUpdateContent content, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryPrivateEndpointConnectionResource>(Response.FromValue(new DataFactoryPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Approves or rejects a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnection_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. </param>
        /// <param name="content"> The DataFactoryPrivateEndpointConnectionCreateOrUpdateContent to use. </param>
        /// <param name="ifMatch"> ETag of the private endpoint connection entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DataFactoryPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, DataFactoryPrivateEndpointConnectionCreateOrUpdateContent content, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, content, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryPrivateEndpointConnectionResource>(Response.FromValue(new DataFactoryPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnection_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. </param>
        /// <param name="ifNoneMatch"> ETag of the private endpoint connection entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<DataFactoryPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnection_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. </param>
        /// <param name="ifNoneMatch"> ETag of the private endpoint connection entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<DataFactoryPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Private endpoint connections
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/privateEndPointConnections
        /// Operation Id: privateEndPointConnections_ListByFactory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryPrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataFactoryPrivateEndpointConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsRestClient.ListByFactoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataFactoryPrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataFactoryPrivateEndpointConnectionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsRestClient.ListByFactoryNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataFactoryPrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists Private endpoint connections
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/privateEndPointConnections
        /// Operation Id: privateEndPointConnections_ListByFactory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryPrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataFactoryPrivateEndpointConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsRestClient.ListByFactory(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataFactoryPrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataFactoryPrivateEndpointConnectionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataFactoryPrivateEndpointConnectionprivateEndPointConnectionsRestClient.ListByFactoryNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataFactoryPrivateEndpointConnectionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnection_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. </param>
        /// <param name="ifNoneMatch"> ETag of the private endpoint connection entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnection_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The private endpoint connection name. </param>
        /// <param name="ifNoneMatch"> ETag of the private endpoint connection entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionClientDiagnostics.CreateScope("DataFactoryPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataFactoryPrivateEndpointConnectionPrivateEndpointConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, ifNoneMatch, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataFactoryPrivateEndpointConnectionResource> IEnumerable<DataFactoryPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataFactoryPrivateEndpointConnectionResource> IAsyncEnumerable<DataFactoryPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
