// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(StorageAsyncOperationInitiatedEventDataConverter))]
    public partial class StorageAsyncOperationInitiatedEventData
    {
        internal static StorageAsyncOperationInitiatedEventData DeserializeStorageAsyncOperationInitiatedEventData(JsonElement element)
        {
            Optional<string> api = default;
            Optional<string> clientRequestId = default;
            Optional<string> requestId = default;
            Optional<string> contentType = default;
            Optional<long> contentLength = default;
            Optional<string> blobType = default;
            Optional<string> url = default;
            Optional<string> sequencer = default;
            Optional<string> identity = default;
            Optional<BinaryData> storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    contentLength = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("blobType"))
                {
                    blobType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageDiagnostics = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new StorageAsyncOperationInitiatedEventData(api.Value, clientRequestId.Value, requestId.Value, contentType.Value, Optional.ToNullable(contentLength), blobType.Value, url.Value, sequencer.Value, identity.Value, storageDiagnostics.Value);
        }

        internal partial class StorageAsyncOperationInitiatedEventDataConverter : JsonConverter<StorageAsyncOperationInitiatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageAsyncOperationInitiatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override StorageAsyncOperationInitiatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageAsyncOperationInitiatedEventData(document.RootElement);
            }
        }
    }
}
