using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        [ForeignKey(nameof(User))]
        public Guid PersonId { get; set; }

        public virtual User? User { get; set; }
    }
}
