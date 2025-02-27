// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExecuteWranglingDataflowActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(ActivityType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("dataFlow");
            writer.WriteObjectValue(DataFlow);
            if (Optional.IsDefined(Staging))
            {
                writer.WritePropertyName("staging");
                writer.WriteObjectValue(Staging);
            }
            if (Optional.IsDefined(IntegrationRuntime))
            {
                writer.WritePropertyName("integrationRuntime");
                writer.WriteObjectValue(IntegrationRuntime);
            }
            if (Optional.IsDefined(Compute))
            {
                writer.WritePropertyName("compute");
                writer.WriteObjectValue(Compute);
            }
            if (Optional.IsDefined(TraceLevel))
            {
                writer.WritePropertyName("traceLevel");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TraceLevel);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(TraceLevel.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ContinueOnError))
            {
                writer.WritePropertyName("continueOnError");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ContinueOnError);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ContinueOnError.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(RunConcurrently))
            {
                writer.WritePropertyName("runConcurrently");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RunConcurrently);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(RunConcurrently.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SourceStagingConcurrency))
            {
                writer.WritePropertyName("sourceStagingConcurrency");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SourceStagingConcurrency);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SourceStagingConcurrency.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(Sinks))
            {
                writer.WritePropertyName("sinks");
                writer.WriteStartObject();
                foreach (var item in Sinks)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Queries))
            {
                writer.WritePropertyName("queries");
                writer.WriteStartArray();
                foreach (var item in Queries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ExecuteWranglingDataflowActivity DeserializeExecuteWranglingDataflowActivity(JsonElement element)
        {
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            DataFlowReference dataFlow = default;
            Optional<DataFlowStagingInfo> staging = default;
            Optional<IntegrationRuntimeReference> integrationRuntime = default;
            Optional<ExecuteDataFlowActivityTypePropertiesCompute> compute = default;
            Optional<BinaryData> traceLevel = default;
            Optional<BinaryData> continueOnError = default;
            Optional<BinaryData> runConcurrently = default;
            Optional<BinaryData> sourceStagingConcurrency = default;
            Optional<IDictionary<string, PowerQuerySink>> sinks = default;
            Optional<IList<PowerQuerySinkMapping>> queries = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataFlow"))
                        {
                            dataFlow = DataFlowReference.DeserializeDataFlowReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("staging"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            staging = DataFlowStagingInfo.DeserializeDataFlowStagingInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("integrationRuntime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            integrationRuntime = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("compute"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            compute = ExecuteDataFlowActivityTypePropertiesCompute.DeserializeExecuteDataFlowActivityTypePropertiesCompute(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("traceLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            traceLevel = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("continueOnError"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            continueOnError = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("runConcurrently"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            runConcurrently = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sourceStagingConcurrency"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceStagingConcurrency = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, PowerQuerySink> dictionary = new Dictionary<string, PowerQuerySink>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, PowerQuerySink.DeserializePowerQuerySink(property1.Value));
                            }
                            sinks = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("queries"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PowerQuerySinkMapping> array = new List<PowerQuerySinkMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PowerQuerySinkMapping.DeserializePowerQuerySinkMapping(item));
                            }
                            queries = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ExecuteWranglingDataflowActivity(name, type, description.Value, Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, policy.Value, dataFlow, staging.Value, integrationRuntime.Value, compute.Value, traceLevel.Value, continueOnError.Value, runConcurrently.Value, sourceStagingConcurrency.Value, Optional.ToDictionary(sinks), Optional.ToList(queries));
        }
    }
}
