// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class IntegrationRuntimeListResponse
    {
        internal static IntegrationRuntimeListResponse DeserializeIntegrationRuntimeListResponse(JsonElement element)
        {
            IReadOnlyList<IntegrationRuntimeResourceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<IntegrationRuntimeResourceData> array = new List<IntegrationRuntimeResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationRuntimeResourceData.DeserializeIntegrationRuntimeResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new IntegrationRuntimeListResponse(value, nextLink.Value);
        }
    }
}
