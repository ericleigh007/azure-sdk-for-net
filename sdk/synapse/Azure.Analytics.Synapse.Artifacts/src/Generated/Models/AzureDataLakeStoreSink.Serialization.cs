// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureDataLakeStoreSinkConverter))]
    public partial class AzureDataLakeStoreSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CopyBehavior))
            {
                writer.WritePropertyName("copyBehavior");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CopyBehavior);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(CopyBehavior.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EnableAdlsSingleFileParallel))
            {
                writer.WritePropertyName("enableAdlsSingleFileParallel");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EnableAdlsSingleFileParallel);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EnableAdlsSingleFileParallel.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WriteBatchSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WriteBatchSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WriteBatchTimeout);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WriteBatchTimeout.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SinkRetryCount);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SinkRetryCount.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SinkRetryWait);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SinkRetryWait.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxConcurrentConnections);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MaxConcurrentConnections.ToString()).RootElement);
#endif
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static AzureDataLakeStoreSink DeserializeAzureDataLakeStoreSink(JsonElement element)
        {
            Optional<BinaryData> copyBehavior = default;
            Optional<BinaryData> enableAdlsSingleFileParallel = default;
            string type = default;
            Optional<BinaryData> writeBatchSize = default;
            Optional<BinaryData> writeBatchTimeout = default;
            Optional<BinaryData> sinkRetryCount = default;
            Optional<BinaryData> sinkRetryWait = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyBehavior"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    copyBehavior = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enableAdlsSingleFileParallel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableAdlsSingleFileParallel = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchSize = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchTimeout = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryCount = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryWait = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDataLakeStoreSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, copyBehavior.Value, enableAdlsSingleFileParallel.Value);
        }

        internal partial class AzureDataLakeStoreSinkConverter : JsonConverter<AzureDataLakeStoreSink>
        {
            public override void Write(Utf8JsonWriter writer, AzureDataLakeStoreSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureDataLakeStoreSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureDataLakeStoreSink(document.RootElement);
            }
        }
    }
}
