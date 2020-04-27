using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyData.Models.Skill;
using MyData.Models.Knowledge;
using MyData.Models.Disposition;
using MyData.Models.Competency;
using MyData.Models.Task;
namespace MyData.Data
{



    public class CDKSTContext : DbContext
    {
        public CDKSTContext(DbContextOptions<CDKSTContext> options)
            : base(options)
        {
        }
        public DbSet<MyData.Models.Skill.SkillVerbSynonym> SkillVerbSynonym { get; set; }

        public DbSet<MyData.Models.Skill.SkillLevel> SkillLevel { get; set; }

        public DbSet<MyData.Models.Skill.SkillDictionary> SkillDictionary { get; set; }

        public DbSet<MyData.Models.Knowledge.KnowledgeSynonym> KnowledgeSynonym { get; set; }

        public DbSet<MyData.Models.Knowledge.KnowledgeElement> KnowledgeElement { get; set; }

        public DbSet<MyData.Models.Knowledge.KnowledgeDictionary> KnowledgeDictionary { get; set; }

        public DbSet<MyData.Models.Disposition.DispositionSynonym> DispositionSynonym { get; set; }

        public DbSet<MyData.Models.Disposition.DispositionApplied> DispositionApplied { get; set; }

        public DbSet<MyData.Models.Disposition.DispositionInstance> DispositionInstance { get; set; }

        public DbSet<MyData.Models.Disposition.DispositionDictionary> DispositionDictionary { get; set; }

        public DbSet<MyData.Models.Competency.Composite> Composite { get; set; }

        public DbSet<MyData.Models.Competency.Atomic> Atomic { get; set; }

        public DbSet<MyData.Models.Task.Task> Task { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Disposition>(entity =>
            // {
            //     entity.HasData(
            //         new Disposition
            //         {
            //             Id = 1,
            //             Name = "Proactive",
            //             Category = "Habits",
            //             Discipline = "Information Systems",
            //             Description = @"With Initiative (Nwokeji, Stachel, & " +
            //                               "Holmes, 2019) / Self-Starter (Clear, 2017) " +
            //                               "Shows independence. Ability to assess and " +
            //                               "start activities independently without needing " +
            //                               "to be told what to do. Willing to take the lead, " +
            //                               "not waiting for others to start activities or wait " +
            //                               "for instructions."

            //         },
            //         new Disposition
            //         {
            //             Id = 2,
            //             Name = "Purpose-Driven",
            //             Category = "Qualities",
            //             Discipline = "Information Systems",
            //             Description = @"Purposefully engaged / Purposefulness " +
            //                               "(Nwokeji et al., 2019), (Clear, 2017) " +
            //                               "Goal-directed, intentionally acting and " +
            //                               "committed to achieve organizational and " +
            //                               "project goals. Reflects an attitude towards " +
            //                               "the organizational goals served by decisions, " +
            //                               "work or work products. e.g., Business acumen."

            //         },
            //         new Disposition
            //         {
            //             Id = 3,
            //             Name = "Self-Directed",
            //             Category = "Qualities",
            //             Discipline = "Information Systems",
            //             Description = @"Self-motivated (Clear, 2017) / Self-Directed " +
            //                               "(Nwokeji et al., 2019) Demonstrates determination " +
            //                               "to sustain efforts to continue tasks. Direction " +
            //                               "from others is not required to continue a task " +
            //                               "toward its desired ends."
            //         }
            //     );
            // });

            base.OnModelCreating(modelBuilder);
        }


    }
}