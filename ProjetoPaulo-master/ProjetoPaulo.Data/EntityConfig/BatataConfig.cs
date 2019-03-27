using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPaulo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPaulo.Data.EntityConfig
{
    public class BatataConfig : IEntityTypeConfiguration<Batata>
    {
        public void Configure(EntityTypeBuilder<Batata> builder)
        {
            builder.ToTable("tb_batata");

            builder.HasKey(e => e.Id).HasName("pk_tb_batata");

            builder.Property(e => e.Id)
                .HasColumnName("bat_id")
                .IsRequired();

            builder.Property(e => e.Descricao)
                .HasColumnName("bat_descricao")
                .IsRequired();

            builder.Property(e => e.Cor)
                .HasColumnName("bat_cor");

            builder.Property(e => e.TipoBatataId)
                .HasColumnName("tipo_bat_id");
        }
    }
}
