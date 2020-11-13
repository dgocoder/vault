using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Vault.Data.Context.Core;
using Vault.Data.Models;
using Vault.Data.Repositories.Core;

namespace Vault.Data.Repositories.Dynamo
{
    public class SecretRepository : Repository<Secret>, ISecretRepository
    {
        public SecretRepository(IAmazonDynamoDB dynamoDbClient, IDbSet dbSet) : base(dynamoDbClient, dbSet)
        {
        }
    }
}