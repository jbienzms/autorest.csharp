// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsAzureCompositeModelClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PolymorphismOperations operations.
    /// </summary>
    public partial class PolymorphismOperations : IPolymorphismOperations
    {
        /// <summary>
        /// Initializes a new instance of the PolymorphismOperations class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public PolymorphismOperations(IPolymorphismOperationsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IPolymorphismOperationsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IPolymorphismOperationsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Get complex types that are polymorphic
        /// </summary>
        public FishInner GetValid()
        {
            return GetValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get complex types that are polymorphic
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<FishInner> GetValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetValidAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put complex types that are polymorphic
        /// </summary>
        /// <param name='complexBody'>
        /// Please put a salmon that looks like this:
        /// {
        /// 'fishtype':'Salmon',
        /// 'location':'alaska',
        /// 'iswild':true,
        /// 'species':'king',
        /// 'length':1.0,
        /// 'siblings':[
        /// {
        /// 'fishtype':'Shark',
        /// 'age':6,
        /// 'birthday': '2012-01-05T01:00:00Z',
        /// 'length':20.0,
        /// 'species':'predator',
        /// },
        /// {
        /// 'fishtype':'Sawshark',
        /// 'age':105,
        /// 'birthday': '1900-01-05T01:00:00Z',
        /// 'length':10.0,
        /// 'picture': new Buffer([255, 255, 255, 255, 254]).toString('base64'),
        /// 'species':'dangerous',
        /// },
        /// {
        /// 'fishtype': 'goblin',
        /// 'age': 1,
        /// 'birthday': '2015-08-08T00:00:00Z',
        /// 'length': 30.0,
        /// 'species': 'scary',
        /// 'jawsize': 5
        /// }
        /// ]
        /// };
        /// </param>
        public void PutValid(FishInner complexBody)
        {
            PutValidAsync(complexBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put complex types that are polymorphic
        /// </summary>
        /// <param name='complexBody'>
        /// Please put a salmon that looks like this:
        /// {
        /// 'fishtype':'Salmon',
        /// 'location':'alaska',
        /// 'iswild':true,
        /// 'species':'king',
        /// 'length':1.0,
        /// 'siblings':[
        /// {
        /// 'fishtype':'Shark',
        /// 'age':6,
        /// 'birthday': '2012-01-05T01:00:00Z',
        /// 'length':20.0,
        /// 'species':'predator',
        /// },
        /// {
        /// 'fishtype':'Sawshark',
        /// 'age':105,
        /// 'birthday': '1900-01-05T01:00:00Z',
        /// 'length':10.0,
        /// 'picture': new Buffer([255, 255, 255, 255, 254]).toString('base64'),
        /// 'species':'dangerous',
        /// },
        /// {
        /// 'fishtype': 'goblin',
        /// 'age': 1,
        /// 'birthday': '2015-08-08T00:00:00Z',
        /// 'length': 30.0,
        /// 'species': 'scary',
        /// 'jawsize': 5
        /// }
        /// ]
        /// };
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutValidAsync(FishInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutValidAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Put complex types that are polymorphic, attempting to omit required 'birthday' field - the request should not be
        /// allowed from the client
        /// </summary>
        /// <param name='complexBody'>
        /// Please attempt put a sawshark that looks like this, the client should not allow this data to be sent:
        /// {
        /// "fishtype": "sawshark",
        /// "species": "snaggle toothed",
        /// "length": 18.5,
        /// "age": 2,
        /// "birthday": "2013-06-01T01:00:00Z",
        /// "location": "alaska",
        /// "picture": base64(FF FF FF FF FE),
        /// "siblings": [
        /// {
        /// "fishtype": "shark",
        /// "species": "predator",
        /// "birthday": "2012-01-05T01:00:00Z",
        /// "length": 20,
        /// "age": 6
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "picture": base64(FF FF FF FF FE),
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// }
        /// </param>
        public void PutValidMissingRequired(FishInner complexBody)
        {
            PutValidMissingRequiredAsync(complexBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put complex types that are polymorphic, attempting to omit required 'birthday' field - the request should not be
        /// allowed from the client
        /// </summary>
        /// <param name='complexBody'>
        /// Please attempt put a sawshark that looks like this, the client should not allow this data to be sent:
        /// {
        /// "fishtype": "sawshark",
        /// "species": "snaggle toothed",
        /// "length": 18.5,
        /// "age": 2,
        /// "birthday": "2013-06-01T01:00:00Z",
        /// "location": "alaska",
        /// "picture": base64(FF FF FF FF FE),
        /// "siblings": [
        /// {
        /// "fishtype": "shark",
        /// "species": "predator",
        /// "birthday": "2012-01-05T01:00:00Z",
        /// "length": 20,
        /// "age": 6
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "picture": base64(FF FF FF FF FE),
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// }
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutValidMissingRequiredAsync(FishInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutValidMissingRequiredAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
