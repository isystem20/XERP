using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using XERP.Application.Interfaces;

namespace XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentsList
{
    public class GetDepartmentsListQueryHandler : IRequestHandler<GetDepartmentsListQuery, DepartmentsListViewModel>
    {
        private readonly IXERPDbContext _context;
        private readonly IMapper _mapper;

        public GetDepartmentsListQueryHandler(IXERPDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DepartmentsListViewModel> Handle(GetDepartmentsListQuery request, CancellationToken cancellationToken)
        {
            return new DepartmentsListViewModel
            {
                Departments = await _context.Departments.ProjectTo<DepartmentLookupModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
