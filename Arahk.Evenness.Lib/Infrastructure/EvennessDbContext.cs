using Arahk.Evenness.Lib.Domain.Entities;
using Arahk.Evenness.Lib.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Arahk.Evenness.Lib.Infrastructure;

public class EvennessDbContext(DbContextOptions<EvennessDbContext> options) : DbContext(options)
{
    public DbSet<ProjectModel> Projects { get; set; }
}