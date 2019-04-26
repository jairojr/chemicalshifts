using ChemicalShifts.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChemicalShifts.Infra.Data.Configuration
{
    public class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasIndex(c => c.Id);
            builder.Property(c => c.Created).IsRequired();
            builder.Property(c => c.Altered).IsRequired();
        }
    }
}
