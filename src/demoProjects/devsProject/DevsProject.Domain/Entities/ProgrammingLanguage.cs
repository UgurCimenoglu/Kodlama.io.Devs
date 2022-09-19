using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsProject.Domain.Entities
{
    public class ProgrammingLanguage : Entity
    {
        public ProgrammingLanguage()
        {

        }
        public ProgrammingLanguage(int id, string name, DateTime createdDate, DateTime updatedDate, bool isActive, string createdBy, string updatedBy)
        {

            Id = id;
            Name = name;
            CreateDate = createdDate;
            UpdatedDate = updatedDate;
            IsActive = isActive;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;

        }
        public ProgrammingLanguage(int id, string name, DateTime createdDate, bool isActive, string createdBy)
        {

            Id = id;
            Name = name;
            CreateDate = createdDate;
            IsActive = isActive;
            CreatedBy = createdBy;

        }

        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
