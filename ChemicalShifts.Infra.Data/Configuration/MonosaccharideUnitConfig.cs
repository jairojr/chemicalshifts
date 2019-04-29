using ChemicalShifts.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChemicalShifts.Infra.Data.Configuration
{
    public class MonosaccharideUnitConfig : BaseConfig<MonosaccharideUnit>
    {
        public new void Configure(EntityTypeBuilder<MonosaccharideUnit> builder)
        {
            builder.Property(c => c.Name).IsRequired();

            builder.HasMany(c => c.ChemicalShifts);

            base.Configure(builder);
        }
    }
}
