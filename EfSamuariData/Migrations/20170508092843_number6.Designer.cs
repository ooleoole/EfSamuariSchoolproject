using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EfSamuariData;
using EfSamuariDomain;

namespace EfSamuariData.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    [Migration("20170508092843_number6")]
    partial class number6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfSamuariDomain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SamuraiId");

                    b.Property<string>("SamuraiQuote");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("EfSamuariDomain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clan");

                    b.Property<int>("HairCut");

                    b.Property<bool>("HasSword");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("EfSamuariDomain.Quote", b =>
                {
                    b.HasOne("EfSamuariDomain.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId");
                });
        }
    }
}
