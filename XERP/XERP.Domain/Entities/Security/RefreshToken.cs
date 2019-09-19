using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Domain.Entities.Security
{
    public class RefreshToken
    {
        public string Id { get; set; }
        public DateTime? IssuedUtc { get; set; }
        public DateTime? ExpiresUtc { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
    }
}
