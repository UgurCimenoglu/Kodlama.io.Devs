using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Queries.GetByIdProgrammingLanguageQuery
{
    public class GetByIdProgrammingLanguageQueryRequest : IRequest<GetByIdProgrammingLanguageQueryResponse>
    {
        public int Id { get; set; }
    }
}
