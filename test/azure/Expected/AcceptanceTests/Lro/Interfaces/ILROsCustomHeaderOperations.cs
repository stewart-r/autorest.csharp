// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsLro
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// LROsCustomHeaderOperations operations.
    /// </summary>
    public partial interface ILROsCustomHeaderOperations
    {
        ILROsCustomHeaderOperationsWithHttpMessages WithHttpMessages();

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running put request, service returns a 200 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        Product PutAsyncRetrySucceeded(Product product = default(Product));

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running put request, service returns a 200 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Product> PutAsyncRetrySucceededAsync(Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running put request, service returns a 201 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        Product Put201CreatingSucceeded200(Product product = default(Product));

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running put request, service returns a 201 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Product> Put201CreatingSucceeded200Async(Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running post request, service returns a 202 to the initial request, with 'Location' and 'Retry-After' headers,
        /// Polls return a 200 with a response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        LROsCustomHeaderPost202Retry200Headers Post202Retry200(Product product = default(Product));

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running post request, service returns a 202 to the initial request, with 'Location' and 'Retry-After' headers,
        /// Polls return a 200 with a response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LROsCustomHeaderPost202Retry200Headers> Post202Retry200Async(Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running post request, service returns a 202 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        LROsCustomHeaderPostAsyncRetrySucceededHeaders PostAsyncRetrySucceeded(Product product = default(Product));

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running post request, service returns a 202 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LROsCustomHeaderPostAsyncRetrySucceededHeaders> PostAsyncRetrySucceededAsync(Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running put request, service returns a 200 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        Product BeginPutAsyncRetrySucceeded(Product product = default(Product));

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running put request, service returns a 200 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Product> BeginPutAsyncRetrySucceededAsync(Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running put request, service returns a 201 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        Product BeginPut201CreatingSucceeded200(Product product = default(Product));

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running put request, service returns a 201 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Product> BeginPut201CreatingSucceeded200Async(Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running post request, service returns a 202 to the initial request, with 'Location' and 'Retry-After' headers,
        /// Polls return a 200 with a response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        LROsCustomHeaderPost202Retry200Headers BeginPost202Retry200(Product product = default(Product));

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running post request, service returns a 202 to the initial request, with 'Location' and 'Retry-After' headers,
        /// Polls return a 200 with a response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LROsCustomHeaderPost202Retry200Headers> BeginPost202Retry200Async(Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running post request, service returns a 202 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        LROsCustomHeaderPostAsyncRetrySucceededHeaders BeginPostAsyncRetrySucceeded(Product product = default(Product));

        /// <summary>
        /// x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 is required message header for all requests. Long
        /// running post request, service returns a 202 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LROsCustomHeaderPostAsyncRetrySucceededHeaders> BeginPostAsyncRetrySucceededAsync(Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken));
    }
}