using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceBL
{
    /// <summary>
    /// Summary description for OrderService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrderService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<OrderBO> GetOrder()
        {
            List<OrderBO> order = new List<OrderBO>();
            try
            {
                OrderDA dataAccess = new OrderDA();
                return dataAccess.GetOrderData();
            }
            catch
            {
                return order;
            }
        }

        [WebMethod]
        public int InsertNewOrder(OrderBO newOrder)
        {
            try
            {
                OrderDA dataAccess = new OrderDA();
                return dataAccess.InsertOrder(newOrder);
            }
            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int UpdateOrder(OrderBO order)
        {
            try
            {
                OrderDA dataAccess = new OrderDA();
                return dataAccess.UpdateOrder(order);
            }
            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int DeleteOrder(OrderBO order)
        {
            try
            {
                OrderDA dataAccess = new OrderDA();
                return dataAccess.DeleteOrder(order);
            }
            catch
            {
                return 0;
            }
        }
    }
}
