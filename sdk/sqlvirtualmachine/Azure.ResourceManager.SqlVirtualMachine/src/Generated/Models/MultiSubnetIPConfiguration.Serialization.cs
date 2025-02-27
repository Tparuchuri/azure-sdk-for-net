// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class MultiSubnetIPConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("privateIpAddress");
            writer.WriteObjectValue(PrivateIPAddress);
            writer.WritePropertyName("sqlVirtualMachineInstance");
            writer.WriteStringValue(SqlVirtualMachineInstance);
            writer.WriteEndObject();
        }

        internal static MultiSubnetIPConfiguration DeserializeMultiSubnetIPConfiguration(JsonElement element)
        {
            PrivateIPAddress privateIPAddress = default;
            string sqlVirtualMachineInstance = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateIpAddress"))
                {
                    privateIPAddress = PrivateIPAddress.DeserializePrivateIPAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlVirtualMachineInstance"))
                {
                    sqlVirtualMachineInstance = property.Value.GetString();
                    continue;
                }
            }
            return new MultiSubnetIPConfiguration(privateIPAddress, sqlVirtualMachineInstance);
        }
    }
}
