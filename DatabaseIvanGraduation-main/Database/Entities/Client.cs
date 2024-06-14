using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Client : BaseEntity
    {
        public int UserId { get; set; }

        public bool HasHealthCertificate { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
