// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiagnosticOperations.
    /// </summary>
    public static partial class DiagnosticOperationsExtensions
    {
            /// <summary>
            /// Gets status of a Diagnostic operation issued for Disk Inspection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location used to execute the diagnostic operation.
            /// </param>
            /// <param name='operationId'>
            /// The identifier pointing to a request for Disk Inspection. This is used for
            /// polling result of the request.
            /// </param>
            public static void Read(this IDiagnosticOperations operations, string location, string operationId)
            {
                operations.ReadAsync(location, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets status of a Diagnostic operation issued for Disk Inspection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location used to execute the diagnostic operation.
            /// </param>
            /// <param name='operationId'>
            /// The identifier pointing to a request for Disk Inspection. This is used for
            /// polling result of the request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ReadAsync(this IDiagnosticOperations operations, string location, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ReadWithHttpMessagesAsync(location, operationId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
