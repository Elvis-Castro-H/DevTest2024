﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PollAPI.Contexts;

#nullable disable

namespace PollAPI.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20241109145854_OptionMap")]
    partial class OptionMap
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PollAPI.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PollId")
                        .HasColumnType("integer");

                    b.Property<int>("Votes")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("PollId");

                    b.ToTable("Option", (string)null);
                });

            modelBuilder.Entity("PollAPI.Models.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Poll", (string)null);
                });

            modelBuilder.Entity("PollAPI.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("OptionId")
                        .HasColumnType("integer");

                    b.Property<int?>("PollId")
                        .HasColumnType("integer");

                    b.Property<string>("VoterEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("OptionId");

                    b.HasIndex("PollId");

                    b.ToTable("Vote", (string)null);
                });

            modelBuilder.Entity("PollAPI.Models.Option", b =>
                {
                    b.HasOne("PollAPI.Models.Poll", "Poll")
                        .WithMany("Options")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("PollAPI.Models.Vote", b =>
                {
                    b.HasOne("PollAPI.Models.Option", "Option")
                        .WithMany("VotesList")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PollAPI.Models.Poll", null)
                        .WithMany("Votes")
                        .HasForeignKey("PollId");

                    b.Navigation("Option");
                });

            modelBuilder.Entity("PollAPI.Models.Option", b =>
                {
                    b.Navigation("VotesList");
                });

            modelBuilder.Entity("PollAPI.Models.Poll", b =>
                {
                    b.Navigation("Options");

                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
