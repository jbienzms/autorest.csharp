// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsBodyComplex
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Readonlyproperty operations.
    /// </summary>
    public partial interface IReadonlyproperty
    {
        IReadonlypropertyWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Get complex types that have readonly properties
        /// </summary>
        ReadonlyObj GetValid();

        /// <summary>
        /// Get complex types that have readonly properties
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ReadonlyObj> GetValidAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Put complex types that have readonly properties
        /// </summary>
        /// <param name='size'>
        /// </param>
        void PutValid(int? size = default(int?));

        /// <summary>
        /// Put complex types that have readonly properties
        /// </summary>
        /// <param name='size'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PutValidAsync(int? size = default(int?), CancellationToken cancellationToken = default(CancellationToken));
    }
}
