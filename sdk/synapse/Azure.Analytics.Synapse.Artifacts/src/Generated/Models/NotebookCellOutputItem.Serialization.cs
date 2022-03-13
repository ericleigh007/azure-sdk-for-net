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
    [JsonConverter(typeof(NotebookCellOutputItemConverter))]
    public partial class NotebookCellOutputItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ExecutionCount))
            {
                writer.WritePropertyName("execution_count");
                writer.WriteNumberValue(ExecutionCount.Value);
            }
            writer.WritePropertyName("output_type");
            writer.WriteStringValue(OutputType.ToString());
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text");
                writer.WriteObjectValue(Text);
            }
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Data);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Data.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Metadata.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static NotebookCellOutputItem DeserializeNotebookCellOutputItem(JsonElement element)
        {
            Optional<string> name = default;
            Optional<int> executionCount = default;
            CellOutputType outputType = default;
            Optional<object> text = default;
            Optional<BinaryData> data = default;
            Optional<BinaryData> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("execution_count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    executionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("output_type"))
                {
                    outputType = new CellOutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    text = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    data = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new NotebookCellOutputItem(name.Value, Optional.ToNullable(executionCount), outputType, text.Value, data.Value, metadata.Value);
        }

        internal partial class NotebookCellOutputItemConverter : JsonConverter<NotebookCellOutputItem>
        {
            public override void Write(Utf8JsonWriter writer, NotebookCellOutputItem model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override NotebookCellOutputItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookCellOutputItem(document.RootElement);
            }
        }
    }
}
