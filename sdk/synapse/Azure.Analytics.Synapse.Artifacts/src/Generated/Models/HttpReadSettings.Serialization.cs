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
    [JsonConverter(typeof(HttpReadSettingsConverter))]
    public partial class HttpReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RequestMethod))
            {
                writer.WritePropertyName("requestMethod");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RequestMethod);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(RequestMethod.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(RequestBody))
            {
                writer.WritePropertyName("requestBody");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RequestBody);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(RequestBody.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AdditionalHeaders))
            {
                writer.WritePropertyName("additionalHeaders");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AdditionalHeaders);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AdditionalHeaders.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(RequestTimeout))
            {
                writer.WritePropertyName("requestTimeout");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RequestTimeout);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(RequestTimeout.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EnablePartitionDiscovery))
            {
                writer.WritePropertyName("enablePartitionDiscovery");
                writer.WriteBooleanValue(EnablePartitionDiscovery.Value);
            }
            if (Optional.IsDefined(PartitionRootPath))
            {
                writer.WritePropertyName("partitionRootPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PartitionRootPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PartitionRootPath.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
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

        internal static HttpReadSettings DeserializeHttpReadSettings(JsonElement element)
        {
            Optional<BinaryData> requestMethod = default;
            Optional<BinaryData> requestBody = default;
            Optional<BinaryData> additionalHeaders = default;
            Optional<BinaryData> requestTimeout = default;
            Optional<bool> enablePartitionDiscovery = default;
            Optional<BinaryData> partitionRootPath = default;
            string type = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestMethod = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("requestBody"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestBody = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("additionalHeaders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalHeaders = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("requestTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestTimeout = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enablePartitionDiscovery = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("partitionRootPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionRootPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
            return new HttpReadSettings(type, maxConcurrentConnections.Value, additionalProperties, requestMethod.Value, requestBody.Value, additionalHeaders.Value, requestTimeout.Value, Optional.ToNullable(enablePartitionDiscovery), partitionRootPath.Value);
        }

        internal partial class HttpReadSettingsConverter : JsonConverter<HttpReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, HttpReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HttpReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHttpReadSettings(document.RootElement);
            }
        }
    }
}
