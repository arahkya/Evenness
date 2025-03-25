using System.ComponentModel.DataAnnotations;

namespace Arahk.Evenness.Lib.Infrastructure.Models;

public class ProjectModel
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}