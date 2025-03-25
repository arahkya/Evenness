using Arahk.Evenness.Lib.Application.Exceptions;
using Arahk.Evenness.Lib.Application.Interfaces;
using Arahk.Evenness.Lib.Domain.Entities;
using Arahk.Evenness.Lib.Domain.ValueObjects;

namespace Arahk.Evenness.Lib.Application.Usecases.CreateProject;

public class CreateProjectProcess(IProjectRepository projectRepository)
{
    public async Task<CreateProjectOutput> Execute(CreateProjectInput input)
    {
        var id = new IdValueObject();
        id.GenerateId();

        var project = new Project
        {
            Id = id,
            Name = input.Name,
            Description = new(input.Description),
            Duration = new(input.StartDate, input.EndDate)
        };

        if (!project.IsValid()) throw new InvalidInputException("Invalid project data");

        var result = await projectRepository.Create(project);

        return new CreateProjectOutput
        {
            IsSuccess = result
        };
    }
}