// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.VoiceServices
{
    /// <summary>
    /// A class representing a collection of <see cref="TestLineResource" /> and their operations.
    /// Each <see cref="TestLineResource" /> in the collection will belong to the same instance of <see cref="CommunicationsGatewayResource" />.
    /// To get a <see cref="TestLineCollection" /> instance call the GetTestLines method from an instance of <see cref="CommunicationsGatewayResource" />.
    /// </summary>
    public partial class TestLineCollection : ArmCollection, IEnumerable<TestLineResource>, IAsyncEnumerable<TestLineResource>
    {
        private readonly ClientDiagnostics _testLineClientDiagnostics;
        private readonly TestLinesRestOperations _testLineRestClient;

        /// <summary> Initializes a new instance of the <see cref="TestLineCollection"/> class for mocking. </summary>
        protected TestLineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TestLineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TestLineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _testLineClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.VoiceServices", TestLineResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TestLineResource.ResourceType, out string testLineApiVersion);
            _testLineRestClient = new TestLinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, testLineApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CommunicationsGatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CommunicationsGatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a TestLine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TestLineResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string testLineName, TestLineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(testLineName, nameof(testLineName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _testLineClientDiagnostics.CreateScope("TestLineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _testLineRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, data, cancellationToken).ConfigureAwait(false);
                var operation = new VoiceServicesArmOperation<TestLineResource>(new TestLineOperationSource(Client), _testLineClientDiagnostics, Pipeline, _testLineRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a TestLine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TestLineResource> CreateOrUpdate(WaitUntil waitUntil, string testLineName, TestLineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(testLineName, nameof(testLineName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _testLineClientDiagnostics.CreateScope("TestLineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _testLineRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, data, cancellationToken);
                var operation = new VoiceServicesArmOperation<TestLineResource>(new TestLineOperationSource(Client), _testLineClientDiagnostics, Pipeline, _testLineRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a TestLine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual async Task<Response<TestLineResource>> GetAsync(string testLineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(testLineName, nameof(testLineName));

            using var scope = _testLineClientDiagnostics.CreateScope("TestLineCollection.Get");
            scope.Start();
            try
            {
                var response = await _testLineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TestLineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a TestLine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual Response<TestLineResource> Get(string testLineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(testLineName, nameof(testLineName));

            using var scope = _testLineClientDiagnostics.CreateScope("TestLineCollection.Get");
            scope.Start();
            try
            {
                var response = _testLineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TestLineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List TestLine resources by CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_ListByCommunicationsGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TestLineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TestLineResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _testLineRestClient.CreateListByCommunicationsGatewayRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _testLineRestClient.CreateListByCommunicationsGatewayNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TestLineResource(Client, TestLineData.DeserializeTestLineData(e)), _testLineClientDiagnostics, Pipeline, "TestLineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List TestLine resources by CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_ListByCommunicationsGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TestLineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TestLineResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _testLineRestClient.CreateListByCommunicationsGatewayRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _testLineRestClient.CreateListByCommunicationsGatewayNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TestLineResource(Client, TestLineData.DeserializeTestLineData(e)), _testLineClientDiagnostics, Pipeline, "TestLineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string testLineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(testLineName, nameof(testLineName));

            using var scope = _testLineClientDiagnostics.CreateScope("TestLineCollection.Exists");
            scope.Start();
            try
            {
                var response = await _testLineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual Response<bool> Exists(string testLineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(testLineName, nameof(testLineName));

            using var scope = _testLineClientDiagnostics.CreateScope("TestLineCollection.Exists");
            scope.Start();
            try
            {
                var response = _testLineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TestLineResource> IEnumerable<TestLineResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TestLineResource> IAsyncEnumerable<TestLineResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
