// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Information about a pipeline run. </summary>
    public partial class PipelineRun
    {
        /// <summary> Initializes a new instance of PipelineRun. </summary>
        internal PipelineRun()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of PipelineRun. </summary>
        /// <param name="runId"> Identifier of a run. </param>
        /// <param name="runGroupId"> Identifier that correlates all the recovery runs of a pipeline run. </param>
        /// <param name="isLatest"> Indicates if the recovered pipeline run is the latest in its group. </param>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="parameters"> The full or partial list of parameter name, value pair used in the pipeline run. </param>
        /// <param name="invokedBy"> Entity that started the pipeline run. </param>
        /// <param name="lastUpdated"> The last updated timestamp for the pipeline run event in ISO8601 format. </param>
        /// <param name="runStart"> The start time of a pipeline run in ISO8601 format. </param>
        /// <param name="runEnd"> The end time of a pipeline run in ISO8601 format. </param>
        /// <param name="durationInMs"> The duration of a pipeline run. </param>
        /// <param name="status"> The status of a pipeline run. </param>
        /// <param name="message"> The message from a pipeline run. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PipelineRun(string runId, string runGroupId, bool? isLatest, string pipelineName, IReadOnlyDictionary<string, string> parameters, PipelineRunInvokedBy invokedBy, DateTimeOffset? lastUpdated, DateTimeOffset? runStart, DateTimeOffset? runEnd, int? durationInMs, string status, string message, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            RunId = runId;
            RunGroupId = runGroupId;
            IsLatest = isLatest;
            PipelineName = pipelineName;
            Parameters = parameters;
            InvokedBy = invokedBy;
            LastUpdated = lastUpdated;
            RunStart = runStart;
            RunEnd = runEnd;
            DurationInMs = durationInMs;
            Status = status;
            Message = message;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Identifier of a run. </summary>
        public string RunId { get; }
        /// <summary> Identifier that correlates all the recovery runs of a pipeline run. </summary>
        public string RunGroupId { get; }
        /// <summary> Indicates if the recovered pipeline run is the latest in its group. </summary>
        public bool? IsLatest { get; }
        /// <summary> The pipeline name. </summary>
        public string PipelineName { get; }
        /// <summary> The full or partial list of parameter name, value pair used in the pipeline run. </summary>
        public IReadOnlyDictionary<string, string> Parameters { get; }
        /// <summary> Entity that started the pipeline run. </summary>
        public PipelineRunInvokedBy InvokedBy { get; }
        /// <summary> The last updated timestamp for the pipeline run event in ISO8601 format. </summary>
        public DateTimeOffset? LastUpdated { get; }
        /// <summary> The start time of a pipeline run in ISO8601 format. </summary>
        public DateTimeOffset? RunStart { get; }
        /// <summary> The end time of a pipeline run in ISO8601 format. </summary>
        public DateTimeOffset? RunEnd { get; }
        /// <summary> The duration of a pipeline run. </summary>
        public int? DurationInMs { get; }
        /// <summary> The status of a pipeline run. </summary>
        public string Status { get; }
        /// <summary> The message from a pipeline run. </summary>
        public string Message { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
