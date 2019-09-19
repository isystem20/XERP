using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XERP.Application.Exceptions;
using XERP.Application.Interfaces;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentDetail
{
    public class GetDepartmentDetailQueryHandler : IRequestHandler<GetDepartmentDetailQuery, DepartmentDetailModel>
    {
        private readonly IXERPDbContext _context;

        public GetDepartmentDetailQueryHandler(IXERPDbContext context)
        {
            _context = context;
        }

        public async Task<DepartmentDetailModel> Handle(GetDepartmentDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Departments
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Department), request.Id);
            }

            return DepartmentDetailModel.Create(entity);
        }
    }
}
