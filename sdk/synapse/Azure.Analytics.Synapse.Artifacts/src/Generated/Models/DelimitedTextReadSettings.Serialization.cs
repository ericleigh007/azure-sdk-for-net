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
    [JsonConverter(typeof(DelimitedTextReadSettingsConverter))]
    public partial class DelimitedTextReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SkipLineCount))
            {
                writer.WritePropertyName("skipLineCount");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SkipLineCount);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SkipLineCount.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(CompressionProperties))
            {
                writer.WritePropertyName("compressionProperties");
                writer.WriteObjectValue(CompressionProperties);
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

        internal static DelimitedTextReadSettings DeserializeDelimitedTextReadSettings(JsonElement element)
        {
            Optional<BinaryData> skipLineCount = default;
            Optional<CompressionReadSettings> compressionProperties = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipLineCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skipLineCount = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("compressionProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    compressionProperties = CompressionReadSettings.DeserializeCompressionReadSettings(property.Value);
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
            return new DelimitedTextReadSettings(type, additionalProperties, skipLineCount.Value, compressionProperties.Value);
        }

        internal partial class DelimitedTextReadSettingsConverter : JsonConverter<DelimitedTextReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, DelimitedTextReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DelimitedTextReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDelimitedTextReadSettings(document.RootElement);
            }
        }
    }
}
