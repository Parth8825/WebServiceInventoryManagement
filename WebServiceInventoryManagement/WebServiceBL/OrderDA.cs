﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceBL
{
    public class OrderDA
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;

        public int InsertOrder(OrderBO order)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {
                var query = $"insert into orders(order_no, purch_amt, ord_date, customer_id, salesman_id) values(@OrderNo, {order.PurchAmt}, '{order.OrderDate.Date}', {order.CustomerId}, {order.SalesmanId});";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@OrderNo", order.OrderNo);
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int UpdateOrder(OrderBO order)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                var query = $"update orders Set purch_amt={order.PurchAmt}, ord_date={order.OrderDate}, customer_id={order.CustomerId}, salesman_id={order.SalesmanId} where order_no = @OrderNo ;";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@OrderNo", order.OrderNo);
                int result = cmd.ExecuteNonQuery();
                //cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int DeleteOrder(OrderBO order)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                var query = $"delete orders where order_no = @OrderNo;";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@OrderNo", order.OrderNo);
                int result = cmd.ExecuteNonQuery();
                //cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}