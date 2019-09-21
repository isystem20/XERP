using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentDetail
{
    public class GetDepartmentDetailQueryValidator : AbstractValidator<GetDepartmentDetailQuery>
    {
        public GetDepartmentDetailQueryValidator()
        {
            RuleFor(v => v.Id).NotEmpty().MaximumLength(50);
        }
    }
}
