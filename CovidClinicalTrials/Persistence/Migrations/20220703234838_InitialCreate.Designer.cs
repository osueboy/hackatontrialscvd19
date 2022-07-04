﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(EfContext))]
    [Migration("20220703234838_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Domain.Entities.ClinicalTrialRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Acronym")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BridgedType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Bridging")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Countries")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateEnrollement")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateRegistration")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateRegistration3")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExclusionCriteria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExportDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Intervention")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastRefreshedOn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherRecords")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimaryOutcome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimarySponsor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PublicTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RecruitmentStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Results")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ResultsDateCompleted")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ResultsDatePosted")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ResultsUrlLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Retrospective")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ScientificTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceRegister")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudyDesign")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudyType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TargetSize")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WebAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Trials");
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Affiliation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Domain.Entities.ClinicalTrialRecord", b =>
                {
                    b.HasOne("Domain.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Domain.Entities.Inclusion", "Inclusion", b1 =>
                        {
                            b1.Property<string>("ClinicalTrialRecordId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("AgeMax")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("AgeMin")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Gender")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("InclusionText")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("ClinicalTrialRecordId");

                            b1.ToTable("Trials");

                            b1.WithOwner()
                                .HasForeignKey("ClinicalTrialRecordId");
                        });

                    b.Navigation("Contact");

                    b.Navigation("Inclusion")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
