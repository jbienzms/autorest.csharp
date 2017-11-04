// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsBodyDuration
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Duration operations.
    /// </summary>
    public partial interface IDuration
    {
        IDurationWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Get null duration value
        /// </summary>
        System.TimeSpan? GetNull();

        /// <summary>
        /// Get null duration value
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<System.TimeSpan?> GetNullAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Put a positive duration value
        /// </summary>
        /// <param name='durationBody'>
        /// </param>
        void PutPositiveDuration(System.TimeSpan durationBody);

        /// <summary>
        /// Put a positive duration value
        /// </summary>
        /// <param name='durationBody'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PutPositiveDurationAsync(System.TimeSpan durationBody, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a positive duration value
        /// </summary>
        System.TimeSpan? GetPositiveDuration();

        /// <summary>
        /// Get a positive duration value
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<System.TimeSpan?> GetPositiveDurationAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get an invalid duration value
        /// </summary>
        System.TimeSpan? GetInvalid();

        /// <summary>
        /// Get an invalid duration value
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<System.TimeSpan?> GetInvalidAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
