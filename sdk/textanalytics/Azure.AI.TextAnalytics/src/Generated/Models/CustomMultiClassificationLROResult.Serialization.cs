// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class CustomMultiClassificationLROResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("results");
            writer.WriteObjectValue(Results);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName");
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("lastUpdateDateTime");
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToString());
            writer.WriteEndObject();
        }

        internal static CustomMultiClassificationLROResult DeserializeCustomMultiClassificationLROResult(JsonElement element)
        {
            CustomMultiClassificationResult results = default;
            AnalyzeTextLROResultsKind kind = default;
            Optional<string> taskName = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextAnalyticsOperationStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = CustomMultiClassificationResult.DeserializeCustomMultiClassificationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new CustomMultiClassificationLROResult(lastUpdateDateTime, status, kind, taskName.Value, results);
        }
    }
}
