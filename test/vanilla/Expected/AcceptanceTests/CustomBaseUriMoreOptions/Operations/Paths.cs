// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsCustomBaseUriMoreOptions
{
    using Microsoft.Rest;
    using Models;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Paths operations.
    /// </summary>
    public partial class Paths : IPaths
    {
        /// <summary>
        /// Initializes a new instance of the Paths class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public Paths(IPathsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IPathsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IPathsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Get a 200 to test a valid base uri
        /// </summary>
        /// <param name='vault'>
        /// The vault name, e.g. https://myvault
        /// </param>
        /// <param name='secret'>
        /// Secret value.
        /// </param>
        /// <param name='keyName'>
        /// The key name with value 'key1'.
        /// </param>
        /// <param name='keyVersion'>
        /// The key version. Default value 'v1'.
        /// </param>
        public void GetEmpty(string vault, string secret, string keyName, string keyVersion = "v1")
        {
            GetEmptyAsync(vault, secret, keyName, keyVersion).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a 200 to test a valid base uri
        /// </summary>
        /// <param name='vault'>
        /// The vault name, e.g. https://myvault
        /// </param>
        /// <param name='secret'>
        /// Secret value.
        /// </param>
        /// <param name='keyName'>
        /// The key name with value 'key1'.
        /// </param>
        /// <param name='keyVersion'>
        /// The key version. Default value 'v1'.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetEmptyAsync(string vault, string secret, string keyName, string keyVersion = "v1", CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetEmptyAsync(vault, secret, keyName, keyVersion, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}