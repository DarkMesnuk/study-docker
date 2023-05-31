using Microsoft.EntityFrameworkCore;

namespace study_docker;

public class ProfileContext : DbContext
{
    public ProfileContext(DbContextOptions<ProfileContext> options)
        : base(options)
    { }

    public DbSet<Student> Students { get; set; }
}