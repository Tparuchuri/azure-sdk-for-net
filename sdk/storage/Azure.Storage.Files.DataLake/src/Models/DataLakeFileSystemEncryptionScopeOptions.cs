﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary>
    /// Encryption scope options to be used when creating a file system.
    /// </summary>
    public class DataLakeFileSystemEncryptionScopeOptions
    {
        /// <summary>
        /// Specifies the default encryption scope to set on the file system and use for all future writes.
        /// </summary>
        public string DefaultEncryptionScope { get; set; }
    }
}
