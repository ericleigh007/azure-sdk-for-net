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
    [JsonConverter(typeof(AzureTableSinkConverter))]
    public partial class AzureTableSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureTableDefaultPartitionKeyValue))
            {
                writer.WritePropertyName("azureTableDefaultPartitionKeyValue");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AzureTableDefaultPartitionKeyValue);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AzureTableDefaultPartitionKeyValue.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AzureTablePartitionKeyName))
            {
                writer.WritePropertyName("azureTablePartitionKeyName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AzureTablePartitionKeyName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AzureTablePartitionKeyName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AzureTableRowKeyName))
            {
                writer.WritePropertyName("azureTableRowKeyName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AzureTableRowKeyName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AzureTableRowKeyName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AzureTableInsertType))
            {
                writer.WritePropertyName("azureTableInsertType");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AzureTableInsertType);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AzureTableInsertType.ToString()).RootElement);
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

        internal static AzureTableSink DeserializeAzureTableSink(JsonElement element)
        {
            Optional<BinaryData> azureTableDefaultPartitionKeyValue = default;
            Optional<BinaryData> azureTablePartitionKeyName = default;
            Optional<BinaryData> azureTableRowKeyName = default;
            Optional<BinaryData> azureTableInsertType = default;
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
                if (property.NameEquals("azureTableDefaultPartitionKeyValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureTableDefaultPartitionKeyValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("azureTablePartitionKeyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureTablePartitionKeyName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("azureTableRowKeyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureTableRowKeyName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("azureTableInsertType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureTableInsertType = BinaryData.FromString(property.Value.GetRawText());
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
            return new AzureTableSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, azureTableDefaultPartitionKeyValue.Value, azureTablePartitionKeyName.Value, azureTableRowKeyName.Value, azureTableInsertType.Value);
        }

        internal partial class AzureTableSinkConverter : JsonConverter<AzureTableSink>
        {
            public override void Write(Utf8JsonWriter writer, AzureTableSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureTableSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureTableSink(document.RootElement);
            }
        }
    }
}
