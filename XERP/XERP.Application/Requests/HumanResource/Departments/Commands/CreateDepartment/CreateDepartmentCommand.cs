using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XERP.Application.Interfaces;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Application.Requests.HumanResource.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommand : IRequest
    {
        //public string Code { get; set; }
        //public string CompanyId { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
        //public string Status { get; set; }

        public class Handler : IRequestHandler<CreateDepartmentCommand, Unit>
        {
            private readonly IXERPDbContext _context;
            private readonly IMediator _mediator;

            public Handler(IXERPDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
            {
                var entity = new Department
                {
                    Id = Guid.NewGuid().ToString(),
                    //Code = request.Code,
                    //CompanyId = request.CompanyId,
                    Name = request.Name,
                    //Description = request.Description,
                    //CreatedById = LOGGED_USER,
                    //LastModifiedById = LOGGED_USER,
                    VersionNo = 1,
                    //Status = request.Status,

                };

                _context.Departments.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new DepartmentCreated { Id = entity.Id }, cancellationToken);

                return Unit.Value;
            }
        }


    }
}
