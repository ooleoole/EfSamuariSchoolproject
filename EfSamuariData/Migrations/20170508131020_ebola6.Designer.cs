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
    [Migration("20170508131020_ebola6")]
    partial class ebola6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfSamuariDomain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BattleLogId");

                    b.Property<string>("Descrpition");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Location");

                    b.Property<DateTime>("StarTime");

                    b.HasKey("Id");

                    b.HasIndex("BattleLogId");

                    b.ToTable("Battle");
                });

            modelBuilder.Entity("EfSamuariDomain.BattleEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BattleLogId");

                    b.Property<string>("Description");

                    b.Property<string>("Event");

                    b.Property<DateTime>("EventTime");

                    b.Property<int>("SamuraiId");

                    b.HasKey("Id");

                    b.HasAlternateKey("SamuraiId", "EventTime");

                    b.HasIndex("BattleLogId");

                    b.ToTable("BattleEvents");
                });

            modelBuilder.Entity("EfSamuariDomain.BattleLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BattleLogs");
                });

            modelBuilder.Entity("EfSamuariDomain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SamuraiId");

                    b.Property<string>("SamuraiQuote");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("EfSamuariDomain.SamuariBattle", b =>
                {
                    b.Property<int>("BattleId");

                    b.Property<int>("SamuraiId");

                    b.HasKey("BattleId", "SamuraiId");

                    b.HasIndex("SamuraiId");

                    b.ToTable("SamuariBattles");
                });

            modelBuilder.Entity("EfSamuariDomain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clan");

                    b.Property<int>("HairCut");

                    b.Property<bool>("HasSword");

                    b.Property<string>("Name");

                    b.Property<int?>("SecretIdentityId");

                    b.HasKey("Id");

                    b.HasIndex("SecretIdentityId");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("EfSamuariDomain.SecretIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RealName");

                    b.HasKey("Id");

                    b.ToTable("SecretIdentity");
                });

            modelBuilder.Entity("EfSamuariDomain.Battle", b =>
                {
                    b.HasOne("EfSamuariDomain.BattleLog", "BattleLog")
                        .WithMany()
                        .HasForeignKey("BattleLogId");
                });

            modelBuilder.Entity("EfSamuariDomain.BattleEvent", b =>
                {
                    b.HasOne("EfSamuariDomain.BattleLog", "BattleLog")
                        .WithMany("BattleEvents")
                        .HasForeignKey("BattleLogId");

                    b.HasOne("EfSamuariDomain.Samurai", "Samurai")
                        .WithMany("BattleEvents")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfSamuariDomain.Quote", b =>
                {
                    b.HasOne("EfSamuariDomain.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId");
                });

            modelBuilder.Entity("EfSamuariDomain.SamuariBattle", b =>
                {
                    b.HasOne("EfSamuariDomain.Battle", "Battle")
                        .WithMany("Battles")
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfSamuariDomain.Samurai", "Samurai")
                        .WithMany("Battles")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfSamuariDomain.Samurai", b =>
                {
                    b.HasOne("EfSamuariDomain.SecretIdentity", "SecretIdentity")
                        .WithMany()
                        .HasForeignKey("SecretIdentityId");
                });
        }
    }
}
