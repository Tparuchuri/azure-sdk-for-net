// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralAppNameAvailabilityContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ResourceType);
            }
            writer.WriteEndObject();
        }
    }
}
