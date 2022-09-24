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

namespace DevsProject.Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage
{
    public class UpdateProgrammingLanguageCommandHandler : IRequestHandler<UpdateProgrammingLanguageCommandRequest, UpdateProgrammingLanguageCommandResponse>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;
        private readonly ProgrammingLanguageBusinessRules _businessRules;

        public UpdateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper, ProgrammingLanguageBusinessRules businessRules)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<UpdateProgrammingLanguageCommandResponse> Handle(UpdateProgrammingLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            await _businessRules.ProgrammingLanguageCannotBeDublicatedWhenInserted(request.Name);
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(p => p.Id == request.Id);
            var mappedProgrammingLanguage = _mapper.Map<UpdateProgrammingLanguageCommandRequest, ProgrammingLanguage>(request, programmingLanguage);
            var updatedEntity = await _programmingLanguageRepository.UpdateAsync(programmingLanguage);
            return _mapper.Map<UpdateProgrammingLanguageCommandResponse>(updatedEntity);
        }
    }
}
