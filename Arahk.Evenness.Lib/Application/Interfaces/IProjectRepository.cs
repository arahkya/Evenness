using Arahk.Evenness.Lib.Domain.Entities;

namespace Arahk.Evenness.Lib.Application.Interfaces
{
    public interface IProjectRepository
    {
        Task<bool> Create(Project project);
    }
}