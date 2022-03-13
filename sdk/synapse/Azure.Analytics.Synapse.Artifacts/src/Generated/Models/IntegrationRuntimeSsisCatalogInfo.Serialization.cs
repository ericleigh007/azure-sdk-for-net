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
    [JsonConverter(typeof(IntegrationRuntimeSsisCatalogInfoConverter))]
    public partial class IntegrationRuntimeSsisCatalogInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogServerEndpoint))
            {
                writer.WritePropertyName("catalogServerEndpoint");
                writer.WriteStringValue(CatalogServerEndpoint);
            }
            if (Optional.IsDefined(CatalogAdminUserName))
            {
                writer.WritePropertyName("catalogAdminUserName");
                writer.WriteStringValue(CatalogAdminUserName);
            }
            if (Optional.IsDefined(CatalogAdminPassword))
            {
                writer.WritePropertyName("catalogAdminPassword");
                writer.WriteObjectValue(CatalogAdminPassword);
            }
            if (Optional.IsDefined(CatalogPricingTier))
            {
                writer.WritePropertyName("catalogPricingTier");
                writer.WriteStringValue(CatalogPricingTier.Value.ToString());
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

        internal static IntegrationRuntimeSsisCatalogInfo DeserializeIntegrationRuntimeSsisCatalogInfo(JsonElement element)
        {
            Optional<string> catalogServerEndpoint = default;
            Optional<string> catalogAdminUserName = default;
            Optional<SecureString> catalogAdminPassword = default;
            Optional<IntegrationRuntimeSsisCatalogPricingTier> catalogPricingTier = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogServerEndpoint"))
                {
                    catalogServerEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("catalogAdminUserName"))
                {
                    catalogAdminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("catalogAdminPassword"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    catalogAdminPassword = SecureString.DeserializeSecureString(property.Value);
                    continue;
                }
                if (property.NameEquals("catalogPricingTier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    catalogPricingTier = new IntegrationRuntimeSsisCatalogPricingTier(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeSsisCatalogInfo(catalogServerEndpoint.Value, catalogAdminUserName.Value, catalogAdminPassword.Value, Optional.ToNullable(catalogPricingTier), additionalProperties);
        }

        internal partial class IntegrationRuntimeSsisCatalogInfoConverter : JsonConverter<IntegrationRuntimeSsisCatalogInfo>
        {
            public override void Write(Utf8JsonWriter writer, IntegrationRuntimeSsisCatalogInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override IntegrationRuntimeSsisCatalogInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIntegrationRuntimeSsisCatalogInfo(document.RootElement);
            }
        }
    }
}
