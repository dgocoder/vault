using System.Threading.Tasks;
using Vault.Data.Repositories.Core;

namespace Vault.Data.Context.Core
{
    public interface IDbContext
    {
        public ISecretRepository Secrets { get; set; }
        public Task Commit();
    }
}