namespace Talkrum.ForumApp.Data;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Talkrum.ForumApp.Data.Models;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Interaction> Interactions { get; init; }

    public DbSet<PersonalMessage> PersonalMessages { get; init; }

    public DbSet<TopicComment> TopicComments { get; init; }

    public DbSet<Topic> Topics { get; init; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseSqlServer("Server=.;Database=Talkrum.ForumApp;Trusted_Connection=True;trustServerCertificate=true;");
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Topic>()
            .HasOne(t => t.Creator)
            .WithMany(c => c.ParticipationTopics);


        base.OnModelCreating(builder);
    }
}