using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Client
    {
        // Attributes
        private int clientId;
        private string clientName;
        private string contactInfo;
        private string policy;

        // Default Constructor
        public Client()
        {
        }

        // Parameterized Constructor
        public Client(int clientId, string clientName, string contactInfo, string policy)
        {
            this.clientId = clientId;
            this.clientName = clientName;
            this.contactInfo = contactInfo;
            this.policy = policy;
        }

        // Getters and Setters
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ContactInfo { get; set; }
        public string Policy { get; set; }

        // Method to print all variables
        public void PrintClientDetails()
        {
            Console.WriteLine($"Client ID: {clientId}, Name: {clientName}, Contact: {contactInfo}, Policy: {policy}");
        }
    }
}
