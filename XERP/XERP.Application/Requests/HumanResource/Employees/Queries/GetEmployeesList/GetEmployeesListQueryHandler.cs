using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XERP.Application.Interfaces;

namespace XERP.Application.Requests.HumanResource.Employees.Queries.GetEmployeesList
{
    public class GetEmployeesListQueryHandler : IRequestHandler<GetEmployeesListQuery, EmployeeListViewModel>
    {
        private readonly IXERPDbContext _context;
        private readonly IMapper _mapper;

        public GetEmployeesListQueryHandler(IXERPDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EmployeeListViewModel> Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {
            return new EmployeeListViewModel
            {
                Employees = await _context.Employees.ProjectTo<EmployeeLookupModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
