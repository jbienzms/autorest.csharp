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
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SubscriptionInCredentialsOperations operations.
    /// </summary>
    public partial class SubscriptionInCredentialsOperations : ISubscriptionInCredentialsOperations
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionInCredentialsOperations class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public SubscriptionInCredentialsOperations(ISubscriptionInCredentialsOperationsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private ISubscriptionInCredentialsOperationsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public ISubscriptionInCredentialsOperationsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to '1234-5678-9012-3456'
        /// to succeed
        /// </summary>
        public void PostMethodGlobalValid()
        {
            PostMethodGlobalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to '1234-5678-9012-3456'
        /// to succeed
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostMethodGlobalValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostMethodGlobalValidAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to null, and client-side
        /// validation should prevent you from making this call
        /// </summary>
        public void PostMethodGlobalNull()
        {
            PostMethodGlobalNullAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to null, and client-side
        /// validation should prevent you from making this call
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostMethodGlobalNullAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostMethodGlobalNullAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to '1234-5678-9012-3456'
        /// to succeed
        /// </summary>
        public void PostMethodGlobalNotProvidedValid()
        {
            PostMethodGlobalNotProvidedValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to '1234-5678-9012-3456'
        /// to succeed
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostMethodGlobalNotProvidedValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostMethodGlobalNotProvidedValidAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to '1234-5678-9012-3456'
        /// to succeed
        /// </summary>
        public void PostPathGlobalValid()
        {
            PostPathGlobalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to '1234-5678-9012-3456'
        /// to succeed
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostPathGlobalValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostPathGlobalValidAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to '1234-5678-9012-3456'
        /// to succeed
        /// </summary>
        public void PostSwaggerGlobalValid()
        {
            PostSwaggerGlobalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// POST method with subscriptionId modeled in credentials.  Set the credential subscriptionId to '1234-5678-9012-3456'
        /// to succeed
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostSwaggerGlobalValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostSwaggerGlobalValidAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
