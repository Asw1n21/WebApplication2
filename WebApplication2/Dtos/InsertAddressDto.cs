using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Entities;

namespace WebApplication2.Dtos
{
    public class InsertAddressDto
    {
          
      

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public Guid PersonId { get; set; }
    }
}