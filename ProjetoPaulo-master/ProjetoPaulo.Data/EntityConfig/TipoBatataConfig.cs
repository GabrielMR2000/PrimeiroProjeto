using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPaulo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPaulo.Data.EntityConfig
{
    public class TipoBatatConfig : IEntityTypeConfiguration<TipoBatata>
    {
        public void Configure(EntityTypeBuilder<TipoBatata> builder)
        {
            builder.ToTable("tb_tipo_batata");

            builder.HasKey(e => e.Id).HasName("pk_tb_tipo_batata");

            builder.Property(e => e.Id)
                .HasColumnName("tipo_bat_id")
                .IsRequired();

            builder.Property(e => e.Descricao)
                .HasColumnName("tipo_bat_descricao")
                .IsRequired();
        }
    }
}
