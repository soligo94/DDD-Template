using DDD_Template.Core.ContributorAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Template.Infrastructure.Data.Config
{
    public class ContributorConfiguration : IEntityTypeConfiguration<Contributor>
    {
        public void Configure(EntityTypeBuilder<Contributor> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
                .IsRequired();

            builder.OwnsOne(builder => builder.PhoneNumber);

            builder.Property(x => x.Status)
              .HasConversion(
                  x => x.Value,
                  x => ContributorStatus.FromValue(x));
        }
    }

}
