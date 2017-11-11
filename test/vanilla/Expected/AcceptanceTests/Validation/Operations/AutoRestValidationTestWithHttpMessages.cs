// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsValidation
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AutoRestValidationTest operations.
    /// </summary>
    public partial class AutoRestValidationTestWithHttpMessages : IServiceOperations<AutoRestValidationTest>, IAutoRestValidationTestWithHttpMessages
    {
        /// <summary>
        /// Initializes a new instance of the AutoRestValidationTest class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public AutoRestValidationTestWithHttpMessages(AutoRestValidationTest client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException(nameof(client));
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the AutoRestValidationTest.
        /// </summary>
        public AutoRestValidationTest Client { get; private set; }

        /// <summary>
        /// Validates input parameters on the method. See swagger for details.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
        /// </param>
        /// <param name='id'>
        /// Required int multiple of 10 from 100 to 1000.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='ErrorException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Product>> ValidationOfMethodParametersAsync(string resourceGroupName, int id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (Client.SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, nameof(Client.SubscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, nameof(resourceGroupName));
            }
            if (resourceGroupName != null)
            {
                if (resourceGroupName.Length > 10)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "resourceGroupName", 10);
                }
                if (resourceGroupName.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "resourceGroupName", 3);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(resourceGroupName, "[a-zA-Z0-9]+"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "resourceGroupName", "[a-zA-Z0-9]+");
                }
            }
            if (id > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "id", 1000);
            }
            if (id < 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "id", 100);
            }
            if (id % 10 != 0)
            {
                throw new ValidationException(ValidationRules.MultipleOf, "id", 10);
            }
            if (Client.ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, nameof(Client.ApiVersion));
            }
            if (Client.ApiVersion != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Client.ApiVersion, "\\d{2}-\\d{2}-\\d{4}"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Client.ApiVersion", "\\d{2}-\\d{2}-\\d{4}");
                }
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("id", id);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "ValidationOfMethodParameters", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            string _url = new System.Uri(new System.Uri(_baseUrl.TrimEnd('/') + "/"), "fakepath/{subscriptionId}/{resourceGroupName}/{id}").ToString();
            _url = _url.Replace("{subscriptionId}", System.Uri.EscapeDataString(Client.SubscriptionId));
            _url = _url.Replace("{resourceGroupName}", System.Uri.EscapeDataString(resourceGroupName));
            _url = _url.Replace("{id}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(id, Client.SerializationSettings).Trim('"')));
            List<string> _queryParameters = new List<string>();
            if (Client.ApiVersion != null)
            {
                _queryParameters.Add(string.Format("apiVersion={0}", System.Uri.EscapeDataString(Client.ApiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach (var _header in customHeaders)
                {
                    _httpRequest.Headers.Remove(_header.Key);
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<Product>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Product>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Validates body parameters on the method. See swagger for details.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
        /// </param>
        /// <param name='id'>
        /// Required int multiple of 10 from 100 to 1000.
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='ErrorException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Product>> ValidationOfBodyAsync(string resourceGroupName, int id, Product body = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (Client.SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, nameof(Client.SubscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, nameof(resourceGroupName));
            }
            if (resourceGroupName != null)
            {
                if (resourceGroupName.Length > 10)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "resourceGroupName", 10);
                }
                if (resourceGroupName.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "resourceGroupName", 3);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(resourceGroupName, "[a-zA-Z0-9]+"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "resourceGroupName", "[a-zA-Z0-9]+");
                }
            }
            if (id > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "id", 1000);
            }
            if (id < 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "id", 100);
            }
            if (id % 10 != 0)
            {
                throw new ValidationException(ValidationRules.MultipleOf, "id", 10);
            }
            if (body != null)
            {
                body.Validate();
            }
            if (Client.ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, nameof(Client.ApiVersion));
            }
            if (Client.ApiVersion != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Client.ApiVersion, "\\d{2}-\\d{2}-\\d{4}"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Client.ApiVersion", "\\d{2}-\\d{2}-\\d{4}");
                }
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("id", id);
                tracingParameters.Add("body", body);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "ValidationOfBody", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            string _url = new System.Uri(new System.Uri(_baseUrl.TrimEnd('/') + "/"), "fakepath/{subscriptionId}/{resourceGroupName}/{id}").ToString();
            _url = _url.Replace("{subscriptionId}", System.Uri.EscapeDataString(Client.SubscriptionId));
            _url = _url.Replace("{resourceGroupName}", System.Uri.EscapeDataString(resourceGroupName));
            _url = _url.Replace("{id}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(id, Client.SerializationSettings).Trim('"')));
            List<string> _queryParameters = new List<string>();
            if (Client.ApiVersion != null)
            {
                _queryParameters.Add(string.Format("apiVersion={0}", System.Uri.EscapeDataString(Client.ApiVersion)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("PUT");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach (var _header in customHeaders)
                {
                    _httpRequest.Headers.Remove(_header.Key);
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if (body != null)
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(body, Client.SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<Product>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Product>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='HttpOperationException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse> GetWithConstantInPathAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            string constantParam = "constant";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("constantParam", constantParam);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetWithConstantInPath", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            string _url = new System.Uri(new System.Uri(_baseUrl.TrimEnd('/') + "/"), "validation/constantsInPath/{constantParam}/value").ToString();
            _url = _url.Replace("{constantParam}", System.Uri.EscapeDataString(constantParam));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach (var _header in customHeaders)
                {
                    _httpRequest.Headers.Remove(_header.Key);
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null)
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else
                {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='HttpOperationException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Product>> PostWithConstantInBodyAsync(Product body = default(Product), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (body != null)
            {
                body.Validate();
            }
            string constantParam = "constant";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("constantParam", constantParam);
                tracingParameters.Add("body", body);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "PostWithConstantInBody", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            string _url = new System.Uri(new System.Uri(_baseUrl.TrimEnd('/') + "/"), "validation/constantsInPath/{constantParam}/value").ToString();
            _url = _url.Replace("{constantParam}", System.Uri.EscapeDataString(constantParam));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach (var _header in customHeaders)
                {
                    _httpRequest.Headers.Remove(_header.Key);
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if (body != null)
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(body, Client.SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null)
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else
                {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<Product>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Product>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}