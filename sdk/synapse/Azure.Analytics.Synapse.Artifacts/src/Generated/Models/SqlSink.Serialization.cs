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
    [JsonConverter(typeof(SqlSinkConverter))]
    public partial class SqlSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlWriterStoredProcedureName))
            {
                writer.WritePropertyName("sqlWriterStoredProcedureName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SqlWriterStoredProcedureName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SqlWriterStoredProcedureName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SqlWriterTableType))
            {
                writer.WritePropertyName("sqlWriterTableType");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SqlWriterTableType);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SqlWriterTableType.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PreCopyScript))
            {
                writer.WritePropertyName("preCopyScript");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PreCopyScript);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PreCopyScript.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(StoredProcedureParameters))
            {
                writer.WritePropertyName("storedProcedureParameters");
                writer.WriteStartObject();
                foreach (var item in StoredProcedureParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(StoredProcedureTableTypeParameterName))
            {
                writer.WritePropertyName("storedProcedureTableTypeParameterName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(StoredProcedureTableTypeParameterName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(StoredProcedureTableTypeParameterName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(TableOption))
            {
                writer.WritePropertyName("tableOption");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TableOption);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(TableOption.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WriteBatchSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WriteBatchSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WriteBatchTimeout);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WriteBatchTimeout.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SinkRetryCount);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SinkRetryCount.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SinkRetryWait);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SinkRetryWait.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MaxConcurrentConnections);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MaxConcurrentConnections.ToString()).RootElement);
#endif
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

        internal static SqlSink DeserializeSqlSink(JsonElement element)
        {
            Optional<BinaryData> sqlWriterStoredProcedureName = default;
            Optional<BinaryData> sqlWriterTableType = default;
            Optional<BinaryData> preCopyScript = default;
            Optional<IDictionary<string, StoredProcedureParameter>> storedProcedureParameters = default;
            Optional<BinaryData> storedProcedureTableTypeParameterName = default;
            Optional<BinaryData> tableOption = default;
            string type = default;
            Optional<BinaryData> writeBatchSize = default;
            Optional<BinaryData> writeBatchTimeout = default;
            Optional<BinaryData> sinkRetryCount = default;
            Optional<BinaryData> sinkRetryWait = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlWriterStoredProcedureName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlWriterStoredProcedureName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sqlWriterTableType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlWriterTableType = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("preCopyScript"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preCopyScript = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("storedProcedureParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, StoredProcedureParameter> dictionary = new Dictionary<string, StoredProcedureParameter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, StoredProcedureParameter.DeserializeStoredProcedureParameter(property0.Value));
                    }
                    storedProcedureParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("storedProcedureTableTypeParameterName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storedProcedureTableTypeParameterName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tableOption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tableOption = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchSize = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchTimeout = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryCount = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryWait = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SqlSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, sqlWriterStoredProcedureName.Value, sqlWriterTableType.Value, preCopyScript.Value, Optional.ToDictionary(storedProcedureParameters), storedProcedureTableTypeParameterName.Value, tableOption.Value);
        }

        internal partial class SqlSinkConverter : JsonConverter<SqlSink>
        {
            public override void Write(Utf8JsonWriter writer, SqlSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SqlSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSqlSink(document.RootElement);
            }
        }
    }
}
