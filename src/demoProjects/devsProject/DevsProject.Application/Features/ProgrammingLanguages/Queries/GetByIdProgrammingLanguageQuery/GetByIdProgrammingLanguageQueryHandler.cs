using AutoMapper;
using DevsProject.Application.Features.ProgrammingLanguages.Rules;
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
        private readonly ProgrammingLanguageBusinessRules _businessRules;

        public GetByIdProgrammingLanguageQueryHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper, ProgrammingLanguageBusinessRules businessRules)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetByIdProgrammingLanguageQueryResponse> Handle(GetByIdProgrammingLanguageQueryRequest request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(p => p.Id == request.Id);
            _businessRules.ProgrammingLanguageShouldExistWhenRequested(programmingLanguage);
            return _mapper.Map<GetByIdProgrammingLanguageQueryResponse>(programmingLanguage);
        }
    }
}
