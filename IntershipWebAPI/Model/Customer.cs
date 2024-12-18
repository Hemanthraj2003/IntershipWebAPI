using System.ComponentModel.DataAnnotations;

namespace IntershipWebAPI.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int PhoneNo { get; set; }

    }
}
