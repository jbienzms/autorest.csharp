// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsPaging
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PagingOperations operations.
    /// </summary>
    public partial interface IPagingOperationsWithHttpMessages
    {
        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetSinglePagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesAsync(string clientRequestId = default(string), PagingGetMultiplePagesOptionsInner pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptionsInner), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that includes a nextLink in odata format that has 10 pages
        /// </summary>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetOdataMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetOdataMultiplePagesAsync(string clientRequestId = default(string), PagingGetOdataMultiplePagesOptionsInner pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptionsInner), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='pagingGetMultiplePagesWithOffsetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesWithOffsetAsync(PagingGetMultiplePagesWithOffsetOptionsInner pagingGetMultiplePagesWithOffsetOptions, string clientRequestId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesRetryFirstAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesRetrySecondAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetSinglePagesFailureAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesFailureAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesFailureUriAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='apiVersion'>
        /// Sets the api version to use.
        /// </param>
        /// <param name='tenant'>
        /// Sets the tenant to use.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesFragmentNextLinkAsync(string apiVersion, string tenant, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment with parameters grouped
        /// </summary>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesFragmentWithGroupingNextLinkAsync(CustomParameterGroupInner customParameterGroup, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='apiVersion'>
        /// Sets the api version to use.
        /// </param>
        /// <param name='tenant'>
        /// Sets the tenant to use.
        /// </param>
        /// <param name='nextLink'>
        /// Next link for list operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> NextFragmentAsync(string apiVersion, string tenant, string nextLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='nextLink'>
        /// Next link for list operation.
        /// </param>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> NextFragmentWithGroupingAsync(string nextLink, CustomParameterGroupInner customParameterGroup, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetSinglePagesNextAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesNextAsync(string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesOptionsInner pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptionsInner), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that includes a nextLink in odata format that has 10 pages
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetOdataMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetOdataMultiplePagesNextAsync(string nextPageLink, string clientRequestId = default(string), PagingGetOdataMultiplePagesOptionsInner pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptionsInner), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesWithOffsetNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesWithOffsetNextAsync(string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesWithOffsetNextOptionsInner pagingGetMultiplePagesWithOffsetNextOptions = default(PagingGetMultiplePagesWithOffsetNextOptionsInner), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesRetryFirstNextAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesRetrySecondNextAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetSinglePagesFailureNextAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesFailureNextAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='Microsoft.Rest.Azure.CloudException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        /// <exception cref='Microsoft.Rest.SerializationException'>
        /// Thrown when unable to deserialize the response.
        /// </exception>
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse<IPage<Product>>> GetMultiplePagesFailureUriNextAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
