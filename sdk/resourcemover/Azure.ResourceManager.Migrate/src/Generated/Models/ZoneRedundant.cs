// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the zone redundant resource setting. </summary>
    public readonly partial struct ZoneRedundant : IEquatable<ZoneRedundant>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ZoneRedundant"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ZoneRedundant(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";

        /// <summary> Enable. </summary>
        public static ZoneRedundant Enable { get; } = new ZoneRedundant(EnableValue);
        /// <summary> Disable. </summary>
        public static ZoneRedundant Disable { get; } = new ZoneRedundant(DisableValue);
        /// <summary> Determines if two <see cref="ZoneRedundant"/> values are the same. </summary>
        public static bool operator ==(ZoneRedundant left, ZoneRedundant right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ZoneRedundant"/> values are not the same. </summary>
        public static bool operator !=(ZoneRedundant left, ZoneRedundant right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ZoneRedundant"/>. </summary>
        public static implicit operator ZoneRedundant(string value) => new ZoneRedundant(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ZoneRedundant other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ZoneRedundant other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
