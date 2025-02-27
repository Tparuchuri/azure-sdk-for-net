// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The JSON schema. </summary>
    public partial class LogicJsonSchema
    {
        /// <summary> Initializes a new instance of LogicJsonSchema. </summary>
        internal LogicJsonSchema()
        {
        }

        /// <summary> Initializes a new instance of LogicJsonSchema. </summary>
        /// <param name="title"> The JSON title. </param>
        /// <param name="content"> The JSON content. </param>
        internal LogicJsonSchema(string title, string content)
        {
            Title = title;
            Content = content;
        }

        /// <summary> The JSON title. </summary>
        public string Title { get; }
        /// <summary> The JSON content. </summary>
        public string Content { get; }
    }
}
