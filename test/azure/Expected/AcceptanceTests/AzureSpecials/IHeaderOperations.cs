// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// HeaderOperations operations.
    /// </summary>
    public partial interface IHeaderOperations
    {
        IHeaderOperationsWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request
        /// </summary>
        /// <param name='fooClientRequestId'>
        /// The fooRequestId
        /// </param>
        HeaderCustomNamedRequestIdHeaders CustomNamedRequestId(string fooClientRequestId);

        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request
        /// </summary>
        /// <param name='fooClientRequestId'>
        /// The fooRequestId
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HeaderCustomNamedRequestIdHeaders> CustomNamedRequestIdAsync(string fooClientRequestId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request, via a parameter
        /// group
        /// </summary>
        /// <param name='headerCustomNamedRequestIdParamGroupingParameters'>
        /// Additional parameters for the operation
        /// </param>
        HeaderCustomNamedRequestIdParamGroupingHeaders CustomNamedRequestIdParamGrouping(HeaderCustomNamedRequestIdParamGroupingParameters headerCustomNamedRequestIdParamGroupingParameters);

        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request, via a parameter
        /// group
        /// </summary>
        /// <param name='headerCustomNamedRequestIdParamGroupingParameters'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HeaderCustomNamedRequestIdParamGroupingHeaders> CustomNamedRequestIdParamGroupingAsync(HeaderCustomNamedRequestIdParamGroupingParameters headerCustomNamedRequestIdParamGroupingParameters, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request
        /// </summary>
        /// <param name='fooClientRequestId'>
        /// The fooRequestId
        /// </param>
        bool CustomNamedRequestIdHead(string fooClientRequestId);

        /// <summary>
        /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the header of the request
        /// </summary>
        /// <param name='fooClientRequestId'>
        /// The fooRequestId
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<bool> CustomNamedRequestIdHeadAsync(string fooClientRequestId, CancellationToken cancellationToken = default(CancellationToken));
    }
}
