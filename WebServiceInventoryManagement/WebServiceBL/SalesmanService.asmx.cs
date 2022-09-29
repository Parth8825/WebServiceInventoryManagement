using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceBL
{
    /// <summary>
    /// Summary description for SalesmanService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SalesmanService : System.Web.Services.WebService
    {

        [WebMethod]
        public int InsertNewSalesman(SalesmanBO newSalesman)
        {
            try
            {
                SalesmanDA dataAccess = new SalesmanDA();
                return dataAccess.InsertSalesman(newSalesman);
            }
            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int UpdateSalesman(SalesmanBO salesman)
        {
            try
            {
                SalesmanDA dataAccess = new SalesmanDA();
                return dataAccess.UpdateSalesman(salesman);
            }
            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int DeleteSalesman(SalesmanBO salesman)
        {
            try
            {
                SalesmanDA dataAccess = new SalesmanDA();
                return dataAccess.DeleteSalesman(salesman);
            }
            catch
            {
                return 0;
            }
        }
    }
}
