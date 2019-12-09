using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DAL;
using System.Data;

namespace BLL
{
    public class CommissionBLL
    {
        CommissionDAL dal = new CommissionDAL();
        public DataTable Show(int pageindex, int pagesize, out int tocount)
        {
            tocount = 0;
            return dal.Show(pageindex, pagesize,out tocount);
        }
    }
}
