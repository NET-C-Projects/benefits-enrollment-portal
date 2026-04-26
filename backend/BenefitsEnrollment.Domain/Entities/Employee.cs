using BenefitsEnrollment.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsEnrollment.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string EmployeeNumber { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime HireDate { get; set; }

        public EmploymentStatus EmploymentStatus { get; set; }

        public string WorkState { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";
    }
}
