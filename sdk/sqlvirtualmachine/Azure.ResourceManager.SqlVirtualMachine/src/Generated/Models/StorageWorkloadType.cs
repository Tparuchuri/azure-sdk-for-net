// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Storage workload type. </summary>
    public readonly partial struct StorageWorkloadType : IEquatable<StorageWorkloadType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageWorkloadType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageWorkloadType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeneralValue = "GENERAL";
        private const string OltpValue = "OLTP";
        private const string DWValue = "DW";

        /// <summary> GENERAL. </summary>
        public static StorageWorkloadType General { get; } = new StorageWorkloadType(GeneralValue);
        /// <summary> OLTP. </summary>
        public static StorageWorkloadType Oltp { get; } = new StorageWorkloadType(OltpValue);
        /// <summary> DW. </summary>
        public static StorageWorkloadType DW { get; } = new StorageWorkloadType(DWValue);
        /// <summary> Determines if two <see cref="StorageWorkloadType"/> values are the same. </summary>
        public static bool operator ==(StorageWorkloadType left, StorageWorkloadType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageWorkloadType"/> values are not the same. </summary>
        public static bool operator !=(StorageWorkloadType left, StorageWorkloadType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageWorkloadType"/>. </summary>
        public static implicit operator StorageWorkloadType(string value) => new StorageWorkloadType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageWorkloadType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageWorkloadType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
