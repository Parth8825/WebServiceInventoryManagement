using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceBL
{
    /// <summary>
    /// Summary description for CustomerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerService : System.Web.Services.WebService
    {

        [WebMethod]
        public int InsertNewCustomer(CustomerBO newCustomer)
        {
            try
            {
                CustomerDA dataAccess = new CustomerDA();
                return dataAccess.InsertCustomer(newCustomer);
            }
            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int UpdateCustomer(CustomerBO customer)
        {
            try
            {
                CustomerDA dataAccess = new CustomerDA();
                return dataAccess.UpdateCustomer(customer);
            }
            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int DeleteCustomer(CustomerBO customer)
        {
            try
            {
                CustomerDA dataAccess = new CustomerDA();
                return dataAccess.DeleteCustomer(customer);
            }
            catch
            {
                return 0;
            }
        }
    }
}
