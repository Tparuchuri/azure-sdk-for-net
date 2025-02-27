﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer
{
    /// <summary>
    /// The set of options that can be specified when calling a Recognize Custom Forms method
    /// to configure the behavior of the request. For example, specify the content type of the
    /// form, or whether or not to include form elements.
    /// </summary>
    public class RecognizeCustomFormsOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeCustomFormsOptions"/> class which
        /// allows to set options that can be specified when calling a Recognize Custom Forms method
        /// to configure the behavior of the request. For example, specify the content type of the
        /// form, or whether or not to include form elements.
        /// </summary>
        public RecognizeCustomFormsOptions()
        {
        }

        /// <summary>
        /// Whether or not to include all lines per page and field elements such as lines, words,
        /// and selection marks for each form field.
        /// </summary>
        public bool IncludeFieldElements { get; set; }

        /// <summary>
        /// When set, specifies the content type for uploaded streams and skips automatic
        /// content type detection.
        /// </summary>
        public FormContentType? ContentType { get; set; }

        /// <summary>
        /// <para>
        /// Custom page numbers for multi-page documents(PDF/TIFF). Input the page numbers
        /// and/or ranges of pages you want to get in the result. For a range of pages, use a hyphen, like
        /// `Pages = { "1-3", "5-6" }`. Separate each page number or range with a comma.
        /// </para>
        /// <para>
        /// Although this collection cannot be set, it can be modified.
        /// See <see href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers#object-initializers-with-collection-read-only-property-initialization">Object initializers with collection read-only property initialization</see>.
        /// </para>
        /// </summary>
        /// <remarks>
        /// This property only has value for <see cref="FormRecognizerClientOptions.ServiceVersion.V2_1"/> and up.
        /// </remarks>
        public IList<string> Pages { get; } = new List<string>();
    }
}
