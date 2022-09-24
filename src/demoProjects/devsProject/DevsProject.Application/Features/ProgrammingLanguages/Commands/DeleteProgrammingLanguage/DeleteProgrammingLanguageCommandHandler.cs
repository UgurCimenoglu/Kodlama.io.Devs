using AutoMapper;
using DevsProject.Application.Services.Repositories;
using DevsProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage
{
    public class DeleteProgrammingLanguageCommandHandler : IRequestHandler<DeleteProgrammingLanguageCommandRequest, DeleteProgrammingLanguageCommandResponse>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;

        public DeleteProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<DeleteProgrammingLanguageCommandResponse> Handle(DeleteProgrammingLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(p => p.Id == request.Id);
            programmingLanguage.IsActive = false;
            var updatedEntity = await _programmingLanguageRepository.UpdateAsync(programmingLanguage);
            return _mapper.Map<DeleteProgrammingLanguageCommandResponse>(updatedEntity);
        }
    }
}
