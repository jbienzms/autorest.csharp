// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsHeadExceptions
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// HeadExceptionOperations operations.
    /// </summary>
    public partial class HeadExceptionOperations : IHeadExceptionOperations
    {
        /// <summary>
        /// Initializes a new instance of the HeadExceptionOperations class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public HeadExceptionOperations(IHeadExceptionOperationsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IHeadExceptionOperationsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IHeadExceptionOperationsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Return 200 status code if successful
        /// </summary>
        public void Head200()
        {
            Head200Async().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Return 200 status code if successful
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task Head200Async(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.Head200Async(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Return 204 status code if successful
        /// </summary>
        public void Head204()
        {
            Head204Async().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Return 204 status code if successful
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task Head204Async(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.Head204Async(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Return 404 status code if successful
        /// </summary>
        public void Head404()
        {
            Head404Async().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Return 404 status code if successful
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task Head404Async(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.Head404Async(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
