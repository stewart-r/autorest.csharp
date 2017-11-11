// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsAzureCompositeModelClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BasicOperations operations.
    /// </summary>
    public partial interface IBasicOperations
    {
        IBasicOperationsWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Get complex type {id: 2, name: 'abc', color: 'YELLOW'}
        /// </summary>
        BasicInner GetValid();

        /// <summary>
        /// Get complex type {id: 2, name: 'abc', color: 'YELLOW'}
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<BasicInner> GetValidAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Please put {id: 2, name: 'abc', color: 'Magenta'}
        /// </summary>
        /// <param name='complexBody'>
        /// Please put {id: 2, name: 'abc', color: 'Magenta'}
        /// </param>
        void PutValid(BasicInner complexBody);

        /// <summary>
        /// Please put {id: 2, name: 'abc', color: 'Magenta'}
        /// </summary>
        /// <param name='complexBody'>
        /// Please put {id: 2, name: 'abc', color: 'Magenta'}
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PutValidAsync(BasicInner complexBody, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a basic complex type that is invalid for the local strong type
        /// </summary>
        BasicInner GetInvalid();

        /// <summary>
        /// Get a basic complex type that is invalid for the local strong type
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<BasicInner> GetInvalidAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a basic complex type that is empty
        /// </summary>
        BasicInner GetEmpty();

        /// <summary>
        /// Get a basic complex type that is empty
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<BasicInner> GetEmptyAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a basic complex type whose properties are null
        /// </summary>
        BasicInner GetNull();

        /// <summary>
        /// Get a basic complex type whose properties are null
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<BasicInner> GetNullAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a basic complex type while the server doesn't provide a response payload
        /// </summary>
        BasicInner GetNotProvided();

        /// <summary>
        /// Get a basic complex type while the server doesn't provide a response payload
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<BasicInner> GetNotProvidedAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}