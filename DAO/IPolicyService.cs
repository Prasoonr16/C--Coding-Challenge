using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IPolicyService
    {
        // a. Create a new policy in the database
        bool CreatePolicy(Policy policy);

        // b. Get a specific policy by its ID
        Policy GetPolicy(int policyId);

        // c. Get all policies from the database
        List<Policy> GetAllPolicies();

        // d. Update an existing policy
        bool UpdatePolicy(int policyId, Policy policy);

        // e. Delete a policy by its ID
        bool DeletePolicy(int policyId);
    }
}
