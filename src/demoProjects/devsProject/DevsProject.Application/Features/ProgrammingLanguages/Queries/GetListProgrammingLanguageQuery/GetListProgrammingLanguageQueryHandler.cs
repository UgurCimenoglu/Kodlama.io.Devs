using AutoMapper;
using DevsProject.Application.Services.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Queries.GetListProgrammingLanguageQuery
{
    public class GetListProgrammingLanguageQueryHandler : IRequestHandler<GetListProgrammingLanguageQueryRequest, GetListProgrammingLanguageQueryResponse>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;

        public GetListProgrammingLanguageQueryHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<GetListProgrammingLanguageQueryResponse> Handle(GetListProgrammingLanguageQueryRequest request, CancellationToken cancellationToken)
        {
            var programmingLanguages = await _programmingLanguageRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
            return _mapper.Map<GetListProgrammingLanguageQueryResponse>(programmingLanguages);
        }
    }
}
