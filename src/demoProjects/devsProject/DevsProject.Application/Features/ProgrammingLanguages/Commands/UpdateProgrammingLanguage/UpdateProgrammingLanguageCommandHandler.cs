using AutoMapper;
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

        public UpdateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<UpdateProgrammingLanguageCommandResponse> Handle(UpdateProgrammingLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(p => p.Id == request.Id);
            var mappedProgrammingLanguage = _mapper.Map<UpdateProgrammingLanguageCommandRequest, ProgrammingLanguage>(request, programmingLanguage);
            var updatedEntity = await _programmingLanguageRepository.UpdateAsync(programmingLanguage);
            return _mapper.Map<UpdateProgrammingLanguageCommandResponse>(updatedEntity);
        }
    }
}
