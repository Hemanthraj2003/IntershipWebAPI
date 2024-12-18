using System.ComponentModel.DataAnnotations;

namespace IntershipWebAPI.Model
{
    public class InvoiceType
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}
