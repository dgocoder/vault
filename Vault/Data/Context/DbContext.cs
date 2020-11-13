using System.Threading.Tasks;
using Vault.Data.Context.Core;
using Vault.Data.Repositories.Core;

namespace Vault.Data.Context
{
    public class DbContext : IDbContext
    {
        public ISecretRepository Secrets { get; set; }
        private IDbSet Db { get; set; }

        public DbContext(ISecretRepository secretRepository, IDbSet dbSet)
        {
            Secrets = secretRepository;
            Db = dbSet;
        }

        public async Task Commit()
        {
            await Db.Commit();
        }
    }
}