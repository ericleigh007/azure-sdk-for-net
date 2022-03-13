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
    [JsonConverter(typeof(AmazonRdsForOraclePartitionSettingsConverter))]
    public partial class AmazonRdsForOraclePartitionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionNames))
            {
                writer.WritePropertyName("partitionNames");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PartitionNames);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PartitionNames.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PartitionColumnName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PartitionColumnName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PartitionUpperBound))
            {
                writer.WritePropertyName("partitionUpperBound");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PartitionUpperBound);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PartitionUpperBound.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PartitionLowerBound))
            {
                writer.WritePropertyName("partitionLowerBound");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PartitionLowerBound);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PartitionLowerBound.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static AmazonRdsForOraclePartitionSettings DeserializeAmazonRdsForOraclePartitionSettings(JsonElement element)
        {
            Optional<BinaryData> partitionNames = default;
            Optional<BinaryData> partitionColumnName = default;
            Optional<BinaryData> partitionUpperBound = default;
            Optional<BinaryData> partitionLowerBound = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionNames = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionColumnName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionColumnName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionUpperBound = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionLowerBound = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new AmazonRdsForOraclePartitionSettings(partitionNames.Value, partitionColumnName.Value, partitionUpperBound.Value, partitionLowerBound.Value);
        }

        internal partial class AmazonRdsForOraclePartitionSettingsConverter : JsonConverter<AmazonRdsForOraclePartitionSettings>
        {
            public override void Write(Utf8JsonWriter writer, AmazonRdsForOraclePartitionSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AmazonRdsForOraclePartitionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAmazonRdsForOraclePartitionSettings(document.RootElement);
            }
        }
    }
}
