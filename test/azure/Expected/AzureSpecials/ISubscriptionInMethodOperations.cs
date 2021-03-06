// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.AzureSpecials
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SubscriptionInMethodOperations operations.
    /// </summary>
    public partial interface ISubscriptionInMethodOperations
    {
        /// <summary>
        /// POST method with subscriptionId modeled in the method.  pass in
        /// subscription id = '1234-5678-9012-3456' to succeed
        /// </summary>
        /// <param name='subscriptionId'>
        /// This should appear as a method parameter, use value
        /// '1234-5678-9012-3456'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PostMethodLocalValidWithHttpMessagesAsync(string subscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// POST method with subscriptionId modeled in the method.  pass in
        /// subscription id = null, client-side validation should prevent you
        /// from making this call
        /// </summary>
        /// <param name='subscriptionId'>
        /// This should appear as a method parameter, use value null,
        /// client-side validation should prvenet the call
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PostMethodLocalNullWithHttpMessagesAsync(string subscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// POST method with subscriptionId modeled in the method.  pass in
        /// subscription id = '1234-5678-9012-3456' to succeed
        /// </summary>
        /// <param name='subscriptionId'>
        /// Should appear as a method parameter -use value
        /// '1234-5678-9012-3456'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PostPathLocalValidWithHttpMessagesAsync(string subscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// POST method with subscriptionId modeled in the method.  pass in
        /// subscription id = '1234-5678-9012-3456' to succeed
        /// </summary>
        /// <param name='subscriptionId'>
        /// The subscriptionId, which appears in the path, the value is always
        /// '1234-5678-9012-3456'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PostSwaggerLocalValidWithHttpMessagesAsync(string subscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
