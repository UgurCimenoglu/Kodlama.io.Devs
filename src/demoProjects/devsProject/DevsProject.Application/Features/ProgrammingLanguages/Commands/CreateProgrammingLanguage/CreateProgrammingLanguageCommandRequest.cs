using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage
{
    public class CreateProgrammingLanguageCommandRequest : IRequest<CreateProgrammingLanguageCommandResponse>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
