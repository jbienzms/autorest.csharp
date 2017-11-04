// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsRequiredOptional
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ExplicitModel operations.
    /// </summary>
    public partial class ExplicitModel : IExplicitModel
    {
        /// <summary>
        /// Initializes a new instance of the ExplicitModel class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public ExplicitModel(IExplicitModelWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IExplicitModelWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IExplicitModelWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Test explicitly required integer. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public Error PostRequiredIntegerParameter(int bodyParameter)
        {
            return PostRequiredIntegerParameterAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required integer. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredIntegerParameterAsync(int bodyParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredIntegerParameterAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional integer. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public void PostOptionalIntegerParameter(int? bodyParameter = default(int?))
        {
            PostOptionalIntegerParameterAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional integer. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalIntegerParameterAsync(int? bodyParameter = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalIntegerParameterAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required integer. Please put a valid int-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        public Error PostRequiredIntegerProperty(int value)
        {
            return PostRequiredIntegerPropertyAsync(value).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required integer. Please put a valid int-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredIntegerPropertyAsync(int value, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredIntegerPropertyAsync(value, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional integer. Please put a valid int-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        public void PostOptionalIntegerProperty(int? value = default(int?))
        {
            PostOptionalIntegerPropertyAsync(value).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional integer. Please put a valid int-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalIntegerPropertyAsync(int? value = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalIntegerPropertyAsync(value, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required integer. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        public Error PostRequiredIntegerHeader(int headerParameter)
        {
            return PostRequiredIntegerHeaderAsync(headerParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required integer. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredIntegerHeaderAsync(int headerParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredIntegerHeaderAsync(headerParameter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional integer. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        public void PostOptionalIntegerHeader(int? headerParameter = default(int?))
        {
            PostOptionalIntegerHeaderAsync(headerParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional integer. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalIntegerHeaderAsync(int? headerParameter = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalIntegerHeaderAsync(headerParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required string. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public Error PostRequiredStringParameter(string bodyParameter)
        {
            return PostRequiredStringParameterAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required string. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredStringParameterAsync(string bodyParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredStringParameterAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional string. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public void PostOptionalStringParameter(string bodyParameter = default(string))
        {
            PostOptionalStringParameterAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional string. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalStringParameterAsync(string bodyParameter = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalStringParameterAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required string. Please put a valid string-wrapper with 'value' = null and the client library
        /// should throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        public Error PostRequiredStringProperty(string value)
        {
            return PostRequiredStringPropertyAsync(value).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required string. Please put a valid string-wrapper with 'value' = null and the client library
        /// should throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredStringPropertyAsync(string value, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredStringPropertyAsync(value, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional integer. Please put a valid string-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        public void PostOptionalStringProperty(string value = default(string))
        {
            PostOptionalStringPropertyAsync(value).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional integer. Please put a valid string-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalStringPropertyAsync(string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalStringPropertyAsync(value, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required string. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        public Error PostRequiredStringHeader(string headerParameter)
        {
            return PostRequiredStringHeaderAsync(headerParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required string. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredStringHeaderAsync(string headerParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredStringHeaderAsync(headerParameter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional string. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public void PostOptionalStringHeader(string bodyParameter = default(string))
        {
            PostOptionalStringHeaderAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional string. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalStringHeaderAsync(string bodyParameter = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalStringHeaderAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required complex object. Please put null and the client library should throw before the request is
        /// sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public Error PostRequiredClassParameter(Product bodyParameter)
        {
            return PostRequiredClassParameterAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required complex object. Please put null and the client library should throw before the request is
        /// sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredClassParameterAsync(Product bodyParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredClassParameterAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional complex object. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public void PostOptionalClassParameter(Product bodyParameter = default(Product))
        {
            PostOptionalClassParameterAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional complex object. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalClassParameterAsync(Product bodyParameter = default(Product), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalClassParameterAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required complex object. Please put a valid class-wrapper with 'value' = null and the client
        /// library should throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        public Error PostRequiredClassProperty(Product value)
        {
            return PostRequiredClassPropertyAsync(value).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required complex object. Please put a valid class-wrapper with 'value' = null and the client
        /// library should throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredClassPropertyAsync(Product value, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredClassPropertyAsync(value, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional complex object. Please put a valid class-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        public void PostOptionalClassProperty(Product value = default(Product))
        {
            PostOptionalClassPropertyAsync(value).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional complex object. Please put a valid class-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalClassPropertyAsync(Product value = default(Product), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalClassPropertyAsync(value, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required array. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public Error PostRequiredArrayParameter(IList<string> bodyParameter)
        {
            return PostRequiredArrayParameterAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required array. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredArrayParameterAsync(IList<string> bodyParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredArrayParameterAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional array. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        public void PostOptionalArrayParameter(IList<string> bodyParameter = default(IList<string>))
        {
            PostOptionalArrayParameterAsync(bodyParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional array. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalArrayParameterAsync(IList<string> bodyParameter = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalArrayParameterAsync(bodyParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required array. Please put a valid array-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        public Error PostRequiredArrayProperty(IList<string> value)
        {
            return PostRequiredArrayPropertyAsync(value).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required array. Please put a valid array-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredArrayPropertyAsync(IList<string> value, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredArrayPropertyAsync(value, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional array. Please put a valid array-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        public void PostOptionalArrayProperty(IList<string> value = default(IList<string>))
        {
            PostOptionalArrayPropertyAsync(value).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional array. Please put a valid array-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalArrayPropertyAsync(IList<string> value = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalArrayPropertyAsync(value, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Test explicitly required array. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        public Error PostRequiredArrayHeader(IList<string> headerParameter)
        {
            return PostRequiredArrayHeaderAsync(headerParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly required array. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Error> PostRequiredArrayHeaderAsync(IList<string> headerParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.PostRequiredArrayHeaderAsync(headerParameter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Test explicitly optional integer. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        public void PostOptionalArrayHeader(IList<string> headerParameter = default(IList<string>))
        {
            PostOptionalArrayHeaderAsync(headerParameter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test explicitly optional integer. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PostOptionalArrayHeaderAsync(IList<string> headerParameter = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PostOptionalArrayHeaderAsync(headerParameter, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
