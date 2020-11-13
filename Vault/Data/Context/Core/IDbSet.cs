using System.Threading.Tasks;
using Vault.Data.Models.Core;

namespace Vault.Data.Context.Core
{
    public interface IDbSet
    {
        void Add(IRecord record);
        void Update(IRecord record);
        void Delete(string id);
        Task Commit();
    }
}