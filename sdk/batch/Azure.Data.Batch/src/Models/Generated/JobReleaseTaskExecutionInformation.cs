// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.Batch.Models
{
    /// <summary> Contains information about the execution of a Job Release Task on a Compute Node. </summary>
    public partial class JobReleaseTaskExecutionInformation
    {
        /// <summary> Initializes a new instance of JobReleaseTaskExecutionInformation. </summary>
        /// <param name="startTime"> If the Task has been restarted or retried, this is the most recent time at which the Task started running. </param>
        /// <param name="state"> The current state of the Job Release Task on the Compute Node. </param>
        internal JobReleaseTaskExecutionInformation(DateTimeOffset startTime, JobReleaseTaskState state)
        {
            StartTime = startTime;
            State = state;
        }

        /// <summary> Initializes a new instance of JobReleaseTaskExecutionInformation. </summary>
        /// <param name="startTime"> If the Task has been restarted or retried, this is the most recent time at which the Task started running. </param>
        /// <param name="endTime"> This property is set only if the Task is in the Completed state. </param>
        /// <param name="state"> The current state of the Job Release Task on the Compute Node. </param>
        /// <param name="taskRootDirectory"> The root directory of the Job Release Task on the Compute Node. You can use this path to retrieve files created by the Task, such as log files. </param>
        /// <param name="taskRootDirectoryUrl"> The URL to the root directory of the Job Release Task on the Compute Node. </param>
        /// <param name="exitCode"> This parameter is returned only if the Task is in the completed state. The exit code for a process reflects the specific convention implemented by the application developer for that process. If you use the exit code value to make decisions in your code, be sure that you know the exit code convention used by the application process. Note that the exit code may also be generated by the Compute Node operating system, such as when a process is forcibly terminated. </param>
        /// <param name="containerInfo"> This property is set only if the Task runs in a container context. </param>
        /// <param name="failureInfo"> This property is set only if the Task is in the completed state and encountered a failure. </param>
        /// <param name="result"> If the value is &apos;failed&apos;, then the details of the failure can be found in the failureInfo property. </param>
        internal JobReleaseTaskExecutionInformation(DateTimeOffset startTime, DateTimeOffset? endTime, JobReleaseTaskState state, string taskRootDirectory, string taskRootDirectoryUrl, int? exitCode, TaskContainerExecutionInformation containerInfo, TaskFailureInformation failureInfo, TaskExecutionResult? result)
        {
            StartTime = startTime;
            EndTime = endTime;
            State = state;
            TaskRootDirectory = taskRootDirectory;
            TaskRootDirectoryUrl = taskRootDirectoryUrl;
            ExitCode = exitCode;
            ContainerInfo = containerInfo;
            FailureInfo = failureInfo;
            Result = result;
        }

        /// <summary> If the Task has been restarted or retried, this is the most recent time at which the Task started running. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> This property is set only if the Task is in the Completed state. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The current state of the Job Release Task on the Compute Node. </summary>
        public JobReleaseTaskState State { get; }
        /// <summary> The root directory of the Job Release Task on the Compute Node. You can use this path to retrieve files created by the Task, such as log files. </summary>
        public string TaskRootDirectory { get; }
        /// <summary> The URL to the root directory of the Job Release Task on the Compute Node. </summary>
        public string TaskRootDirectoryUrl { get; }
        /// <summary> This parameter is returned only if the Task is in the completed state. The exit code for a process reflects the specific convention implemented by the application developer for that process. If you use the exit code value to make decisions in your code, be sure that you know the exit code convention used by the application process. Note that the exit code may also be generated by the Compute Node operating system, such as when a process is forcibly terminated. </summary>
        public int? ExitCode { get; }
        /// <summary> This property is set only if the Task runs in a container context. </summary>
        public TaskContainerExecutionInformation ContainerInfo { get; }
        /// <summary> This property is set only if the Task is in the completed state and encountered a failure. </summary>
        public TaskFailureInformation FailureInfo { get; }
        /// <summary> If the value is &apos;failed&apos;, then the details of the failure can be found in the failureInfo property. </summary>
        public TaskExecutionResult? Result { get; }
    }
}
