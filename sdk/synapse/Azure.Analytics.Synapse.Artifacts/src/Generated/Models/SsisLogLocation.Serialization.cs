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
    [JsonConverter(typeof(SsisLogLocationConverter))]
    public partial class SsisLogLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("logPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(LogPath);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(LogPath.ToString()).RootElement);
#endif
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AccessCredential))
            {
                writer.WritePropertyName("accessCredential");
                writer.WriteObjectValue(AccessCredential);
            }
            if (Optional.IsDefined(LogRefreshInterval))
            {
                writer.WritePropertyName("logRefreshInterval");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(LogRefreshInterval);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(LogRefreshInterval.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SsisLogLocation DeserializeSsisLogLocation(JsonElement element)
        {
            BinaryData logPath = default;
            SsisLogLocationType type = default;
            Optional<SsisAccessCredential> accessCredential = default;
            Optional<BinaryData> logRefreshInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logPath"))
                {
                    logPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SsisLogLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accessCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("logRefreshInterval"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logRefreshInterval = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SsisLogLocation(logPath, type, accessCredential.Value, logRefreshInterval.Value);
        }

        internal partial class SsisLogLocationConverter : JsonConverter<SsisLogLocation>
        {
            public override void Write(Utf8JsonWriter writer, SsisLogLocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SsisLogLocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisLogLocation(document.RootElement);
            }
        }
    }
}
