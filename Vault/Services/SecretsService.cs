using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Secrets;
using Vault.Data.Context.Core;

namespace Vault.Services
{
    public class SecretsService : Secret.SecretBase
    {
        private readonly ILogger<SecretsService> _logger;
        private readonly IDbContext _context;

        public SecretsService(ILogger<SecretsService> logger, IDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override async Task<SecretReply> GetSecret(SecretRequest request, ServerCallContext context)
        {
            var secret = await _context.Secrets.Get("rbi/dev/bk/gateway");
            _context.Secrets.Add(secret);
            _context.Secrets.Add(secret);
            // await _context.Commit();
            return new SecretReply
            {
                Name = secret.Name,
                Values = Value.Parser.ParseJson(secret.Values),
                CreatedAt = Timestamp.FromDateTimeOffset(secret.CreatedAt),
                UpdatedAt = Timestamp.FromDateTimeOffset(secret.UpdatedAt)
            };
        }
    }
}