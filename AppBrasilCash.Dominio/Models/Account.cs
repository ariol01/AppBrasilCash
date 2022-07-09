namespace AppBrasilCash.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string TaxId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now.Date;
        public string PostalCode { get; set; }
        public string Status { get; set; }
        public Address Address { get; set; }
        public int? AddressId { get; set; }

    }
}
