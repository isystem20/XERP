using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Application.Requests.HumanResource.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommandValidator : AbstractValidator<CreateDepartmentCommand>
    {
        public CreateDepartmentCommandValidator()
        {
            //RuleFor(x => x.Code).MaximumLength(50).NotEmpty();
            //RuleFor(x => x.CompanyId).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(200).NotEmpty();
            //RuleFor(x => x.Description).MaximumLength(500);
        }


    }
}
