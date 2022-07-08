using AppBrasilCash.Dominio.Models.Dtos;
using System.ComponentModel.DataAnnotations;

namespace AppBrasilCash.Models.Dtos
{
    public class AccountDto
    {
        public int Id { get; set; }
        [Required]
        public string TaxId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string PostalCode { get; set; }
        public string Status { get; set; } = "Pending";
        
    }
}
