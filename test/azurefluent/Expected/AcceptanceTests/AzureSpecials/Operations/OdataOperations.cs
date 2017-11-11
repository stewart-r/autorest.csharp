// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsAzureSpecials
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// OdataOperations operations.
    /// </summary>
    public partial class OdataOperations : IOdataOperations
    {
        /// <summary>
        /// Initializes a new instance of the OdataOperations class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public OdataOperations(IOdataOperationsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IOdataOperationsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IOdataOperationsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Specify filter parameter with value '$filter=id gt 5 and name eq 'foo'&amp;$orderby=id&amp;$top=10'
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        public void GetWithFilter(ODataQuery<OdataFilterInner> odataQuery = default(ODataQuery<OdataFilterInner>))
        {
            GetWithFilterAsync(odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Specify filter parameter with value '$filter=id gt 5 and name eq 'foo'&amp;$orderby=id&amp;$top=10'
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetWithFilterAsync(ODataQuery<OdataFilterInner> odataQuery = default(ODataQuery<OdataFilterInner>), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetWithFilterAsync(odataQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}