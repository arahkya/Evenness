using Arahk.Evenness.Lib.Application.Interfaces;
using Arahk.Evenness.Lib.Domain.Entities;
using Arahk.Evenness.Lib.Infrastructure.Models;

namespace Arahk.Evenness.Lib.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly EvennessDbContext _dbContext;

        public ProjectRepository(EvennessDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Create(Project project)
        {
            var model = new ProjectModel
            {
                Id = project.Id.Value,
                Name = project.Name,
                Description = project.Description.Value,
                StartDate = project.Duration.Start.Date,
                EndDate = project.Duration.End.Date
            };
            _dbContext.Projects.Add(model);

            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}