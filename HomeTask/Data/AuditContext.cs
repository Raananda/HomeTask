using HomeTask.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeTask.Data;

public class AuditContext : DbContext
{
    public DbSet<Audit> Audit { get; set; }

    public AuditContext(DbContextOptions<AuditContext> options)
    : base(options)
    {
    }
}
