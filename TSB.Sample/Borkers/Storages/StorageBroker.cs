using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TheStandardBox.Data.Brokers.StandardStorages;
using TSB.Sample.Models.Engineers;

namespace TSB.Sample.Borkers.Storages
{
    public class StorageBroker : StandardStorageBroker
    {
        public StorageBroker(IConfiguration configuration)
            : base(configuration)
        { }

        public DbSet<Engineer> Engineers { get; set; }
    }
}