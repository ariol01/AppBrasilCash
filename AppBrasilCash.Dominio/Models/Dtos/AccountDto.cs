using System.ComponentModel.DataAnnotations;

namespace AppBrasilCash.Models.Dtos
{
    public class AccountDto
    {
        [Key]
        public int TaxId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public Address Address { get; set; }
    }
}
