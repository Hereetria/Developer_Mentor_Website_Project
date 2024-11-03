

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EntityLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Contexts
{
    
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ArticleTag>()
                .HasKey(at => new { at.ArticleDetailId, at.TagId });

            modelBuilder.Entity<MentorSkill>()
                .HasKey(ms => new { ms.MentorId, ms.SkillId });

            modelBuilder.Entity<MentorSocialMedia>()
                .HasKey(msm => new { msm.MentorId, msm.SocialMediaId });

            modelBuilder.Entity<MentorSkill>()
                .Property(ms => ms.Rate)
                .HasDefaultValue(0);

            modelBuilder.Entity<MentorSkill>()
                   .ToTable("MentorSkills", t => t.HasCheckConstraint("CK_MentorSkill_Rate", "[Rate] >= 0 AND [Rate] <= 100"));

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = @"Server=DESKTOP-A7AFDHF\SQLEXPRESS;Initial Catalog=MentorProject;Integrated Security=true;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<ArticleContent> ArticleContents { get; set; }
        public DbSet<ArticleDetail> ArticleDetails { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Engagement> Engagements { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<MentorContent> MentorContents { get; set; }
        public DbSet<MentorSkill> MentorSkills { get; set; }
        public DbSet<MentorSocialMedia> MentorSocialMedias { get; set; }
        public DbSet<MentorStatistic> MentorStatistics { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subsection> Subsections { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<SubDescription> SubDescriptions { get; set; }

    }
}