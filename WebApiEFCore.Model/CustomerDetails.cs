namespace WebApiEFCore.Model
{
    public class CustomerDetails
    {
        public int CustomerDetailsId { get; set; }
        public string AdditionalInformation { get; set; }
        public string ContactNumber { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
