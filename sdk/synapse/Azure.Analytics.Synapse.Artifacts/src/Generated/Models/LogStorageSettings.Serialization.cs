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
    [JsonConverter(typeof(LogStorageSettingsConverter))]
    public partial class LogStorageSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Path);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Path.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(LogLevel);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(LogLevel.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EnableReliableLogging))
            {
                writer.WritePropertyName("enableReliableLogging");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EnableReliableLogging);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EnableReliableLogging.ToString()).RootElement);
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

        internal static LogStorageSettings DeserializeLogStorageSettings(JsonElement element)
        {
            LinkedServiceReference linkedServiceName = default;
            Optional<BinaryData> path = default;
            Optional<BinaryData> logLevel = default;
            Optional<BinaryData> enableReliableLogging = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    path = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("logLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logLevel = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enableReliableLogging"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableReliableLogging = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new LogStorageSettings(linkedServiceName, path.Value, logLevel.Value, enableReliableLogging.Value, additionalProperties);
        }

        internal partial class LogStorageSettingsConverter : JsonConverter<LogStorageSettings>
        {
            public override void Write(Utf8JsonWriter writer, LogStorageSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LogStorageSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLogStorageSettings(document.RootElement);
            }
        }
    }
}
