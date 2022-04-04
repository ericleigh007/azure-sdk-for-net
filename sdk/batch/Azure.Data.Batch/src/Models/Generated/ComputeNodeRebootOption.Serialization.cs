// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.Batch.Models
{
    internal static partial class ComputeNodeRebootOptionExtensions
    {
        public static string ToSerialString(this ComputeNodeRebootOption value) => value switch
        {
            ComputeNodeRebootOption.Requeue => "requeue",
            ComputeNodeRebootOption.Terminate => "terminate",
            ComputeNodeRebootOption.TaskCompletion => "taskcompletion",
            ComputeNodeRebootOption.RetainedData => "retaineddata",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ComputeNodeRebootOption value.")
        };

        public static ComputeNodeRebootOption ToComputeNodeRebootOption(this string value)
        {
            if (string.Equals(value, "requeue", StringComparison.InvariantCultureIgnoreCase)) return ComputeNodeRebootOption.Requeue;
            if (string.Equals(value, "terminate", StringComparison.InvariantCultureIgnoreCase)) return ComputeNodeRebootOption.Terminate;
            if (string.Equals(value, "taskcompletion", StringComparison.InvariantCultureIgnoreCase)) return ComputeNodeRebootOption.TaskCompletion;
            if (string.Equals(value, "retaineddata", StringComparison.InvariantCultureIgnoreCase)) return ComputeNodeRebootOption.RetainedData;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ComputeNodeRebootOption value.");
        }
    }
}
