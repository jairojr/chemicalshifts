using ChemicalShifts.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChemicalShifts.Infra.Data.Configuration
{
    public class AcademicArticleConfig : BaseConfig<AcademicArticle>
    {
        public new void Configure(EntityTypeBuilder<AcademicArticle> builder)
        {
            builder.Property(c => c.Name).IsRequired();

            builder.HasMany(c => c.ChemicalShifts).WithOne(c => c.AcademicArticle);

            base.Configure(builder);
        }
    }
}
