﻿//
// CmisRepositoryShortInfo.cs
//
// Author:
//       Dannys Janssen
//
// Copyright (c) 2017 Dannys Janssen
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace Cmis.Model
{
    using System;
    using System.Collections.Generic;
    using Cmis.Infrastructure;

	/// <summary>
	/// CMIS repository info containing only identifier and name.
	/// </summary>
	public class CmisRepositoryShortInfo : ICmisRepositoryShortInfo
    {
		/// <summary>
		/// Gets the CMIS repository identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string RepositoryId { get; set; }

		/// <summary>
		/// Gets the CMIS repository display name.
		/// </summary>
		/// <value>The display name.</value>
		public string RepositoryName { get; set; }

        /// <summary>
        /// Gets or sets the repository URL.
        /// </summary>
        /// <value>The repository URL.</value>
        public string RepositoryUrl { get; set; }

		/// <summary>
		/// Gets the CMIS repository URL.
		/// </summary>
		/// <value>The repository URL.</value>
		public string RootFolderUrl { get; set; }

		/// <summary>
		/// Gets or sets the list of CMIS extensions.
		/// </summary>
		/// <value>The list of CMIS extensions.</value>
		public IList<ICmisExtensionElement> Extensions { get; set; }
    }
}