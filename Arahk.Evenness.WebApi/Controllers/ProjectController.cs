using Arahk.Evenness.Lib.Application.Interfaces;
using Arahk.Evenness.Lib.Application.Usecases.CreateProject;
using Arahk.Evenness.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Arahk.Evenness.WebApi.Controller;

[ApiController]
[Route("[controller]")]
public class ProjectController(IProjectRepository projectRepository) : ControllerBase
{
    [HttpGet(Name = "GetProjects")]
    public IActionResult GetProjects()
    {
        return Ok();
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateProject([FromBody] CreateProjectViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var input = new CreateProjectInput
        {
            Name = model.Name,
            Description = model.Description,
            StartDate = model.StartDate,
            EndDate = model.EndDate
        };

        var process = new CreateProjectProcess(projectRepository);
        var output = await process.Execute(input);

        if (output == null || !output.IsSuccess)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        return StatusCode(StatusCodes.Status201Created);
    }
}