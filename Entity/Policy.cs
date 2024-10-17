using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Policy
    {
        public int PolicyID { get; set; }

        public string PolicyName { get; set; }

        public Policy(int policyID, string policyName)
        {
            PolicyID = policyID;
            PolicyName = policyName;
        }

        public Policy()
        {
        }

        // Method to print policy details
        public void PrintPolicyDetails()
        {
            Console.WriteLine($"Policy ID: {PolicyID}, Name: {PolicyName}");
        }
    }
}
