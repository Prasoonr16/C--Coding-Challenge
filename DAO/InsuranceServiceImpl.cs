using Entity;
using Exception;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Util;

namespace DAO
{
    public class InsuranceServiceImpl : IPolicyService
    {
        public bool CreatePolicy(Policy policy)
        {
            bool status = false;
            return InsertPolicyRecord(policy, status);
        }

        private static bool InsertPolicyRecord(Policy policy, bool status)
        {
            string cnstr = DBConnection.ReturnCn("dbCn");
            SqlConnection cn = new SqlConnection(cnstr);    

            SqlCommand cmd = new SqlCommand("insert into Policy values(@policyID, @policyName)", cn);
            cmd.Parameters.AddWithValue("@policyID", policy.PolicyID);
            cmd.Parameters.AddWithValue("@policyName", policy.PolicyName);

            cn.Open();
            
            int cnt = cmd.ExecuteNonQuery();
            if (cnt > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            cn.Close();
            return status;

        }

        public bool DeletePolicy(int policyId)
        {
            bool status = false;
            status = DeletePolicyRecord(policyId, status);
            return status;
        }

        private static bool DeletePolicyRecord(int policyId, bool status)
        {
            string cnstr = DBConnection.ReturnCn("dbCn");
            SqlConnection cn = new SqlConnection(cnstr);
            
            try
            {

                SqlCommand cmd = new SqlCommand("delete from Policy where policyID = " + policyId, cn);
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    status = true;
                }

                return status;
            }
            catch (PolicyNotFoundException ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
                cn.Dispose();

            }
        }

        public List<Policy> GetAllPolicies()
        {
            string cnstr = DBConnection.ReturnCn("dbCn");
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("Select * from Policy", cn);
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            List<Policy> policylist = new List<Policy>();
            while (dr.Read())
            {
                Policy policy = new Policy();
                policy.PolicyID = Convert.ToInt32(dr["PolicyID"]);
                policy.PolicyName = dr["PolicyName"].ToString();
                policylist.Add(policy);

            }
            cn.Close();
            return policylist;

        }

        public Policy GetPolicy(int policyId)
        {
            try
            {
                return SearchPolicyByID(policyId);
            }
            catch (PolicyNotFoundException ex)
            {

                throw ex;
            }
        }
        private static Policy SearchPolicyByID(int policyId)
        {
            string cnstr = DBConnection.ReturnCn("dbCn");
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("select * from Policy where policyID = " + policyId, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Policy policyfound = new Policy();
            if (dr.HasRows)
            {
                dr.Read();//readonly forward only
                policyfound.PolicyID = Convert.ToInt32(dr["policyID"]);
                policyfound.PolicyName = dr["policyName"].ToString();
                
            }
            else
            {
                throw new PolicyNotFoundException("Such a policyID does not exists......");
            }
            cn.Close();
            cn.Dispose();
            return policyfound;
        }




        public bool UpdatePolicy(int policyId, Policy policy)
        {
            bool status = false;

            string cnstr = DBConnection.ReturnCn("dbCn");
            SqlConnection cn = new SqlConnection(cnstr);

            SqlCommand cmd = new SqlCommand("update Policy set policyName= @policyname where policyID = " + policyId, cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@policyname", policy.PolicyName);
            
            int cnt = cmd.ExecuteNonQuery();
            if (cnt > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            cn.Close();
            return status;
        }
    }
}
