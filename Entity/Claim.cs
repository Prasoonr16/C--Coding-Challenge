using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Claim
    {
        // Attributes
        private int claimId;
        private string claimNumber;
        private DateTime dateFiled;
        private decimal claimAmount;
        private string status;
        private string policy;
        private Client client; // Reference to Client

        // Getters and Setters
        public int ClaimId { get; set; }
        public string ClaimNumber { get; set; }
        public DateTime DateFiled { get; set; }
        public decimal ClaimAmount { get; set; }
        public string Status { get; set; }
        public string Policy { get; set; }
        public Client Client { get; set; }



        // Deafult Constructor

        public Claim()
        {

        }

        // Parameterizwed Constructor
        public Claim(int claimId, string claimNumber, DateTime dateFiled, decimal claimAmount, string status, string policy, Client client)
        {
            this.claimId = claimId;
            this.claimNumber = claimNumber;
            this.dateFiled = dateFiled;
            this.claimAmount = claimAmount;
            this.status = status;
            this.policy = policy;
            this.client = client;
        }

        // Method to print all variables
        public void PrintClaimDetails()
        {
            Console.WriteLine($"Claim ID: {claimId}, Claim Number: {claimNumber}, Date Filed: {dateFiled.ToShortDateString()}, Claim Amount: {claimAmount}, Status: {status}, Policy: {policy}");
            if (client != null)
            {
                Console.WriteLine("Client Details:");
                client.PrintClientDetails();
            }
        }
    }
}
