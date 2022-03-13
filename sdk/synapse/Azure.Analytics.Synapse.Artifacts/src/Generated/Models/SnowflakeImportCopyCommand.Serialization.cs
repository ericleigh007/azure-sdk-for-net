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
    [JsonConverter(typeof(SnowflakeImportCopyCommandConverter))]
    public partial class SnowflakeImportCopyCommand : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdditionalCopyOptions))
            {
                writer.WritePropertyName("additionalCopyOptions");
                writer.WriteStartObject();
                foreach (var item in AdditionalCopyOptions)
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
            if (Optional.IsCollectionDefined(AdditionalFormatOptions))
            {
                writer.WritePropertyName("additionalFormatOptions");
                writer.WriteStartObject();
                foreach (var item in AdditionalFormatOptions)
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

        internal static SnowflakeImportCopyCommand DeserializeSnowflakeImportCopyCommand(JsonElement element)
        {
            Optional<IDictionary<string, BinaryData>> additionalCopyOptions = default;
            Optional<IDictionary<string, BinaryData>> additionalFormatOptions = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalCopyOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, BinaryData.FromString(property.Value.GetRawText()));
                    }
                    additionalCopyOptions = dictionary;
                    continue;
                }
                if (property.NameEquals("additionalFormatOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, BinaryData.FromString(property.Value.GetRawText()));
                    }
                    additionalFormatOptions = dictionary;
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
            return new SnowflakeImportCopyCommand(type, additionalProperties, Optional.ToDictionary(additionalCopyOptions), Optional.ToDictionary(additionalFormatOptions));
        }

        internal partial class SnowflakeImportCopyCommandConverter : JsonConverter<SnowflakeImportCopyCommand>
        {
            public override void Write(Utf8JsonWriter writer, SnowflakeImportCopyCommand model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SnowflakeImportCopyCommand Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSnowflakeImportCopyCommand(document.RootElement);
            }
        }
    }
}
