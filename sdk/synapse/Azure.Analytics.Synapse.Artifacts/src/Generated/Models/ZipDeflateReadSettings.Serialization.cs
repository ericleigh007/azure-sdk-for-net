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
    [JsonConverter(typeof(ZipDeflateReadSettingsConverter))]
    public partial class ZipDeflateReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PreserveZipFileNameAsFolder))
            {
                writer.WritePropertyName("preserveZipFileNameAsFolder");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PreserveZipFileNameAsFolder);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PreserveZipFileNameAsFolder.ToString()).RootElement);
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

        internal static ZipDeflateReadSettings DeserializeZipDeflateReadSettings(JsonElement element)
        {
            Optional<BinaryData> preserveZipFileNameAsFolder = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveZipFileNameAsFolder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preserveZipFileNameAsFolder = BinaryData.FromString(property.Value.GetRawText());
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
            return new ZipDeflateReadSettings(type, additionalProperties, preserveZipFileNameAsFolder.Value);
        }

        internal partial class ZipDeflateReadSettingsConverter : JsonConverter<ZipDeflateReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, ZipDeflateReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ZipDeflateReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeZipDeflateReadSettings(document.RootElement);
            }
        }
    }
}
