using Core.Persistence.Paging;
using DevsProject.Application.Features.ProgrammingLanguages.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Queries.GetListProgrammingLanguageQuery
{
    public class GetListProgrammingLanguageQueryResponse : BasePageableModel
    {
        public IList<ProgrammingLanguageListDto> Items { get; set; }
    }
}
