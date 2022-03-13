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
    [JsonConverter(typeof(FtpReadSettingsConverter))]
    public partial class FtpReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Recursive);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Recursive.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(WildcardFolderPath))
            {
                writer.WritePropertyName("wildcardFolderPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WildcardFolderPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WildcardFolderPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(WildcardFileName))
            {
                writer.WritePropertyName("wildcardFileName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WildcardFileName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WildcardFileName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EnablePartitionDiscovery))
            {
                writer.WritePropertyName("enablePartitionDiscovery");
                writer.WriteBooleanValue(EnablePartitionDiscovery.Value);
            }
            if (Optional.IsDefined(PartitionRootPath))
            {
                writer.WritePropertyName("partitionRootPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PartitionRootPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PartitionRootPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DeleteFilesAfterCompletion))
            {
                writer.WritePropertyName("deleteFilesAfterCompletion");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DeleteFilesAfterCompletion);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DeleteFilesAfterCompletion.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(FileListPath))
            {
                writer.WritePropertyName("fileListPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FileListPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FileListPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(UseBinaryTransfer))
            {
                writer.WritePropertyName("useBinaryTransfer");
                writer.WriteBooleanValue(UseBinaryTransfer.Value);
            }
            if (Optional.IsDefined(DisableChunking))
            {
                writer.WritePropertyName("disableChunking");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DisableChunking);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DisableChunking.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
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

        internal static FtpReadSettings DeserializeFtpReadSettings(JsonElement element)
        {
            Optional<BinaryData> recursive = default;
            Optional<BinaryData> wildcardFolderPath = default;
            Optional<BinaryData> wildcardFileName = default;
            Optional<bool> enablePartitionDiscovery = default;
            Optional<BinaryData> partitionRootPath = default;
            Optional<BinaryData> deleteFilesAfterCompletion = default;
            Optional<BinaryData> fileListPath = default;
            Optional<bool> useBinaryTransfer = default;
            Optional<BinaryData> disableChunking = default;
            string type = default;
            Optional<BinaryData> maxConcurrentConnections = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recursive = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wildcardFolderPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("wildcardFileName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wildcardFileName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enablePartitionDiscovery = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("partitionRootPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionRootPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("deleteFilesAfterCompletion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deleteFilesAfterCompletion = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileListPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileListPath = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("useBinaryTransfer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useBinaryTransfer = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableChunking"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableChunking = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
            return new FtpReadSettings(type, maxConcurrentConnections.Value, additionalProperties, recursive.Value, wildcardFolderPath.Value, wildcardFileName.Value, Optional.ToNullable(enablePartitionDiscovery), partitionRootPath.Value, deleteFilesAfterCompletion.Value, fileListPath.Value, Optional.ToNullable(useBinaryTransfer), disableChunking.Value);
        }

        internal partial class FtpReadSettingsConverter : JsonConverter<FtpReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, FtpReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override FtpReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeFtpReadSettings(document.RootElement);
            }
        }
    }
}
