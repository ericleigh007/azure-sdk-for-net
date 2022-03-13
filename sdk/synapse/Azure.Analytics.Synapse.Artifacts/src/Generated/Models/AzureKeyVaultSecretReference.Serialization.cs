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
    [JsonConverter(typeof(AzureKeyVaultSecretReferenceConverter))]
    public partial class AzureKeyVaultSecretReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("store");
            writer.WriteObjectValue(Store);
            writer.WritePropertyName("secretName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SecretName);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(SecretName.ToString()).RootElement);
#endif
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SecretVersion);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SecretVersion.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static AzureKeyVaultSecretReference DeserializeAzureKeyVaultSecretReference(JsonElement element)
        {
            LinkedServiceReference store = default;
            BinaryData secretName = default;
            Optional<BinaryData> secretVersion = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("store"))
                {
                    store = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("secretName"))
                {
                    secretName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("secretVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    secretVersion = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new AzureKeyVaultSecretReference(type, store, secretName, secretVersion.Value);
        }

        internal partial class AzureKeyVaultSecretReferenceConverter : JsonConverter<AzureKeyVaultSecretReference>
        {
            public override void Write(Utf8JsonWriter writer, AzureKeyVaultSecretReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureKeyVaultSecretReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureKeyVaultSecretReference(document.RootElement);
            }
        }
    }
}
