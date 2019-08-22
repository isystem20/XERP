using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Core.API.Models.HR
{
    public class ClientModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyAddress { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string IndustryType { get; set; }
        public string Description { get; set; }
        [Required]
        public string CreatedById { get; set; }
        public string LastModifiedById { get; set; }
        public string Status { get; set; }
    }
}
