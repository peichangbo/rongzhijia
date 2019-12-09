using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataModel;
using BLL;
using System.Data;
using Newtonsoft.Json;

namespace Day18Websaver
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        CommissionBLL bll = new CommissionBLL();
        [WebMethod]
        public DataTable Show(int pageindex, int pagesize, out int tocount)
        {
            tocount = 0;
            DataTable dt= bll.Show(pageindex, pagesize, out tocount);
            return dt;
        }
    }
}
