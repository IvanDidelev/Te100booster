using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Database.Entities
{
    public class ServiceDirection : BaseEntity
    {
        public int ServiceId { get; set; }

        public int ClientId { get; set; }

        public int? EmployeeId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? ServedTime { get; set; }

        public bool IsCompleted { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Employee Employee { get; set; }
    }
}
