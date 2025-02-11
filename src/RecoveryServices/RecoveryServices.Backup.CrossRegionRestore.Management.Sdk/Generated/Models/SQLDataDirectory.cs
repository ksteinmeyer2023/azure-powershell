// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using System.Linq;

    /// <summary>
    /// SQLDataDirectory info
    /// </summary>
    public partial class SQLDataDirectory
    {
        /// <summary>
        /// Initializes a new instance of the SQLDataDirectory class.
        /// </summary>
        public SQLDataDirectory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SQLDataDirectory class.
        /// </summary>

        /// <param name="type">Type of data directory mapping
        /// Possible values include: 'Invalid', 'Data', 'Log'</param>

        /// <param name="path">File path
        /// </param>

        /// <param name="logicalName">Logical name of the file
        /// </param>
        public SQLDataDirectory(string type = default(string), string path = default(string), string logicalName = default(string))

        {
            this.Type = type;
            this.Path = path;
            this.LogicalName = logicalName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets type of data directory mapping Possible values include: &#39;Invalid&#39;, &#39;Data&#39;, &#39;Log&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets file path
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "path")]
        public string Path {get; set; }

        /// <summary>
        /// Gets or sets logical name of the file
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "logicalName")]
        public string LogicalName {get; set; }
    }
}