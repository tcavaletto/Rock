﻿// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.Storage.AssetStorage
{
    public class Asset
    {
        /// <summary>
        /// The name of the asset as it should appear to the end user. The name should be the last segment of the key.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// The name of the asset as it needs to be on the cloud service ( i.e. includes all folder names)
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>
        /// The URI.
        /// </value>
        public string Uri { get; set; }

        /// <summary>
        /// File or folder
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public AssetType Type { get; set; }

        /// <summary>
        /// The Font Awesom class to represent the file
        /// </summary>
        /// <value>
        /// The icon CSS class.
        /// </value>
        public string IconCssClass { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        /// <value>
        /// The size of the file.
        /// </value>
        public long FileSize { get; set; }

        public string FormattedFileSize
        {
            get
            {
                return FileSize.FormatAsMemorySize();
            }
        }
        /// <summary>
        /// Gets or sets the last modified date time.
        /// </summary>
        /// <value>
        /// The last modified date time.
        /// </value>
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the description. Free form text for desired meta data provided by the storage provider.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the asset stream. Use when downloading an object to associate the stream with the
        /// file info.
        /// </summary>
        /// <value>
        /// The asset stream.
        /// </value>
        public Stream AssetStream { get; set; }
    }

    public enum AssetType
    {
        File,
        Folder
    }
}