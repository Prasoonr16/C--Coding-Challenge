using DAO;
using Entity;
using System.Xml;

Policy policy = new Policy();
InsuranceServiceImpl service = new InsuranceServiceImpl();

char ans = 'N';

do
{


    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Create Policy");
    Console.WriteLine("2. Get Policy by ID");
    Console.WriteLine("3. Get All Policies");
    Console.WriteLine("4. Update Policy");
    Console.WriteLine("5. Delete Policy");
    Console.WriteLine("6. Exit");

    Console.WriteLine("Enter your choice : ");
    int ch = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    bool status = false;

    switch (ch)
    {
        case 1:
            Console.WriteLine("Enter Policy ID : ");
            policy.PolicyID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Policy name : ");
            policy.PolicyName = Console.ReadLine();

            status = service.CreatePolicy(policy);

            if (status)
            {

                Console.WriteLine("Added successfully....");
            }
            else
            {
                Console.WriteLine("Check code....");
            }
            break;
        case 2:
            try
            {
                Console.WriteLine("Enter policyID to Find : ");
                int policyid = Convert.ToInt32(Console.ReadLine());

                policy = service.GetPolicy(policyid);

                Console.WriteLine(policy.PolicyID);
                Console.WriteLine(policy.PolicyName);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            break;

        case 3:
            List<Policy> policylist = new List<Policy>();
            policylist = service.GetAllPolicies();
            foreach (var item in policylist)
            {
                Console.WriteLine(item.PolicyID +" | "+item.PolicyName);
                Console.WriteLine();
            }
            break;

        case 4:
            Console.WriteLine("Enter policyID to update");
            policy.PolicyID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Policy name : ");
            policy.PolicyName = Console.ReadLine();
            status = service.UpdatePolicy(policy.PolicyID, policy);
            if (status)
            {

                Console.WriteLine("Updated successfully....");
            }
            else
            {
                Console.WriteLine("Check code....");
            }
            break;

        case 5:
            Console.WriteLine("Enter Policy Id to delete : ");
            policy.PolicyID = Convert.ToInt32(Console.ReadLine());
            status = service.DeletePolicy(policy.PolicyID);

            if (status)
            {

                Console.WriteLine("Deleted successfully....");
            }
            else
            {
                Console.WriteLine("Check code....");
            }
            break;

        case 6:
            Environment.Exit(0);
            break;
    }
    Console.WriteLine("Do you want to coninue... (Y/N) : ");
    ans = Convert.ToChar(Console.ReadLine());
}
while (ans == 'Y');

Console.ReadKey();

