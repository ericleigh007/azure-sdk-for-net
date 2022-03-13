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
    [JsonConverter(typeof(ParquetWriteSettingsConverter))]
    public partial class ParquetWriteSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxRowsPerFile))
            {
                writer.WritePropertyName("maxRowsPerFile");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxRowsPerFile);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MaxRowsPerFile.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(FileNamePrefix))
            {
                writer.WritePropertyName("fileNamePrefix");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FileNamePrefix);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FileNamePrefix.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
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

        internal static ParquetWriteSettings DeserializeParquetWriteSettings(JsonElement element)
        {
            Optional<BinaryData> maxRowsPerFile = default;
            Optional<BinaryData> fileNamePrefix = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxRowsPerFile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxRowsPerFile = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileNamePrefix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileNamePrefix = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ParquetWriteSettings(type, additionalProperties, maxRowsPerFile.Value, fileNamePrefix.Value);
        }

        internal partial class ParquetWriteSettingsConverter : JsonConverter<ParquetWriteSettings>
        {
            public override void Write(Utf8JsonWriter writer, ParquetWriteSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ParquetWriteSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeParquetWriteSettings(document.RootElement);
            }
        }
    }
}
