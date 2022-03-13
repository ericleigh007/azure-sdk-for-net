// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Functions are stored Kusto queries that can be specified as part of queries by using their name. </summary>
    internal partial class MetadataFunction
    {
        /// <summary> Initializes a new instance of MetadataFunction. </summary>
        /// <param name="id"> The ID of the function. </param>
        /// <param name="name"> The name of the function, to be used in queries. </param>
        /// <param name="body"> The KQL body of the function. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="name"/> or <paramref name="body"/> is null. </exception>
        internal MetadataFunction(string id, string name, string body)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            Id = id;
            Name = name;
            Body = body;
        }

        /// <summary> The ID of the function. </summary>
        public string Id { get; }
        /// <summary> The name of the function, to be used in queries. </summary>
        public string Name { get; }
        /// <summary> The parameters/arguments of the function, if any. </summary>
        public string Parameters { get; }
        /// <summary> The display name of the function. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the function. </summary>
        public string Description { get; }
        /// <summary> The KQL body of the function. </summary>
        public string Body { get; }
        /// <summary> The tags associated with the function. </summary>
        public BinaryData Tags { get; }
        /// <summary> The properties of the function. </summary>
        public BinaryData Properties { get; }
        /// <summary> The related metadata items for the function. </summary>
        public MetadataFunctionRelated Related { get; }
    }
}
