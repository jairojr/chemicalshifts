using ChemicalShifts.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChemicalShifts.Infra.Data.Configuration
{
    public class UserConfig : BaseConfig<User>
    {
        public new void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Login).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Password).IsRequired();

            base.Configure(builder);
        }
    }
}