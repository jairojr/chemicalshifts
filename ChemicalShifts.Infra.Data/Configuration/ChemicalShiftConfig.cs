using ChemicalShifts.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChemicalShifts.Infra.Data.Configuration
{
    public class ChemicalShiftConfig : BaseConfig<ChemicalShift>
    {
        public new void Configure(EntityTypeBuilder<ChemicalShift> builder)
        {
            builder.HasOne(c => c.AcademicArticle).WithMany(c => c.ChemicalShifts);

            builder.HasOne(c => c.MonosaccharideUnit).WithMany(c => c.ChemicalShifts);

            base.Configure(builder);
        }
    }
}
