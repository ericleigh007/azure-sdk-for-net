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
    [JsonConverter(typeof(Db2TableDatasetConverter))]
    public partial class Db2TableDataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Structure);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Structure.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Schema);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Schema.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
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
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TableName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(TableName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SchemaTypePropertiesSchema))
            {
                writer.WritePropertyName("schema");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SchemaTypePropertiesSchema);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SchemaTypePropertiesSchema.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Table);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Table.ToString()).RootElement);
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

        internal static Db2TableDataset DeserializeDb2TableDataset(JsonElement element)
        {
            string type = default;
            Optional<string> description = default;
            Optional<BinaryData> structure = default;
            Optional<BinaryData> schema = default;
            LinkedServiceReference linkedServiceName = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<DatasetFolder> folder = default;
            Optional<BinaryData> tableName = default;
            Optional<BinaryData> schema0 = default;
            Optional<BinaryData> table = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    structure = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("schema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schema = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
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
                if (property.NameEquals("folder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
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
                        if (property0.NameEquals("tableName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tableName = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("schema"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            schema0 = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("table"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            table = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new Db2TableDataset(type, description.Value, structure.Value, schema.Value, linkedServiceName, Optional.ToDictionary(parameters), Optional.ToList(annotations), folder.Value, additionalProperties, tableName.Value, schema0.Value, table.Value);
        }

        internal partial class Db2TableDatasetConverter : JsonConverter<Db2TableDataset>
        {
            public override void Write(Utf8JsonWriter writer, Db2TableDataset model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override Db2TableDataset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDb2TableDataset(document.RootElement);
            }
        }
    }
}
