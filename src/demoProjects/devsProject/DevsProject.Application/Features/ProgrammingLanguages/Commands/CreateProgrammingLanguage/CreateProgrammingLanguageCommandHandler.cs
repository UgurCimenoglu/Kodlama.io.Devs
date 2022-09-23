using AutoMapper;
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

        public CreateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<CreateProgrammingLanguageCommandResponse> Handle(CreateProgrammingLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            ProgrammingLanguage programmingLanguage = _mapper.Map<ProgrammingLanguage>(request);
            ProgrammingLanguage createdProgrammingLanguage = await _programmingLanguageRepository.AddAsync(programmingLanguage);
            CreateProgrammingLanguageCommandResponse response = _mapper.Map<CreateProgrammingLanguageCommandResponse>(createdProgrammingLanguage);
            return response;
        }
    }
}
