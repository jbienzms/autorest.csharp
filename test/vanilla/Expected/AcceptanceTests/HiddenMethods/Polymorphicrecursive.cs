// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsHiddenMethods
{
    using Microsoft.Rest;
    using Models;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Polymorphicrecursive operations.
    /// </summary>
    public partial class Polymorphicrecursive : IPolymorphicrecursive
    {
        /// <summary>
        /// Initializes a new instance of the Polymorphicrecursive class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public Polymorphicrecursive(IPolymorphicrecursiveWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IPolymorphicrecursiveWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IPolymorphicrecursiveWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Get complex types that are polymorphic and have recursive references
        /// </summary>
        public Fish GetValid()
        {
            return GetValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get complex types that are polymorphic and have recursive references
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<Fish> GetValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetValidAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put complex types that are polymorphic and have recursive references
        /// </summary>
        /// <param name='complexBody'>
        /// Please put a salmon that looks like this:
        /// {
        /// "fishtype": "salmon",
        /// "species": "king",
        /// "length": 1,
        /// "age": 1,
        /// "location": "alaska",
        /// "iswild": true,
        /// "siblings": [
        /// {
        /// "fishtype": "shark",
        /// "species": "predator",
        /// "length": 20,
        /// "age": 6,
        /// "siblings": [
        /// {
        /// "fishtype": "salmon",
        /// "species": "coho",
        /// "length": 2,
        /// "age": 2,
        /// "location": "atlantic",
        /// "iswild": true,
        /// "siblings": [
        /// {
        /// "fishtype": "shark",
        /// "species": "predator",
        /// "length": 20,
        /// "age": 6
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// }
        /// </param>
        public void PutValid(Fish complexBody)
        {
            PutValidAsync(complexBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put complex types that are polymorphic and have recursive references
        /// </summary>
        /// <param name='complexBody'>
        /// Please put a salmon that looks like this:
        /// {
        /// "fishtype": "salmon",
        /// "species": "king",
        /// "length": 1,
        /// "age": 1,
        /// "location": "alaska",
        /// "iswild": true,
        /// "siblings": [
        /// {
        /// "fishtype": "shark",
        /// "species": "predator",
        /// "length": 20,
        /// "age": 6,
        /// "siblings": [
        /// {
        /// "fishtype": "salmon",
        /// "species": "coho",
        /// "length": 2,
        /// "age": 2,
        /// "location": "atlantic",
        /// "iswild": true,
        /// "siblings": [
        /// {
        /// "fishtype": "shark",
        /// "species": "predator",
        /// "length": 20,
        /// "age": 6
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// },
        /// {
        /// "fishtype": "sawshark",
        /// "species": "dangerous",
        /// "length": 10,
        /// "age": 105
        /// }
        /// ]
        /// }
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutValidAsync(Fish complexBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutValidAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
