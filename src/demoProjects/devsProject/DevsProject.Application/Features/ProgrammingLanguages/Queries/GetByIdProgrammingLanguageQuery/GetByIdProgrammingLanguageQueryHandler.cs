using AutoMapper;
using DevsProject.Application.Services.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Queries.GetByIdProgrammingLanguageQuery
{
    public class GetByIdProgrammingLanguageQueryHandler : IRequestHandler<GetByIdProgrammingLanguageQueryRequest, GetByIdProgrammingLanguageQueryResponse>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;

        public GetByIdProgrammingLanguageQueryHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdProgrammingLanguageQueryResponse> Handle(GetByIdProgrammingLanguageQueryRequest request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(p => p.Id == request.Id);
            return _mapper.Map<GetByIdProgrammingLanguageQueryResponse>(programmingLanguage);
        }
    }
}
