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
    [JsonConverter(typeof(AzureDatabricksDeltaLakeImportCommandConverter))]
    public partial class AzureDatabricksDeltaLakeImportCommand : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DateFormat);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DateFormat.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(TimestampFormat))
            {
                writer.WritePropertyName("timestampFormat");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TimestampFormat);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(TimestampFormat.ToString()).RootElement);
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

        internal static AzureDatabricksDeltaLakeImportCommand DeserializeAzureDatabricksDeltaLakeImportCommand(JsonElement element)
        {
            Optional<BinaryData> dateFormat = default;
            Optional<BinaryData> timestampFormat = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateFormat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateFormat = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("timestampFormat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestampFormat = BinaryData.FromString(property.Value.GetRawText());
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
            return new AzureDatabricksDeltaLakeImportCommand(type, additionalProperties, dateFormat.Value, timestampFormat.Value);
        }

        internal partial class AzureDatabricksDeltaLakeImportCommandConverter : JsonConverter<AzureDatabricksDeltaLakeImportCommand>
        {
            public override void Write(Utf8JsonWriter writer, AzureDatabricksDeltaLakeImportCommand model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureDatabricksDeltaLakeImportCommand Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureDatabricksDeltaLakeImportCommand(document.RootElement);
            }
        }
    }
}
