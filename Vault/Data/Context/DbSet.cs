using System.Collections.Generic;
using System.Threading.Tasks;
using Vault.Data.Context.Core;
using Vault.Data.Models.Core;

namespace Vault.Data.Context
{
    public class DbSet : IDbSet
    {
        private List<(DbSetAction, object)> stagedRecords = new List<(DbSetAction, object)>();

        public void Add(IRecord record)
        {
            stagedRecords.Add((DbSetAction.Add, record));
        }

        public void Update(IRecord record)
        {
            stagedRecords.Add((DbSetAction.Update, record));
        }

        public void Delete(string id)
        {
            stagedRecords.Add((DbSetAction.Delete, id));
        }

        public Task Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}