using System;
using System.Collections.Generic;
using System.Text;
using XERP.Domain.Entities.Common;

namespace XERP.Domain.Entities.CompanyResource
{
    public class CompanyClient
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public Company Companies { get; set; }

    }
}
