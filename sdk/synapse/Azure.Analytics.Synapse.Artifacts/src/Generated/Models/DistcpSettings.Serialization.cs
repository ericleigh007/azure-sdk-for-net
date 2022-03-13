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
    [JsonConverter(typeof(DistcpSettingsConverter))]
    public partial class DistcpSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceManagerEndpoint");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ResourceManagerEndpoint);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(ResourceManagerEndpoint.ToString()).RootElement);
#endif
            writer.WritePropertyName("tempScriptPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TempScriptPath);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(TempScriptPath.ToString()).RootElement);
#endif
            if (Optional.IsDefined(DistcpOptions))
            {
                writer.WritePropertyName("distcpOptions");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DistcpOptions);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DistcpOptions.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DistcpSettings DeserializeDistcpSettings(JsonElement element)
        {
            BinaryData resourceManagerEndpoint = default;
            BinaryData tempScriptPath = default;
            Optional<BinaryData> distcpOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceManagerEndpoint"))
                {
                    resourceManagerEndpoint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tempScriptPath"))
                {
                    tempScriptPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("distcpOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    distcpOptions = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new DistcpSettings(resourceManagerEndpoint, tempScriptPath, distcpOptions.Value);
        }

        internal partial class DistcpSettingsConverter : JsonConverter<DistcpSettings>
        {
            public override void Write(Utf8JsonWriter writer, DistcpSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DistcpSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDistcpSettings(document.RootElement);
            }
        }
    }
}
