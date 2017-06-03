using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.SqlServer;

namespace EF6Test
{
    using System.Diagnostics;

    public class CodeBaseDbConfiguration : DbConfiguration
    {
        public CodeBaseDbConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }    
    
    public class CommonDbContext : DbContext
    {
        public CommonDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Database.Log = s => Debug.Write(s);
            Configuration.LazyLoadingEnabled = false;
        }

        public static string GetTableName(string typeName)
        {
            const string namePattern = "Data";

            if (!typeName.EndsWith(namePattern))
                return typeName;

            var concertedTableName = typeName.Remove(typeName.Length - namePattern.Length);

            return concertedTableName != string.Empty ? concertedTableName : typeName;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Types().Configure(c => c.ToTable(GetTableName(c.ClrType.Name)));

            modelBuilder.Properties<string>()
                .Where(x => x.Name.EndsWith("Name"))
                .Configure(c => c.HasMaxLength(150));

            modelBuilder.Properties<string>()
                .Where(x => x.Name.EndsWith("Content"))
                .Configure(c => c.HasMaxLength(2000));
        }        
    }
}