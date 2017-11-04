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
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// XMsClientRequestIdOperations operations.
    /// </summary>
    public partial interface IXMsClientRequestIdOperations
    {
        IXMsClientRequestIdOperationsWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        void Get();

        /// <summary>
        /// Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task GetAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        /// <param name='xMsClientRequestId'>
        /// This should appear as a method parameter, use value '9C4D50EE-2D56-4CD3-8152-34347DC9F2B0'
        /// </param>
        void ParamGet(string xMsClientRequestId);

        /// <summary>
        /// Get method that overwrites x-ms-client-request header with value 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        /// <param name='xMsClientRequestId'>
        /// This should appear as a method parameter, use value '9C4D50EE-2D56-4CD3-8152-34347DC9F2B0'
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task ParamGetAsync(string xMsClientRequestId, CancellationToken cancellationToken = default(CancellationToken));
    }
}
