// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsLro
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Long-running Operation for AutoRest
    /// </summary>
    public partial interface IAutoRestLongRunningOperationTestService : System.IDisposable
    {
        /// <summary>
        /// Gets or sets the base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets JSON serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets JSON deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the ILROsOperations.
        /// </summary>
        ILROsOperations LROs { get; }

        /// <summary>
        /// Gets the ILRORetrysOperations.
        /// </summary>
        ILRORetrysOperations LRORetrys { get; }

        /// <summary>
        /// Gets the ILROSADsOperations.
        /// </summary>
        ILROSADsOperations LROSADs { get; }

        /// <summary>
        /// Gets the ILROsCustomHeaderOperations.
        /// </summary>
        ILROsCustomHeaderOperations LROsCustomHeader { get; }

    }
}