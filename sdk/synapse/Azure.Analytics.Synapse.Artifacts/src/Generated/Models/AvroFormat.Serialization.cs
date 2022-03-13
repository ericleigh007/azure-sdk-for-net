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
    [JsonConverter(typeof(AvroFormatConverter))]
    public partial class AvroFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Serializer);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Serializer.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Deserializer);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Deserializer.ToString()).RootElement);
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

        internal static AvroFormat DeserializeAvroFormat(JsonElement element)
        {
            string type = default;
            Optional<BinaryData> serializer = default;
            Optional<BinaryData> deserializer = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serializer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serializer = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("deserializer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deserializer = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AvroFormat(type, serializer.Value, deserializer.Value, additionalProperties);
        }

        internal partial class AvroFormatConverter : JsonConverter<AvroFormat>
        {
            public override void Write(Utf8JsonWriter writer, AvroFormat model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AvroFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAvroFormat(document.RootElement);
            }
        }
    }
}
