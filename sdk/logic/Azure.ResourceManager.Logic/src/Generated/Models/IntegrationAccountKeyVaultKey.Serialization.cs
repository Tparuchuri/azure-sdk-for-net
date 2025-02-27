// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountKeyVaultKey
    {
        internal static IntegrationAccountKeyVaultKey DeserializeIntegrationAccountKeyVaultKey(JsonElement element)
        {
            Optional<string> kid = default;
            Optional<bool> enabled = default;
            Optional<long> created = default;
            Optional<long> updated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kid"))
                {
                    kid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("created"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            created = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("updated"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updated = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IntegrationAccountKeyVaultKey(kid.Value, Optional.ToNullable(enabled), Optional.ToNullable(created), Optional.ToNullable(updated));
        }
    }
}
