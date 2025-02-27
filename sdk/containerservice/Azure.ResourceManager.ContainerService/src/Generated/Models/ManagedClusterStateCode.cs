// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Tells whether the cluster is Running or Stopped. </summary>
    public readonly partial struct ManagedClusterStateCode : IEquatable<ManagedClusterStateCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterStateCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedClusterStateCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "Running";
        private const string StoppedValue = "Stopped";

        /// <summary> The cluster is running. </summary>
        public static ManagedClusterStateCode Running { get; } = new ManagedClusterStateCode(RunningValue);
        /// <summary> The cluster is stopped. </summary>
        public static ManagedClusterStateCode Stopped { get; } = new ManagedClusterStateCode(StoppedValue);
        /// <summary> Determines if two <see cref="ManagedClusterStateCode"/> values are the same. </summary>
        public static bool operator ==(ManagedClusterStateCode left, ManagedClusterStateCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedClusterStateCode"/> values are not the same. </summary>
        public static bool operator !=(ManagedClusterStateCode left, ManagedClusterStateCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedClusterStateCode"/>. </summary>
        public static implicit operator ManagedClusterStateCode(string value) => new ManagedClusterStateCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedClusterStateCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedClusterStateCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
