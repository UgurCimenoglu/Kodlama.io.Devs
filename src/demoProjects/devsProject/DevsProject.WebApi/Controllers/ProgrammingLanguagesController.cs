using DevsProject.Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using DevsProject.Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage;
using DevsProject.Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
using DevsProject.Application.Features.ProgrammingLanguages.Queries.GetByIdProgrammingLanguageQuery;
using DevsProject.Application.Features.ProgrammingLanguages.Queries.GetListProgrammingLanguageQuery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevsProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammingLanguagesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProgrammingLanguageCommandRequest request)
        {
            CreateProgrammingLanguageCommandResponse response = await Mediator.Send(request);
            return Created("", response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteProgrammingLanguageCommandRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProgrammingLanguageCommandRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdProgrammingLanguageQueryRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Getist([FromQuery] GetListProgrammingLanguageQueryRequest request)
        {
            var response = await Mediator.Send(request);
            return Ok(response);
        }
    }
}
