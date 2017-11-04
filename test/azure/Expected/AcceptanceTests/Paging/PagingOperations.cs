// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsPaging
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PagingOperations operations.
    /// </summary>
    public partial class PagingOperations : IPagingOperations
    {
        /// <summary>
        /// Initializes a new instance of the PagingOperations class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public PagingOperations(IPagingOperationsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IPagingOperationsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IPagingOperationsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        public IPage<Product> GetSinglePages()
        {
            return GetSinglePagesAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetSinglePagesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetSinglePagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        public IPage<Product> GetMultiplePages(string clientRequestId = default(string), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions))
        {
            return GetMultiplePagesAsync(clientRequestId, pagingGetMultiplePagesOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesAsync(string clientRequestId = default(string), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesAsync(clientRequestId, pagingGetMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink in odata format that has 10 pages
        /// </summary>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetOdataMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        public IPage<Product> GetOdataMultiplePages(string clientRequestId = default(string), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions))
        {
            return GetOdataMultiplePagesAsync(clientRequestId, pagingGetOdataMultiplePagesOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink in odata format that has 10 pages
        /// </summary>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetOdataMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetOdataMultiplePagesAsync(string clientRequestId = default(string), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetOdataMultiplePagesAsync(clientRequestId, pagingGetOdataMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='pagingGetMultiplePagesWithOffsetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        public IPage<Product> GetMultiplePagesWithOffset(PagingGetMultiplePagesWithOffsetOptions pagingGetMultiplePagesWithOffsetOptions, string clientRequestId = default(string))
        {
            return GetMultiplePagesWithOffsetAsync(pagingGetMultiplePagesWithOffsetOptions, clientRequestId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='pagingGetMultiplePagesWithOffsetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesWithOffsetAsync(PagingGetMultiplePagesWithOffsetOptions pagingGetMultiplePagesWithOffsetOptions, string clientRequestId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesWithOffsetAsync(pagingGetMultiplePagesWithOffsetOptions, clientRequestId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        public IPage<Product> GetMultiplePagesRetryFirst()
        {
            return GetMultiplePagesRetryFirstAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesRetryFirstAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesRetryFirstAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        public IPage<Product> GetMultiplePagesRetrySecond()
        {
            return GetMultiplePagesRetrySecondAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesRetrySecondAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesRetrySecondAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        public IPage<Product> GetSinglePagesFailure()
        {
            return GetSinglePagesFailureAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetSinglePagesFailureAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetSinglePagesFailureAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        public IPage<Product> GetMultiplePagesFailure()
        {
            return GetMultiplePagesFailureAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesFailureAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesFailureAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        public IPage<Product> GetMultiplePagesFailureUri()
        {
            return GetMultiplePagesFailureUriAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesFailureUriAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesFailureUriAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='apiVersion'>
        /// Sets the api version to use.
        /// </param>
        /// <param name='tenant'>
        /// Sets the tenant to use.
        /// </param>
        public IPage<Product> GetMultiplePagesFragmentNextLink(string apiVersion, string tenant)
        {
            return GetMultiplePagesFragmentNextLinkAsync(apiVersion, tenant).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='apiVersion'>
        /// Sets the api version to use.
        /// </param>
        /// <param name='tenant'>
        /// Sets the tenant to use.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesFragmentNextLinkAsync(string apiVersion, string tenant, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesFragmentNextLinkAsync(apiVersion, tenant, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment with parameters grouped
        /// </summary>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        public IPage<Product> GetMultiplePagesFragmentWithGroupingNextLink(CustomParameterGroup customParameterGroup)
        {
            return GetMultiplePagesFragmentWithGroupingNextLinkAsync(customParameterGroup).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment with parameters grouped
        /// </summary>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesFragmentWithGroupingNextLinkAsync(CustomParameterGroup customParameterGroup, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesFragmentWithGroupingNextLinkAsync(customParameterGroup, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        public IPage<Product> NextFragment(string apiVersion, string tenant, string nextLink)
        {
            return NextFragmentAsync(apiVersion, tenant, nextLink).GetAwaiter().GetResult();
        }

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
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> NextFragmentAsync(string apiVersion, string tenant, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.NextFragmentAsync(apiVersion, tenant, nextLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='nextLink'>
        /// Next link for list operation.
        /// </param>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        public IPage<Product> NextFragmentWithGrouping(string nextLink, CustomParameterGroup customParameterGroup)
        {
            return NextFragmentWithGroupingAsync(nextLink, customParameterGroup).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='nextLink'>
        /// Next link for list operation.
        /// </param>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> NextFragmentWithGroupingAsync(string nextLink, CustomParameterGroup customParameterGroup, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.NextFragmentWithGroupingAsync(nextLink, customParameterGroup, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public IPage<Product> GetSinglePagesNext(string nextPageLink)
        {
            return GetSinglePagesNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetSinglePagesNextAsync(string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetSinglePagesNextAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        public IPage<Product> GetMultiplePagesNext(string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions))
        {
            return GetMultiplePagesNextAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesOptions).GetAwaiter().GetResult();
        }

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
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesNextAsync(string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesNextAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        public IPage<Product> GetOdataMultiplePagesNext(string nextPageLink, string clientRequestId = default(string), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions))
        {
            return GetOdataMultiplePagesNextAsync(nextPageLink, clientRequestId, pagingGetOdataMultiplePagesOptions).GetAwaiter().GetResult();
        }

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
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetOdataMultiplePagesNextAsync(string nextPageLink, string clientRequestId = default(string), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetOdataMultiplePagesNextAsync(nextPageLink, clientRequestId, pagingGetOdataMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

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
        public IPage<Product> GetMultiplePagesWithOffsetNext(string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesWithOffsetNextOptions pagingGetMultiplePagesWithOffsetNextOptions = default(PagingGetMultiplePagesWithOffsetNextOptions))
        {
            return GetMultiplePagesWithOffsetNextAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesWithOffsetNextOptions).GetAwaiter().GetResult();
        }

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
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesWithOffsetNextAsync(string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesWithOffsetNextOptions pagingGetMultiplePagesWithOffsetNextOptions = default(PagingGetMultiplePagesWithOffsetNextOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesWithOffsetNextAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesWithOffsetNextOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public IPage<Product> GetMultiplePagesRetryFirstNext(string nextPageLink)
        {
            return GetMultiplePagesRetryFirstNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesRetryFirstNextAsync(string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesRetryFirstNextAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public IPage<Product> GetMultiplePagesRetrySecondNext(string nextPageLink)
        {
            return GetMultiplePagesRetrySecondNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesRetrySecondNextAsync(string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesRetrySecondNextAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public IPage<Product> GetSinglePagesFailureNext(string nextPageLink)
        {
            return GetSinglePagesFailureNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetSinglePagesFailureNextAsync(string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetSinglePagesFailureNextAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public IPage<Product> GetMultiplePagesFailureNext(string nextPageLink)
        {
            return GetMultiplePagesFailureNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesFailureNextAsync(string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesFailureNextAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public IPage<Product> GetMultiplePagesFailureUriNext(string nextPageLink)
        {
            return GetMultiplePagesFailureUriNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<IPage<Product>> GetMultiplePagesFailureUriNextAsync(string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetMultiplePagesFailureUriNextAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
