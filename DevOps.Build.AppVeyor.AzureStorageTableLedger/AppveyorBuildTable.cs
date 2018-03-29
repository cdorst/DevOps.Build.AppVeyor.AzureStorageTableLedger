// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage.Table;

namespace DevOps.Build.AppVeyor.AzureStorageTableLedger
{
    /// <summary>Azure Table Storage entity representing a successfully completed AppVeyor build</summary>
    public class AppveyorBuildTable : TableEntity
    {
        public AppveyorBuildTable()
        {
        }

        public AppveyorBuildTable(string name, string version, string dependencies = null, string fileHashes = null)
        {
            Dependencies = dependencies;
            FileHashes = fileHashes;
            PartitionKey = name;
            RowKey = version;
        }

        /// <summary>Comma-delimited string of repository dependencies in {name}|{version} format</summary>
        public string Dependencies { get; set; }

        /// <summary>Comma-delimited string of repository file hashes</summary>
        public string FileHashes { get; set; }
    }
}
