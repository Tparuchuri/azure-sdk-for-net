// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class CertBasedSecurityPrincipal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Cert))
            {
                writer.WritePropertyName("cert");
                writer.WriteStringValue(Cert);
            }
            if (Optional.IsDefined(LedgerRoleName))
            {
                writer.WritePropertyName("ledgerRoleName");
                writer.WriteStringValue(LedgerRoleName.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static CertBasedSecurityPrincipal DeserializeCertBasedSecurityPrincipal(JsonElement element)
        {
            Optional<string> cert = default;
            Optional<LedgerRoleName> ledgerRoleName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cert"))
                {
                    cert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ledgerRoleName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ledgerRoleName = new LedgerRoleName(property.Value.GetString());
                    continue;
                }
            }
            return new CertBasedSecurityPrincipal(cert.Value, Optional.ToNullable(ledgerRoleName));
        }
    }
}
