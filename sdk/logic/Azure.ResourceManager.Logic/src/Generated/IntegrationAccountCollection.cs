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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="IntegrationAccountResource" /> and their operations.
    /// Each <see cref="IntegrationAccountResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="IntegrationAccountCollection" /> instance call the GetIntegrationAccounts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class IntegrationAccountCollection : ArmCollection, IEnumerable<IntegrationAccountResource>, IAsyncEnumerable<IntegrationAccountResource>
    {
        private readonly ClientDiagnostics _integrationAccountClientDiagnostics;
        private readonly IntegrationAccountsRestOperations _integrationAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountCollection"/> class for mocking. </summary>
        protected IntegrationAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IntegrationAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _integrationAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IntegrationAccountResource.ResourceType, out string integrationAccountApiVersion);
            _integrationAccountRestClient = new IntegrationAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, integrationAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an integration account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}
        /// Operation Id: IntegrationAccounts_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="data"> The integration account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationAccountName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IntegrationAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string integrationAccountName, IntegrationAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _integrationAccountRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, integrationAccountName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LogicArmOperation<IntegrationAccountResource>(Response.FromValue(new IntegrationAccountResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an integration account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}
        /// Operation Id: IntegrationAccounts_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="data"> The integration account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationAccountName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IntegrationAccountResource> CreateOrUpdate(WaitUntil waitUntil, string integrationAccountName, IntegrationAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _integrationAccountRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, integrationAccountName, data, cancellationToken);
                var operation = new LogicArmOperation<IntegrationAccountResource>(Response.FromValue(new IntegrationAccountResource(Client, response), response.GetRawResponse()));
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
        /// Gets an integration account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}
        /// Operation Id: IntegrationAccounts_Get
        /// </summary>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationAccountName"/> is null. </exception>
        public virtual async Task<Response<IntegrationAccountResource>> GetAsync(string integrationAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _integrationAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, integrationAccountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an integration account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}
        /// Operation Id: IntegrationAccounts_Get
        /// </summary>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationAccountName"/> is null. </exception>
        public virtual Response<IntegrationAccountResource> Get(string integrationAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _integrationAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, integrationAccountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of integration accounts by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts
        /// Operation Id: IntegrationAccounts_ListByResourceGroup
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationAccountResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<IntegrationAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _integrationAccountRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IntegrationAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _integrationAccountRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of integration accounts by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts
        /// Operation Id: IntegrationAccounts_ListByResourceGroup
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationAccountResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<IntegrationAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _integrationAccountRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IntegrationAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _integrationAccountRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}
        /// Operation Id: IntegrationAccounts_Get
        /// </summary>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationAccountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string integrationAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _integrationAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, integrationAccountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}
        /// Operation Id: IntegrationAccounts_Get
        /// </summary>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(string integrationAccountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var scope = _integrationAccountClientDiagnostics.CreateScope("IntegrationAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _integrationAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, integrationAccountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IntegrationAccountResource> IEnumerable<IntegrationAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IntegrationAccountResource> IAsyncEnumerable<IntegrationAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
