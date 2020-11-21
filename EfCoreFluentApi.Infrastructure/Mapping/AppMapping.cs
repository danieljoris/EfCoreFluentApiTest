using EfCoreFluentApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreFluentApi.Infrastructure.Mapping
{

    public class AppMapping : IEntityTypeConfiguration<App>
    {
        public void Configure(EntityTypeBuilder<App> builder)
        {
            
        }
    }

    public class AppSettingsMapping : IEntityTypeConfiguration<AppSettings>
    {
        public void Configure(EntityTypeBuilder<AppSettings> builder)
        {
            builder.OwnsMany(m => m.Settings, p =>
            {
                p.Property(e => e.Key)
                    .HasColumnName("Key")
                    .HasMaxLength(150);

                p.Property(e => e.Type)
                    .HasColumnName("Type")
                    .HasMaxLength(150)
                    .HasConversion(Converters.TypeStringConverter);

                p.Property(e => e.Value)
                    .HasColumnName("Value")
                    .HasMaxLength(350);

                p.ToTable(nameof(AppSettings));
            });

        }
    }


    public static class Converters
    {

        public static ValueConverter TypeStringConverter = new ValueConverter<Type, string>(
            v => v.ToString(),
            v => Type.GetType(v) == null ? Type.GetType(v) : null
        );
    }
}
