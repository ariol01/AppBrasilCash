namespace AppBrasilCash.Models
{
    public class Account
    {
        public int TaxId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public Address Address { get; set; }

    }
}
