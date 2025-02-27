﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.FormRecognizer.DocumentAnalysis.Tests
{
    /// <summary>
    /// The suite of tests for the <see cref="DocumentModelAdministrationClientTests"/> class.
    /// </summary>
    public class DocumentModelAdministrationClientTests : ClientTestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentModelAdministrationClientTests"/> class.
        /// </summary>
        /// <param name="isAsync">A flag used by the Azure Core Test Framework to differentiate between tests for asynchronous and synchronous methods.</param>
        public DocumentModelAdministrationClientTests(bool isAsync)
            : base(isAsync)
        {
        }

        /// <summary>
        /// Creates a fake <see cref="DocumentModelAdministrationClient" /> and instruments it to make use of the Azure Core
        /// Test Framework functionalities.
        /// </summary>
        /// <returns>The instrumented <see cref="DocumentModelAdministrationClient" />.</returns>
        private DocumentModelAdministrationClient CreateInstrumentedClient(DocumentAnalysisClientOptions options = default)
        {
            var fakeEndpoint = new Uri("http://notreal.azure.com/");
            var fakeCredential = new AzureKeyCredential("fakeKey");

            options ??= new DocumentAnalysisClientOptions(){ Retry = { Delay = TimeSpan.Zero, Mode = RetryMode.Fixed}};
            var client = new DocumentModelAdministrationClient(fakeEndpoint, fakeCredential, options);

            return client;
        }

        /// <summary>
        /// Verifies functionality of the <see cref="DocumentModelAdministrationClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheEndpoint()
        {
            var tokenCredential = new DefaultAzureCredential();
            var keyCredential = new AzureKeyCredential("key");

            Assert.Throws<ArgumentNullException>(() => new DocumentModelAdministrationClient(null, tokenCredential));
            Assert.Throws<ArgumentNullException>(() => new DocumentModelAdministrationClient(null, tokenCredential, new DocumentAnalysisClientOptions()));
            Assert.Throws<ArgumentNullException>(() => new DocumentModelAdministrationClient(null, keyCredential));
            Assert.Throws<ArgumentNullException>(() => new DocumentModelAdministrationClient(null, keyCredential, new DocumentAnalysisClientOptions()));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="DocumentModelAdministrationClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheTokenCredential()
        {
            var endpoint = new Uri("http://localhost");

            Assert.Throws<ArgumentNullException>(() => new DocumentModelAdministrationClient(endpoint, default(TokenCredential)));
            Assert.Throws<ArgumentNullException>(() => new DocumentModelAdministrationClient(endpoint, default(TokenCredential), new DocumentAnalysisClientOptions()));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="DocumentModelAdministrationClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheAzureKeyCredential()
        {
            var endpoint = new Uri("http://localhost");

            Assert.Throws<ArgumentNullException>(() => new DocumentModelAdministrationClient(endpoint, default(AzureKeyCredential)));
            Assert.Throws<ArgumentNullException>(() => new DocumentModelAdministrationClient(endpoint, default(AzureKeyCredential), new DocumentAnalysisClientOptions()));
        }

        [Test]
        public async Task ClientThrowsWithNonExistingResourceEndpoint()
        {
            var client = CreateInstrumentedClient();

            try
            {
                await client.GetResourceDetailsAsync();
            }
            catch (AggregateException ex)
            {
                var innerExceptions = ex.InnerExceptions.ToList();
                Assert.IsTrue(innerExceptions.All(ex => ex is RequestFailedException));
            }
        }

        [Test]
        public void StartBuildModelArgumentValidation()
        {
            var client = CreateInstrumentedClient();

            Assert.ThrowsAsync<UriFormatException>(() => client.BuildModelAsync(WaitUntil.Started, new Uri(string.Empty), DocumentBuildMode.Template));
            Assert.ThrowsAsync<ArgumentNullException>(() => client.BuildModelAsync(WaitUntil.Started, (Uri)null, DocumentBuildMode.Template));
            Assert.Throws<UriFormatException>(() => client.BuildModel(WaitUntil.Started, new Uri(string.Empty), DocumentBuildMode.Template));
            Assert.Throws<ArgumentNullException>(() => client.BuildModel(WaitUntil.Started, (Uri)null, DocumentBuildMode.Template));
        }

        [Test]
        public void GetModelArgumentValidation()
        {
            var client = CreateInstrumentedClient();

            Assert.ThrowsAsync<ArgumentNullException>(() => client.GetModelAsync(null));
            Assert.ThrowsAsync<ArgumentException>(() => client.GetModelAsync(string.Empty));
        }

        [Test]
        public void DeleteModelArgumentValidation()
        {
            var client = CreateInstrumentedClient();

            Assert.ThrowsAsync<ArgumentNullException>(() => client.DeleteModelAsync(null));
            Assert.ThrowsAsync<ArgumentException>(() => client.DeleteModelAsync(string.Empty));
        }

        [Test]
        public void StartCopyModelArgumentValidation()
        {
            var copyAuth = new CopyAuthorization("<resourceId>", "<region>", "<modelId>", "<modelLocation>", "<accesstoken>", default);

            var client = CreateInstrumentedClient();

            Assert.ThrowsAsync<ArgumentNullException>(() => client.CopyModelToAsync(WaitUntil.Started, null, copyAuth));
            Assert.ThrowsAsync<ArgumentException>(() => client.CopyModelToAsync(WaitUntil.Started, string.Empty, copyAuth));
        }

        [Test]
        public void StartCreateComposedModelArgumentValidation()
        {
            var client = CreateInstrumentedClient();

            Assert.ThrowsAsync<ArgumentNullException>(() => client.ComposeModelAsync(WaitUntil.Started, null));
        }

        [Test]
        public void GetOperationArgumentValidation()
        {
            var client = CreateInstrumentedClient();

            Assert.ThrowsAsync<ArgumentNullException>(() => client.GetOperationAsync(null));
            Assert.ThrowsAsync<ArgumentException>(() => client.GetOperationAsync(string.Empty));
        }
    }
}
