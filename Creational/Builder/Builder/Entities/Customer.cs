using Builder.Enumerator;

namespace Builder.Entities
{
    public class Customer
    {
        private CustomerType custoemrType { get; set; }
        private List<string> mandatoryDocuments { get; set; }
        private decimal maxLoanAmount { get; set; }

        public Customer(CustomerType customerType)
        {
            this.custoemrType = customerType;
            this.mandatoryDocuments = new List<string>();
        }

        public void SetMandatoryDocument(string mandatoryDocument)
        {
            this.mandatoryDocuments.Add(mandatoryDocument);
        }

        public void SetMaxLoanAmount(decimal maxLoanAmount)
        {
            this.maxLoanAmount = maxLoanAmount;
        }

        public string GetMadatoryDocuments()
        {
            var requiredDocuments = new StringBuilder();

            requiredDocuments.AppendLine("___________________________________");
            requiredDocuments.AppendLine($"{Environment.NewLine}{this.custoemrType.ToString()}:");

            foreach (string item in mandatoryDocuments)
            {
                requiredDocuments.AppendLine(item);
            }

            return requiredDocuments.ToString();
        }

        public string GetMaxLoanAmount()
        {
            return String.Format("{0:C}", this.maxLoanAmount);
        }
    }
}
