using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MarketApp.Models
{
    public partial class Dev_MarketContext : DbContext
    {
        public virtual DbSet<MarketWatch22002018> MarketWatch22002018 { get; set; }
        public virtual DbSet<QuarterlyResultBrief> QuarterlyResultBrief { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=Shivangini;Initial Catalog=Dev_Market;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarketWatch22002018>(entity =>
            {
                entity.ToTable("MarketWatch_22_00_2018");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.High)
                    .HasColumnName("High ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Low)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ltp)
                    .HasColumnName("LTP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfSharesTraded)
                    .HasColumnName("No  of Shares Traded ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfTrades)
                    .HasColumnName("No  of Trades")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Open)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityCode)
                    .HasColumnName("Security Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityGroup)
                    .HasColumnName("Security Group")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityName)
                    .HasColumnName("Security Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalTurnoverImgSrcIncludeImagesRsGifAltMyImageLac)
                    .HasColumnName("Total Turnover  (<img src '         include images rs gif' alt 'my image'  > Lac)")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuarterlyResultBrief>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ceps)
                    .HasColumnName("ceps")
                    .HasMaxLength(500);

                entity.Property(e => e.Depereciation)
                    .HasColumnName("depereciation")
                    .HasMaxLength(500);

                entity.Property(e => e.Eps)
                    .HasColumnName("eps")
                    .HasMaxLength(500);

                entity.Property(e => e.Equity)
                    .HasColumnName("equity")
                    .HasMaxLength(500);

                entity.Property(e => e.Expenditure).HasMaxLength(500);

                entity.Property(e => e.Interest)
                    .HasColumnName("interest")
                    .HasMaxLength(500);

                entity.Property(e => e.NetProfit)
                    .HasColumnName("net_Profit")
                    .HasMaxLength(500);

                entity.Property(e => e.Npm)
                    .HasColumnName("npm")
                    .HasMaxLength(500);

                entity.Property(e => e.Opm)
                    .HasColumnName("opm")
                    .HasMaxLength(500);

                entity.Property(e => e.OtherIncome)
                    .HasColumnName("Other_Income")
                    .HasMaxLength(500);

                entity.Property(e => e.Pbdt)
                    .HasColumnName("PBDT")
                    .HasMaxLength(500);

                entity.Property(e => e.Pbt)
                    .HasColumnName("pbt")
                    .HasMaxLength(500);

                entity.Property(e => e.Quarter).HasMaxLength(50);

                entity.Property(e => e.Revenue).HasMaxLength(500);

                entity.Property(e => e.SecurityName)
                    .HasColumnName("security_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.SecurityNumber)
                    .HasColumnName("security_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasMaxLength(500);

                entity.Property(e => e.TotalIncome)
                    .HasColumnName("Total_Income")
                    .HasMaxLength(500);
            });
        }
    }
}
