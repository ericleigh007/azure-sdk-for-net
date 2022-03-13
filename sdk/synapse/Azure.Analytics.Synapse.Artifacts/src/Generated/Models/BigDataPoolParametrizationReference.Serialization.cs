// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(BigDataPoolParametrizationReferenceConverter))]
    public partial class BigDataPoolParametrizationReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ReferenceName);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(ReferenceName.ToString()).RootElement);
#endif
            writer.WriteEndObject();
        }

        internal static BigDataPoolParametrizationReference DeserializeBigDataPoolParametrizationReference(JsonElement element)
        {
            BigDataPoolReferenceType type = default;
            BinaryData referenceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new BigDataPoolReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"))
                {
                    referenceName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new BigDataPoolParametrizationReference(type, referenceName);
        }

        internal partial class BigDataPoolParametrizationReferenceConverter : JsonConverter<BigDataPoolParametrizationReference>
        {
            public override void Write(Utf8JsonWriter writer, BigDataPoolParametrizationReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override BigDataPoolParametrizationReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeBigDataPoolParametrizationReference(document.RootElement);
            }
        }
    }
}
