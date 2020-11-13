using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Vault.Data.Context.Core;
using Vault.Data.Models.Core;
using Vault.Data.Repositories.Core;

namespace Vault.Data.Repositories.Dynamo
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IRecord
    {
        private readonly DynamoDBContext _context;
        private readonly IDbSet _dbSet;

        public Repository(IAmazonDynamoDB dynamoDbClient, IDbSet dbSet)
        {
            _context = new DynamoDBContext(dynamoDbClient);
            _dbSet = dbSet;
        }

        public async Task<TEntity> Get(string id)
        {
            return await _context.LoadAsync<TEntity>(id, "current");
        }

        public void Add(TEntity record)
        {
            _dbSet.Add(record);
        }
    }
}