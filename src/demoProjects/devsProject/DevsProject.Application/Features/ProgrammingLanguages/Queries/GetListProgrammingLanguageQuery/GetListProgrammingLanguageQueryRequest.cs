using Core.Application.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Queries.GetListProgrammingLanguageQuery
{
    public class GetListProgrammingLanguageQueryRequest : IRequest<GetListProgrammingLanguageQueryResponse>
    {
        public PageRequest PageRequest { get; set; }
    }
}
