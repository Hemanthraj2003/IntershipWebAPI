using System.ComponentModel.DataAnnotations;

namespace IntershipWebAPI.Model
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public string InvoiceNo{ get; set; }
        public DateTime Date { get; set; }

        public string InvoiceType {  get; set; }

        public string CustomerNo { get; set; }
        public string Address { get; set; }
        public string TransporterNo { get; set; }
        public string VehicleNo { get; set; }
        public string Item { get; set; }
        public string umo { get; set; }
        public int Qunatity { get; set; }
        public float Rate { get; set; }
        public float LineAmount { get; set; }
        public float GST { get; set; }
        public float GSTAmt { get; set; }
        public float Total { get; set; }
    }
}
