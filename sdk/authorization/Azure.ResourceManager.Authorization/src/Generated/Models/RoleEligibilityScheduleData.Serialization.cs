// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class RoleEligibilityScheduleData
    {
        internal static RoleEligibilityScheduleData DeserializeRoleEligibilityScheduleData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> scope = default;
            Optional<ResourceIdentifier> roleDefinitionId = default;
            Optional<string> principalId = default;
            Optional<PrincipalType> principalType = default;
            Optional<ResourceIdentifier> roleEligibilityScheduleRequestId = default;
            Optional<MemberType> memberType = default;
            Optional<RoleEligibilityScheduleStatus> status = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> endDateTime = default;
            Optional<string> condition = default;
            Optional<string> conditionVersion = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<DateTimeOffset> updatedOn = default;
            Optional<ExpandedProperties> expandedProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("scope"))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("roleDefinitionId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roleDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("principalId"))
                        {
                            principalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("principalType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            principalType = new PrincipalType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("roleEligibilityScheduleRequestId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roleEligibilityScheduleRequestId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("memberType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            memberType = new MemberType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new RoleEligibilityScheduleStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("condition"))
                        {
                            condition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("conditionVersion"))
                        {
                            conditionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expandedProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expandedProperties = ExpandedProperties.DeserializeExpandedProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoleEligibilityScheduleData(id, name, type, systemData.Value, scope.Value, roleDefinitionId.Value, principalId.Value, Optional.ToNullable(principalType), roleEligibilityScheduleRequestId.Value, Optional.ToNullable(memberType), Optional.ToNullable(status), Optional.ToNullable(startDateTime), Optional.ToNullable(endDateTime), condition.Value, conditionVersion.Value, Optional.ToNullable(createdOn), Optional.ToNullable(updatedOn), expandedProperties.Value);
        }
    }
}
