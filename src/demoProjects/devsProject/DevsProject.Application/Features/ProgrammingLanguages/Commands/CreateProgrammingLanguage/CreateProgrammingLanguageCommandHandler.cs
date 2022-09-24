using AutoMapper;
using DevsProject.Application.Features.ProgrammingLanguages.Rules;
using DevsProject.Application.Services.Repositories;
using DevsProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage
{
    public class CreateProgrammingLanguageCommandHandler : IRequestHandler<CreateProgrammingLanguageCommandRequest, CreateProgrammingLanguageCommandResponse>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;
        private readonly ProgrammingLanguageBusinessRules _businessRules;

        public CreateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper, ProgrammingLanguageBusinessRules businessRules)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<CreateProgrammingLanguageCommandResponse> Handle(CreateProgrammingLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            await _businessRules.ProgrammingLanguageCannotBeDublicatedWhenInserted(request.Name);
            ProgrammingLanguage programmingLanguage = _mapper.Map<ProgrammingLanguage>(request);
            ProgrammingLanguage createdProgrammingLanguage = await _programmingLanguageRepository.AddAsync(programmingLanguage);
            CreateProgrammingLanguageCommandResponse response = _mapper.Map<CreateProgrammingLanguageCommandResponse>(createdProgrammingLanguage);
            return response;
        }
    }
}
