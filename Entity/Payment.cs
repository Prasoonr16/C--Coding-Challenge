using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Payment
    {
        // Attributes
        private int paymentId;
        private DateTime paymentDate;
        private decimal paymentAmount;
        private Client client; // Reference to Client

        // Getters and Setters
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public Client Client { get; set; }

        // Deafult Constructor

        public Payment()
        {

        }

        // Parameterized Constructor
        public Payment(int paymentId, DateTime paymentDate, decimal paymentAmount, Client client)
        {
            this.paymentId = paymentId;
            this.paymentDate = paymentDate;
            this.paymentAmount = paymentAmount;
            this.client = client;
        }

        // Method to print all variables
        public void PrintPaymentDetails()
        {
            Console.WriteLine($"Payment ID: {paymentId}, Payment Date: {paymentDate.ToShortDateString()}, Payment Amount: {paymentAmount}");
            if (client != null)
            {
                Console.WriteLine("Client Details:");
                client.PrintClientDetails();
            }

        }
    }
}
