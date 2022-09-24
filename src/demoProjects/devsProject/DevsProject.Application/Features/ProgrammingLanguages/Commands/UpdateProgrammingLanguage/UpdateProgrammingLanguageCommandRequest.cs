using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage
{
    public class UpdateProgrammingLanguageCommandRequest : IRequest<UpdateProgrammingLanguageCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
