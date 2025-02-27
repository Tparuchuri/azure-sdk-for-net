// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Represents an output file produced. </summary>
    public partial class OutputFile
    {
        /// <summary> Initializes a new instance of OutputFile. </summary>
        /// <param name="labels"> The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like &apos;[v1, a1]&apos; tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="labels"/> is null. </exception>
        public OutputFile(IEnumerable<string> labels)
        {
            if (labels == null)
            {
                throw new ArgumentNullException(nameof(labels));
            }

            Labels = labels.ToList();
        }

        /// <summary> Initializes a new instance of OutputFile. </summary>
        /// <param name="labels"> The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like &apos;[v1, a1]&apos; tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1. </param>
        internal OutputFile(IList<string> labels)
        {
            Labels = labels;
        }

        /// <summary> The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like &apos;[v1, a1]&apos; tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1. </summary>
        public IList<string> Labels { get; }
    }
}
