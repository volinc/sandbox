using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EF6Test
{
    public static class DbModelBuilderExtensions
    {
        public static EntityTypeConfiguration<TEntityType> Entity<TEntityType>(this DbModelBuilder modelBuilder,
           Action<EntityTypeConfiguration<TEntityType>> builder) where TEntityType : class
        {
            builder.ThrowIfNull(nameof(builder));

            var typeConfiguration = modelBuilder.Entity<TEntityType>();
            builder(typeConfiguration);
            return typeConfiguration;
        }
    }
}
