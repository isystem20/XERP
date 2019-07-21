using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Core.API.Models
{
    public class ApplicationUserModel
    {
        public string UserCode { get; set; } //How to link it to a function generating uniquecode?

        [Required]
        public string LoginName { get; set; }


    }
}
