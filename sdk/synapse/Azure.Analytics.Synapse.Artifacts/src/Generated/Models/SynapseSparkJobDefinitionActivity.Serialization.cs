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
    [JsonConverter(typeof(SynapseSparkJobDefinitionActivityConverter))]
    public partial class SynapseSparkJobDefinitionActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName");
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("sparkJob");
            writer.WriteObjectValue(SparkJob);
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("args");
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(File);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(File.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ClassName))
            {
                writer.WritePropertyName("className");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ClassName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ClassName.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files");
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetBigDataPool))
            {
                writer.WritePropertyName("targetBigDataPool");
                writer.WriteObjectValue(TargetBigDataPool);
            }
            if (Optional.IsDefined(ExecutorSize))
            {
                writer.WritePropertyName("executorSize");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ExecutorSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ExecutorSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Conf))
            {
                writer.WritePropertyName("conf");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Conf);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Conf.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(DriverSize))
            {
                writer.WritePropertyName("driverSize");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DriverSize);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DriverSize.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NumExecutors))
            {
                writer.WritePropertyName("numExecutors");
                writer.WriteNumberValue(NumExecutors.Value);
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

        internal static SynapseSparkJobDefinitionActivity DeserializeSynapseSparkJobDefinitionActivity(JsonElement element)
        {
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            SynapseSparkJobReference sparkJob = default;
            Optional<IList<object>> args = default;
            Optional<BinaryData> file = default;
            Optional<BinaryData> className = default;
            Optional<IList<object>> files = default;
            Optional<BigDataPoolParametrizationReference> targetBigDataPool = default;
            Optional<BinaryData> executorSize = default;
            Optional<BinaryData> conf = default;
            Optional<BinaryData> driverSize = default;
            Optional<int> numExecutors = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("dependsOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
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
                        if (property0.NameEquals("sparkJob"))
                        {
                            sparkJob = SynapseSparkJobReference.DeserializeSynapseSparkJobReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("args"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetObject());
                            }
                            args = array;
                            continue;
                        }
                        if (property0.NameEquals("file"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            file = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("className"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            className = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("files"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetObject());
                            }
                            files = array;
                            continue;
                        }
                        if (property0.NameEquals("targetBigDataPool"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetBigDataPool = BigDataPoolParametrizationReference.DeserializeBigDataPoolParametrizationReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("executorSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            executorSize = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("conf"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            conf = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("driverSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            driverSize = BinaryData.FromString(property.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("numExecutors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            numExecutors = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSparkJobDefinitionActivity(name, type, description.Value, Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName.Value, policy.Value, sparkJob, Optional.ToList(args), file.Value, className.Value, Optional.ToList(files), targetBigDataPool.Value, executorSize.Value, conf.Value, driverSize.Value, Optional.ToNullable(numExecutors));
        }

        internal partial class SynapseSparkJobDefinitionActivityConverter : JsonConverter<SynapseSparkJobDefinitionActivity>
        {
            public override void Write(Utf8JsonWriter writer, SynapseSparkJobDefinitionActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SynapseSparkJobDefinitionActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSynapseSparkJobDefinitionActivity(document.RootElement);
            }
        }
    }
}
