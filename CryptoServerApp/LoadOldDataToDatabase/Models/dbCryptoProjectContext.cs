using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LoadOldDataToDatabase.Models
{
    public partial class dbCryptoProjectContext : DbContext
    {
        public dbCryptoProjectContext()
        {
        }

        public dbCryptoProjectContext(DbContextOptions<dbCryptoProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CryptoDataModel> CryptoDataModels { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=dbCryptoProject;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Croatian_CI_AS");

            modelBuilder.Entity<CryptoDataModel>(entity =>
            {
                entity.ToTable("cryptoDataModel");

                entity.Property(e => e.AdavalueEur).HasColumnName("ADAvalueEUR");

                entity.Property(e => e.AdavalueUsd).HasColumnName("ADAvalueUSD");

                entity.Property(e => e.BtcvalueEur).HasColumnName("BTCvalueEUR");

                entity.Property(e => e.BtcvalueUsd).HasColumnName("BTCvalueUSD");

                entity.Property(e => e.DogevalueEur).HasColumnName("DOGEvalueEUR");

                entity.Property(e => e.DogevalueUsd).HasColumnName("DOGEvalueUSD");

                entity.Property(e => e.DotvalueEur).HasColumnName("DOTvalueEUR");

                entity.Property(e => e.DotvalueUsd).HasColumnName("DOTvalueUSD");

                entity.Property(e => e.EthvalueEur).HasColumnName("ETHvalueEUR");

                entity.Property(e => e.EthvalueUsd).HasColumnName("ETHvalueUSD");

                entity.Property(e => e.LtcvalueEur).HasColumnName("LTCvalueEUR");

                entity.Property(e => e.LtcvalueUsd).HasColumnName("LTCvalueUSD");

                entity.Property(e => e.MaticvalueEur).HasColumnName("MATICvalueEUR");

                entity.Property(e => e.MaticvalueUsd).HasColumnName("MATICvalueUSD");

                entity.Property(e => e.SolvalueEur).HasColumnName("SOLvalueEUR");

                entity.Property(e => e.SolvalueUsd).HasColumnName("SOLvalueUSD");

                entity.Property(e => e.TimeNow)
                    .HasColumnType("datetime")
                    .HasColumnName("timeNow");

                entity.Property(e => e.TrxvalueEur).HasColumnName("TRXvalueEUR");

                entity.Property(e => e.TrxvalueUsd).HasColumnName("TRXvalueUSD");

                entity.Property(e => e.XrpvalueEur).HasColumnName("XRPvalueEUR");

                entity.Property(e => e.XrpvalueUsd).HasColumnName("XRPvalueUSD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
