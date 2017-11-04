// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsCustomBaseUri
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PathsOperations operations.
    /// </summary>
    public partial interface IPathsOperationsWithHttpMessages
    {
        /// <summary>
        /// Get a 200 to test a valid base uri
        /// </summary>
        /// <param name='accountName'>
        /// Account Name
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
        /// <exception cref='Microsoft.Rest.ValidationException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        Task<AzureOperationResponse> GetEmptyAsync(string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
