using XERP.Domain.ValueObjects;

namespace XERP.Domain.Entities
{
    public class ApplicationUser
    {
        public string Id { get; set; }

        public AdAccount AdAccount { get; set; }

    }
}
