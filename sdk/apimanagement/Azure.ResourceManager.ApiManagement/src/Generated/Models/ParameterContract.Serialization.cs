// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ParameterContract : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(ParameterContractType);
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue");
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsDefined(Required))
            {
                writer.WritePropertyName("required");
                writer.WriteBooleanValue(Required.Value);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values");
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SchemaId))
            {
                writer.WritePropertyName("schemaId");
                writer.WriteStringValue(SchemaId);
            }
            if (Optional.IsDefined(TypeName))
            {
                writer.WritePropertyName("typeName");
                writer.WriteStringValue(TypeName);
            }
            if (Optional.IsCollectionDefined(Examples))
            {
                writer.WritePropertyName("examples");
                writer.WriteStartObject();
                foreach (var item in Examples)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ParameterContract DeserializeParameterContract(JsonElement element)
        {
            string name = default;
            Optional<string> description = default;
            string type = default;
            Optional<string> defaultValue = default;
            Optional<bool> required = default;
            Optional<IList<string>> values = default;
            Optional<string> schemaId = default;
            Optional<string> typeName = default;
            Optional<IDictionary<string, ParameterExampleContract>> examples = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("schemaId"))
                {
                    schemaId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeName"))
                {
                    typeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("examples"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ParameterExampleContract> dictionary = new Dictionary<string, ParameterExampleContract>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterExampleContract.DeserializeParameterExampleContract(property0.Value));
                    }
                    examples = dictionary;
                    continue;
                }
            }
            return new ParameterContract(name, description.Value, type, defaultValue.Value, Optional.ToNullable(required), Optional.ToList(values), schemaId.Value, typeName.Value, Optional.ToDictionary(examples));
        }
    }
}
