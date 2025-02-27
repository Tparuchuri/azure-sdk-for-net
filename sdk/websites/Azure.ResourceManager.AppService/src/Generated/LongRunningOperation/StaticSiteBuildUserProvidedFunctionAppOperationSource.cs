// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    internal class StaticSiteBuildUserProvidedFunctionAppOperationSource : IOperationSource<StaticSiteBuildUserProvidedFunctionAppResource>
    {
        private readonly ArmClient _client;

        internal StaticSiteBuildUserProvidedFunctionAppOperationSource(ArmClient client)
        {
            _client = client;
        }

        StaticSiteBuildUserProvidedFunctionAppResource IOperationSource<StaticSiteBuildUserProvidedFunctionAppResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StaticSiteUserProvidedFunctionAppARMData.DeserializeStaticSiteUserProvidedFunctionAppARMData(document.RootElement);
            return new StaticSiteBuildUserProvidedFunctionAppResource(_client, data);
        }

        async ValueTask<StaticSiteBuildUserProvidedFunctionAppResource> IOperationSource<StaticSiteBuildUserProvidedFunctionAppResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StaticSiteUserProvidedFunctionAppARMData.DeserializeStaticSiteUserProvidedFunctionAppARMData(document.RootElement);
            return new StaticSiteBuildUserProvidedFunctionAppResource(_client, data);
        }
    }
}
