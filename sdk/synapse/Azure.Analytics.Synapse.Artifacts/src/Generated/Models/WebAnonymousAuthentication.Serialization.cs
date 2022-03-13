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
    [JsonConverter(typeof(WebAnonymousAuthenticationConverter))]
    public partial class WebAnonymousAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Url);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Url.ToString()).RootElement);
#endif
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            writer.WriteEndObject();
        }

        internal static WebAnonymousAuthentication DeserializeWebAnonymousAuthentication(JsonElement element)
        {
            BinaryData url = default;
            WebAuthenticationType authenticationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    url = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("authenticationType"))
                {
                    authenticationType = new WebAuthenticationType(property.Value.GetString());
                    continue;
                }
            }
            return new WebAnonymousAuthentication(url, authenticationType);
        }

        internal partial class WebAnonymousAuthenticationConverter : JsonConverter<WebAnonymousAuthentication>
        {
            public override void Write(Utf8JsonWriter writer, WebAnonymousAuthentication model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override WebAnonymousAuthentication Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebAnonymousAuthentication(document.RootElement);
            }
        }
    }
}
