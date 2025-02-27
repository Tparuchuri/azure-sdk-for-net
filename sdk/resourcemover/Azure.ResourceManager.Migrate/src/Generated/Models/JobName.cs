// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the job name. </summary>
    public readonly partial struct JobName : IEquatable<JobName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitialSyncValue = "InitialSync";

        /// <summary> InitialSync. </summary>
        public static JobName InitialSync { get; } = new JobName(InitialSyncValue);
        /// <summary> Determines if two <see cref="JobName"/> values are the same. </summary>
        public static bool operator ==(JobName left, JobName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobName"/> values are not the same. </summary>
        public static bool operator !=(JobName left, JobName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobName"/>. </summary>
        public static implicit operator JobName(string value) => new JobName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
