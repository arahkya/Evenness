namespace Arahk.Evenness.Lib.Application.Usecases.CreateProject;

public class CreateProjectInput
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
}