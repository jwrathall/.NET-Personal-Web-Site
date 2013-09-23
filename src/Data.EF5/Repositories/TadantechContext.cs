using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Domain.Model;

namespace Data.EF5.Repositories
{
    public class TadantechContext:DbContext
    {
        public  TadantechContext()
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicHighlight> TopicHighLights { get; set; }
        public DbSet<Social> SocialLinks { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SiteImages> Images { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }

        //removes the pluralization of tables in the DB
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Site>()
                .HasMany(s=>s.Skills)
                .WithMany(k=>k.Sites)
                .Map(n=>
                         {
                             n.ToTable("SkillsMap");
                             n.MapLeftKey("SiteId");
                             n.MapRightKey("SkillId");

                         });
        }
    }
}
//http://msdn.microsoft.com/en-us/data/ee712907