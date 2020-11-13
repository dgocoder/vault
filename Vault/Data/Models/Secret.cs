using System;
using Amazon.DynamoDBv2.DataModel;
using Vault.Data.Models.Core;

namespace Vault.Data.Models
{
    [DynamoDBTable("rbi-account-secrets")]
    public class Secret : IRecord
    {
        [DynamoDBIgnore]
        public string Id { get; set; }

        [DynamoDBHashKey("pk")]
        public string Name { get; set; }

        [DynamoDBRangeKey("sk")]
        public string Version { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        [DynamoDBProperty("value")]
        public string Values { get; set; }
    }
}