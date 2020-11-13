using System.Threading.Tasks;

namespace Vault.Data.Repositories.Core
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(string id);
        void Add(TEntity record);
    }
}