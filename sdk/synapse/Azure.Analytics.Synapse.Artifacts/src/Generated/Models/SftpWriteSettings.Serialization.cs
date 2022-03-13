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
    [JsonConverter(typeof(SftpWriteSettingsConverter))]
    public partial class SftpWriteSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OperationTimeout))
            {
                writer.WritePropertyName("operationTimeout");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(OperationTimeout);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(OperationTimeout.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(UseTempFileRename))
            {
                writer.WritePropertyName("useTempFileRename");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UseTempFileRename);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UseTempFileRename.ToString()).RootElement);
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
            if (Optional.IsDefined(CopyBehavior))
            {
                writer.WritePropertyName("copyBehavior");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CopyBehavior);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(CopyBehavior.ToString()).RootElement);
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

        internal static SftpWriteSettings DeserializeSftpWriteSettings(JsonElement element)
        {
            Optional<BinaryData> operationTimeout = default;
            Optional<BinaryData> useTempFileRename = default;
            string type = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            Optional<BinaryData> copyBehavior = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operationTimeout = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("useTempFileRename"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useTempFileRename = BinaryData.FromString(property.Value.GetRawText());
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
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SftpWriteSettings(type, maxConcurrentConnections.Value, copyBehavior.Value, additionalProperties, operationTimeout.Value, useTempFileRename.Value);
        }

        internal partial class SftpWriteSettingsConverter : JsonConverter<SftpWriteSettings>
        {
            public override void Write(Utf8JsonWriter writer, SftpWriteSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SftpWriteSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSftpWriteSettings(document.RootElement);
            }
        }
    }
}
