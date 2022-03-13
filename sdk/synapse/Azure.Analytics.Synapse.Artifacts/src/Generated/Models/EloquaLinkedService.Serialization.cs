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
    [JsonConverter(typeof(EloquaLinkedServiceConverter))]
    public partial class EloquaLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("endpoint");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Endpoint);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Endpoint.ToString()).RootElement);
#endif
            writer.WritePropertyName("username");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Username);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Username.ToString()).RootElement);
#endif
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(UseEncryptedEndpoints))
            {
                writer.WritePropertyName("useEncryptedEndpoints");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UseEncryptedEndpoints);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UseEncryptedEndpoints.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(UseHostVerification))
            {
                writer.WritePropertyName("useHostVerification");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UseHostVerification);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UseHostVerification.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(UsePeerVerification))
            {
                writer.WritePropertyName("usePeerVerification");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UsePeerVerification);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UsePeerVerification.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EncryptedCredential);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EncryptedCredential.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
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

        internal static EloquaLinkedService DeserializeEloquaLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            BinaryData endpoint = default;
            BinaryData username = default;
            Optional<SecretBase> password = default;
            Optional<BinaryData> useEncryptedEndpoints = default;
            Optional<BinaryData> useHostVerification = default;
            Optional<BinaryData> usePeerVerification = default;
            Optional<BinaryData> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(property.Value.GetRawText()));
                    }
                    annotations = array;
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
                        if (property0.NameEquals("endpoint"))
                        {
                            endpoint = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("username"))
                        {
                            username = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("useEncryptedEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useEncryptedEndpoints = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("useHostVerification"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useHostVerification = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("usePeerVerification"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usePeerVerification = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new EloquaLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, endpoint, username, password.Value, useEncryptedEndpoints.Value, useHostVerification.Value, usePeerVerification.Value, encryptedCredential.Value);
        }

        internal partial class EloquaLinkedServiceConverter : JsonConverter<EloquaLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, EloquaLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EloquaLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEloquaLinkedService(document.RootElement);
            }
        }
    }
}
