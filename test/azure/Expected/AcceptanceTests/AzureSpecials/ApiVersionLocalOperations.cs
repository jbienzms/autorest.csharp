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
    /// ApiVersionLocalOperations operations.
    /// </summary>
    public partial class ApiVersionLocalOperations : IApiVersionLocalOperations
    {
        /// <summary>
        /// Initializes a new instance of the ApiVersionLocalOperations class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public ApiVersionLocalOperations(IApiVersionLocalOperationsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IApiVersionLocalOperationsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IApiVersionLocalOperationsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        public void GetMethodLocalValid()
        {
            GetMethodLocalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetMethodLocalValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetMethodLocalValidAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = null to succeed
        /// </summary>
        /// <param name='apiVersion'>
        /// This should appear as a method parameter, use value null, this should result in no serialized parameter
        /// </param>
        public void GetMethodLocalNull(string apiVersion = default(string))
        {
            GetMethodLocalNullAsync(apiVersion).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = null to succeed
        /// </summary>
        /// <param name='apiVersion'>
        /// This should appear as a method parameter, use value null, this should result in no serialized parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetMethodLocalNullAsync(string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetMethodLocalNullAsync(apiVersion, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        public void GetPathLocalValid()
        {
            GetPathLocalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetPathLocalValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetPathLocalValidAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        public void GetSwaggerLocalValid()
        {
            GetSwaggerLocalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetSwaggerLocalValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetSwaggerLocalValidAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
