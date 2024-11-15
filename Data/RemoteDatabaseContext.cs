using Data.DAO;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class RemoteDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Username=user18; Password=0Ewhpxmm; Database=user18; Host=45.67.56.214; Port=5454;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Presence>().HasKey(it => new {it.LessonNumber,  it.GroupSubjectID});

            modelBuilder.Entity<Students>()
                .HasOne(Students => Students.Group);
            modelBuilder.Entity<GroupsSubjects>()
                .HasOne(GroupsSubjects => GroupsSubjects.Group);
            modelBuilder.Entity<GroupsSubjects>()
                .HasOne(GroupsSubjects => GroupsSubjects.Subject);
            modelBuilder.Entity<Presence>()
                .HasOne(Presence => Presence.Student);
            modelBuilder.Entity<Presence>()
                .HasOne(Presence => Presence.Status);
        }
        DbSet<Subjects> Subjects { get; set; }
        DbSet<Statuses> Statuses { get; set; }
        DbSet<Groups> Groups { get; set; }
        DbSet<Students> Students { get; set; }
        DbSet<GroupsSubjects> GroupsSubjects { get; set; }
        DbSet<Presence> Presence { get; set; }
    }
}
