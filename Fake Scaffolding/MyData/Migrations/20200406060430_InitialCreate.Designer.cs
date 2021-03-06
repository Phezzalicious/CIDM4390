﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyData.Data;

namespace MyData.Migrations
{
    [DbContext(typeof(CDKSTContext))]
    [Migration("20200406060430_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MyData.Models.Competency.Atomic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompositeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("prose_task_statement")
                        .HasColumnType("TEXT");

                    b.Property<string>("term_identifier")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CompositeID");

                    b.ToTable("Atomic");
                });

            modelBuilder.Entity("MyData.Models.Competency.Composite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompositeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("prose_task_statement")
                        .HasColumnType("TEXT");

                    b.Property<string>("term_identifier")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CompositeID");

                    b.ToTable("Composite");
                });

            modelBuilder.Entity("MyData.Models.Competency.KnowledgeSkill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AtomicID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("AtomicID");

                    b.ToTable("KnowledgeSkill");
                });

            modelBuilder.Entity("MyData.Models.Disposition.DispositionApplied", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("discipline")
                        .HasColumnType("TEXT");

                    b.Property<string>("location")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("DispositionApplied");
                });

            modelBuilder.Entity("MyData.Models.Disposition.DispositionDictionary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("discipline")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("DispositionDictionary");
                });

            modelBuilder.Entity("MyData.Models.Disposition.DispositionInstance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AtomicID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompositeID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DispositionDictionaryID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("appliedID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("cartesian_index")
                        .HasColumnType("INTEGER");

                    b.Property<string>("descriptor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("synonymID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("term_identifier")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AtomicID");

                    b.HasIndex("CompositeID");

                    b.HasIndex("DispositionDictionaryID");

                    b.HasIndex("appliedID");

                    b.HasIndex("synonymID");

                    b.ToTable("DispositionInstance");
                });

            modelBuilder.Entity("MyData.Models.Disposition.DispositionSynonym", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("language")
                        .HasColumnType("TEXT");

                    b.Property<string>("text")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("DispositionSynonym");
                });

            modelBuilder.Entity("MyData.Models.Knowledge.KnowledgeDictionary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("discipline")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("KnowledgeDictionary");
                });

            modelBuilder.Entity("MyData.Models.Knowledge.KnowledgeElement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KnowledgeDictionaryID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("cartesian_index")
                        .HasColumnType("INTEGER");

                    b.Property<string>("descriptor")
                        .HasColumnType("TEXT");

                    b.Property<string>("etymology")
                        .HasColumnType("TEXT");

                    b.Property<int>("semiotic_index")
                        .HasColumnType("INTEGER");

                    b.Property<string>("term_identifier")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("KnowledgeDictionaryID");

                    b.ToTable("KnowledgeElement");
                });

            modelBuilder.Entity("MyData.Models.Knowledge.KnowledgeSynonym", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KnowledgeElementID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("language")
                        .HasColumnType("TEXT");

                    b.Property<string>("text")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("KnowledgeElementID");

                    b.ToTable("KnowledgeSynonym");
                });

            modelBuilder.Entity("MyData.Models.Skill.SkillDictionary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("discipline")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("SkillDictionary");
                });

            modelBuilder.Entity("MyData.Models.Skill.SkillLevel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SkillDictionaryID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("cartesian_index")
                        .HasColumnType("INTEGER");

                    b.Property<string>("descriptor")
                        .HasColumnType("TEXT");

                    b.Property<string>("term_identifier")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("SkillDictionaryID");

                    b.ToTable("SkillLevel");
                });

            modelBuilder.Entity("MyData.Models.Skill.SkillVerbSynonym", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SkillLevelID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("language")
                        .HasColumnType("TEXT");

                    b.Property<string>("text")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("SkillLevelID");

                    b.ToTable("SkillVerbSynonym");
                });

            modelBuilder.Entity("MyData.Models.Task.Task", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("MyData.Models.Competency.Atomic", b =>
                {
                    b.HasOne("MyData.Models.Competency.Composite", null)
                        .WithMany("atomics")
                        .HasForeignKey("CompositeID");
                });

            modelBuilder.Entity("MyData.Models.Competency.Composite", b =>
                {
                    b.HasOne("MyData.Models.Competency.Composite", null)
                        .WithMany("composites")
                        .HasForeignKey("CompositeID");
                });

            modelBuilder.Entity("MyData.Models.Competency.KnowledgeSkill", b =>
                {
                    b.HasOne("MyData.Models.Competency.Atomic", null)
                        .WithMany("ksPairs")
                        .HasForeignKey("AtomicID");
                });

            modelBuilder.Entity("MyData.Models.Disposition.DispositionInstance", b =>
                {
                    b.HasOne("MyData.Models.Competency.Atomic", null)
                        .WithMany("Dispositions")
                        .HasForeignKey("AtomicID");

                    b.HasOne("MyData.Models.Competency.Composite", null)
                        .WithMany("Dispositions")
                        .HasForeignKey("CompositeID");

                    b.HasOne("MyData.Models.Disposition.DispositionDictionary", null)
                        .WithMany("dispositionInstances")
                        .HasForeignKey("DispositionDictionaryID");

                    b.HasOne("MyData.Models.Disposition.DispositionApplied", "applied")
                        .WithMany()
                        .HasForeignKey("appliedID");

                    b.HasOne("MyData.Models.Disposition.DispositionSynonym", "synonym")
                        .WithMany()
                        .HasForeignKey("synonymID");
                });

            modelBuilder.Entity("MyData.Models.Knowledge.KnowledgeElement", b =>
                {
                    b.HasOne("MyData.Models.Knowledge.KnowledgeDictionary", null)
                        .WithMany("elements")
                        .HasForeignKey("KnowledgeDictionaryID");
                });

            modelBuilder.Entity("MyData.Models.Knowledge.KnowledgeSynonym", b =>
                {
                    b.HasOne("MyData.Models.Knowledge.KnowledgeElement", null)
                        .WithMany("synonym")
                        .HasForeignKey("KnowledgeElementID");
                });

            modelBuilder.Entity("MyData.Models.Skill.SkillLevel", b =>
                {
                    b.HasOne("MyData.Models.Skill.SkillDictionary", null)
                        .WithMany("skillLevels")
                        .HasForeignKey("SkillDictionaryID");
                });

            modelBuilder.Entity("MyData.Models.Skill.SkillVerbSynonym", b =>
                {
                    b.HasOne("MyData.Models.Skill.SkillLevel", null)
                        .WithMany("synonyms")
                        .HasForeignKey("SkillLevelID");
                });
#pragma warning restore 612, 618
        }
    }
}
