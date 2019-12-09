using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DataModel;

namespace DAL
{
    public class CommissionDAL
    {
        static string lianjie = ConfigurationManager.ConnectionStrings["ss"].ConnectionString;
        SqlConnection conn = new SqlConnection(lianjie);
        public DataTable Show(int pageindex, int pagesize, out int tocount)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "zp_fenye";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] ap = new SqlParameter[]
            {
                new SqlParameter() { ParameterName="pageindex",SqlDbType=SqlDbType.Int,SqlValue=pageindex},
                new SqlParameter() { ParameterName="pagesize",SqlDbType=SqlDbType.Int,SqlValue=pagesize},
                new SqlParameter() { ParameterName="tocount",SqlDbType=SqlDbType.Int,Direction=ParameterDirection.Output}
            };
            cmd.Parameters.AddRange(ap);
            SqlDataAdapter dsa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("table");
            dsa.Fill(dt);
            tocount = Convert.ToInt32(cmd.Parameters["tocount"].Value);
            return dt;
        }
    }
}
