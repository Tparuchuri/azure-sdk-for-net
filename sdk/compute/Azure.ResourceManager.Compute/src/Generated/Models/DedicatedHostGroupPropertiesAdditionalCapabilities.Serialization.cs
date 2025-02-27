// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class DedicatedHostGroupPropertiesAdditionalCapabilities : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UltraSsdEnabled))
            {
                writer.WritePropertyName("ultraSSDEnabled");
                writer.WriteBooleanValue(UltraSsdEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static DedicatedHostGroupPropertiesAdditionalCapabilities DeserializeDedicatedHostGroupPropertiesAdditionalCapabilities(JsonElement element)
        {
            Optional<bool> ultraSsdEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ultraSSDEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ultraSsdEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DedicatedHostGroupPropertiesAdditionalCapabilities(Optional.ToNullable(ultraSsdEnabled));
        }
    }
}
