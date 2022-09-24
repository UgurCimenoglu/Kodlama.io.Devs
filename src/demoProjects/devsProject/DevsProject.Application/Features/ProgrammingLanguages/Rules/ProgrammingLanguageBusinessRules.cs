using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using DevsProject.Application.Services.Repositories;
using DevsProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Application.Features.ProgrammingLanguages.Rules
{
    public class ProgrammingLanguageBusinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task ProgrammingLanguageCannotBeDublicatedWhenInserted(string name)
        {
            IPaginate<ProgrammingLanguage> datas = await _programmingLanguageRepository.GetListAsync(p => p.Name == name);
            if (datas.Items.Any()) throw new BusinessException("Programming Language Exist!");
        }

        public void ProgrammingLanguageShouldExistWhenRequested(ProgrammingLanguage programmingLanguage)
        {
            if (programmingLanguage == null) throw new BusinessException("Requested programming language does not exist!");
        }
    }
}
