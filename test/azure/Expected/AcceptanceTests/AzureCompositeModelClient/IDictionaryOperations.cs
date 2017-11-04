// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsAzureCompositeModelClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DictionaryOperations operations.
    /// </summary>
    public partial interface IDictionaryOperations
    {
        IDictionaryOperationsWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Get complex types with dictionary property
        /// </summary>
        DictionaryWrapper GetValid();

        /// <summary>
        /// Get complex types with dictionary property
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<DictionaryWrapper> GetValidAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Put complex types with dictionary property
        /// </summary>
        /// <param name='defaultProgram'>
        /// </param>
        void PutValid(IDictionary<string, string> defaultProgram = default(IDictionary<string, string>));

        /// <summary>
        /// Put complex types with dictionary property
        /// </summary>
        /// <param name='defaultProgram'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PutValidAsync(IDictionary<string, string> defaultProgram = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get complex types with dictionary property which is empty
        /// </summary>
        DictionaryWrapper GetEmpty();

        /// <summary>
        /// Get complex types with dictionary property which is empty
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<DictionaryWrapper> GetEmptyAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Put complex types with dictionary property which is empty
        /// </summary>
        /// <param name='defaultProgram'>
        /// </param>
        void PutEmpty(IDictionary<string, string> defaultProgram = default(IDictionary<string, string>));

        /// <summary>
        /// Put complex types with dictionary property which is empty
        /// </summary>
        /// <param name='defaultProgram'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PutEmptyAsync(IDictionary<string, string> defaultProgram = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get complex types with dictionary property which is null
        /// </summary>
        DictionaryWrapper GetNull();

        /// <summary>
        /// Get complex types with dictionary property which is null
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<DictionaryWrapper> GetNullAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get complex types with dictionary property while server doesn't provide a response payload
        /// </summary>
        DictionaryWrapper GetNotProvided();

        /// <summary>
        /// Get complex types with dictionary property while server doesn't provide a response payload
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<DictionaryWrapper> GetNotProvidedAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
