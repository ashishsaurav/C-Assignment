using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Reflection;
using Infragistics.Win.UltraWinGrid;

namespace PortfolioManagement
{
    public static class PerformOperation
    {
        public static DataTable StoreOrder = new DataTable();
        public static string conString = "Data Source=ASHISHWIN-10\\MSSQLSERVER14;Integrated Security=true;Initial Catalog=PracticeAssignment;";
        
        /// <summary>
        /// Inserts the data.
        /// </summary>
        /// <param name="order">The order.</param>
        public static void InsertData(Orders order, string OrderType)
        {
            //if (StoreOrder.Columns.Count == 0)
            //{
            //    //creating column header for grid
               
            //    Type t = order.GetType();
            //    foreach (PropertyInfo pi in t.GetProperties())
            //    {
            //        StoreOrder.Columns.Add(new DataColumn(pi.Name));
            //    }
            //}
            ////adding rows
            //StoreOrder.Rows.Add(order.Symbol, order.Side, order.Account, order.Quantity, order.AvgPrice, order.RemainingQuantity, order.OrderStatus, order.CLOrderID, order.ParentCLOrderID, order.StaggedOrderID, order.OriginalCLOrderID);

            if(OrderType == "Create")
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmdT_OrderAndSub = new SqlCommand("InsertT_OrderAndSub", con);
                    cmdT_OrderAndSub.CommandType = CommandType.StoredProcedure;
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Symbol", order.Symbol);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Side", order.Side);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Account", order.Account);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Quantity", Convert.ToInt32(order.Quantity));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@AvgPrice", Convert.ToDecimal(order.AvgPrice));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@RemainingQuantity", Convert.ToInt32(order.RemainingQuantity));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
                    cmdT_OrderAndSub.ExecuteNonQuery();
                }
            }
            else if (OrderType == "Done")
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmdT_OrderAndSub = new SqlCommand("InsertT_OrderAndSub", con);
                    cmdT_OrderAndSub.CommandType = CommandType.StoredProcedure;
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Symbol", order.Symbol);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Side", order.Side);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Account", order.Account);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Quantity", Convert.ToInt32(order.Quantity));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@AvgPrice", Convert.ToDecimal(order.AvgPrice));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@RemainingQuantity", Convert.ToInt32(order.RemainingQuantity));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
                    cmdT_OrderAndSub.ExecuteNonQuery();

                    SqlCommand cmdLatestRow = new SqlCommand("select CLOrderId from T_OrderAndSub where CLOrderId = (SELECT max(CLOrderId) FROM T_OrderAndSub)", con);
                    int CLId = Convert.ToInt32(cmdLatestRow.ExecuteScalar());

                    SqlCommand cmdT_TradedOrders = new SqlCommand("InsertT_TradedOrders", con);
                    cmdT_TradedOrders.CommandType = CommandType.StoredProcedure;
                    cmdT_TradedOrders.Parameters.AddWithValue("@Symbol", order.Symbol);
                    cmdT_TradedOrders.Parameters.AddWithValue("@Side", order.Side);
                    cmdT_TradedOrders.Parameters.AddWithValue("@Account", order.Account);
                    cmdT_TradedOrders.Parameters.AddWithValue("@Quantity", Convert.ToInt32(order.Quantity));
                    cmdT_TradedOrders.Parameters.AddWithValue("@AvgPrice", Convert.ToDecimal(order.AvgPrice));
                    cmdT_TradedOrders.Parameters.AddWithValue("@RemainingQuantity", Convert.ToInt32(order.RemainingQuantity));
                    cmdT_TradedOrders.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
                    cmdT_TradedOrders.Parameters.AddWithValue("@ParentCLOrderId", CLId);
                    cmdT_TradedOrders.ExecuteNonQuery();
                }
            }
            
        }

        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="order">The order.</param>
        public static void UpdateData(Orders order, string clOrderID, string OrderType)
        {
            //foreach (DataRow dr in StoreOrder.Rows) // search whole table
            //{
            //    if (dr["CLOrderID"].ToString() == clOrderID)
            //    {
            //        dr["Account"] = order.Account;
            //        dr["Quantity"] = order.Quantity;
            //        dr["AvgPrice"] = order.AvgPrice;
            //        dr["RemainingQuantity"] = order.RemainingQuantity;
            //        dr["OrderStatus"] = order.OrderStatus;

            //        break;
            //    }
            //}

            if (OrderType == "Create")
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmdT_OrderAndSub = new SqlCommand("UpdateT_OrderAndSub", con);
                    cmdT_OrderAndSub.CommandType = CommandType.StoredProcedure;
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Account", order.Account);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Quantity", Convert.ToInt32(order.Quantity));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@AvgPrice", Convert.ToDecimal(order.AvgPrice));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@RemainingQuantity", Convert.ToInt32(order.RemainingQuantity));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@CLOrderId", clOrderID);
                    cmdT_OrderAndSub.ExecuteNonQuery();

                    SqlCommand cmdT_TradedOrders = new SqlCommand("InsertT_TradedOrders", con);
                    cmdT_TradedOrders.CommandType = CommandType.StoredProcedure;
                    cmdT_TradedOrders.Parameters.AddWithValue("@Symbol", order.Symbol);
                    cmdT_TradedOrders.Parameters.AddWithValue("@Side", order.Side);
                    cmdT_TradedOrders.Parameters.AddWithValue("@Account", order.Account);
                    cmdT_TradedOrders.Parameters.AddWithValue("@Quantity", TradingTicket.QtyFilled);
                    cmdT_TradedOrders.Parameters.AddWithValue("@AvgPrice", Convert.ToDecimal(order.AvgPrice));
                    cmdT_TradedOrders.Parameters.AddWithValue("@RemainingQuantity", "0");
                    cmdT_TradedOrders.Parameters.AddWithValue("@OrderStatus", "Filled");
                    cmdT_TradedOrders.Parameters.AddWithValue("@ParentCLOrderId", clOrderID);
                    cmdT_TradedOrders.ExecuteNonQuery();
                }
            }
            else if (OrderType == "Edit")
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmdT_OrderAndSub = new SqlCommand("UpdateT_OrderAndSubEdit", con);
                    cmdT_OrderAndSub.CommandType = CommandType.StoredProcedure;
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Account", order.Account);
                    cmdT_OrderAndSub.Parameters.AddWithValue("@Quantity", Convert.ToInt32(order.Quantity));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@AvgPrice", Convert.ToDecimal(order.AvgPrice));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@RemainingQuantity", Convert.ToInt32(order.RemainingQuantity));
                    cmdT_OrderAndSub.Parameters.AddWithValue("@CLOrderId", clOrderID);
                    cmdT_OrderAndSub.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Updates the account.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <param name="clOrderID">The cl order identifier.</param>
        public static void UpdateAccount(Orders order, string clOrderID)
        {
            //foreach (DataRow dr in StoreOrder.Rows) // search whole table
            //{
            //    if (dr["CLOrderID"].ToString() == clOrderID)
            //    {
            //        dr["Account"] = order.Account;
                    
            //        break;
            //    }
            //}

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmdT_TradedOrders = new SqlCommand("UpdateT_TradedOrders", con);
                cmdT_TradedOrders.CommandType = CommandType.StoredProcedure;
                cmdT_TradedOrders.Parameters.AddWithValue("@Account", order.Account);
                cmdT_TradedOrders.Parameters.AddWithValue("@CLOrderId", clOrderID);
                cmdT_TradedOrders.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes the data.
        /// </summary>
        /// <param name="clOrderID">The cl order identifier.</param>
        public static void DeleteData(string clOrderID)
        {
            //foreach (DataRow dr in StoreOrder.Rows) // search whole table
            //{
            //    if (dr["CLOrderID"].ToString() == clOrderID)
            //    {
            //        dr.Delete();

            //        break;
            //    }
            //}

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmdT_OrderAndSub = new SqlCommand("Delete from T_OrderAndSub where CLOrderId = '" + Convert.ToInt32(clOrderID) + "'", con);
                cmdT_OrderAndSub.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Selects the data using OrderStatus
        /// </summary>
        /// <param name="clOrderID">The cl order identifier.</param>
        public static List<Orders> SelectData(string CLOrderId)
        {
            List<Orders> SubData = new List<Orders>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand T_TradedOrders = new SqlCommand("Select * from T_TradedOrders where ParentCLOrderId = '" + Convert.ToInt32(CLOrderId) + "'", con);
                SqlDataReader rd = T_TradedOrders.ExecuteReader();

                while (rd.Read())
                {
                    SubData.Add(new Orders { Symbol = rd["Symbol"].ToString(), Side = rd["Side"].ToString(), Account = rd["Account"].ToString(), Quantity = rd["Quantity"].ToString(), AvgPrice = rd["AvgPrice"].ToString(), RemainingQuantity = rd["RemainingQuantity"].ToString(), OrderStatus = rd["OrderStatus"].ToString(), CLOrderID = rd["CLOrderId"].ToString(), ParentCLOrderID = rd["ParentCLOrderId"].ToString(), StaggedOrderID = rd["StagedOrderID"].ToString(), OriginalCLOrderID = rd["OriginalCLOrderId"].ToString() });
                }
            }
            return SubData;
        }

        /// <summary>
        /// Selects the data blotter.
        /// </summary>
        /// <returns></returns>
        public static List<Orders> SelectDataBlotter()
        {
            List<Orders> SubData = new List<Orders>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand T_TradedOrders = new SqlCommand("Select * from T_OrderAndSub", con);
                SqlDataReader rd = T_TradedOrders.ExecuteReader();

                while (rd.Read())
                {
                    SubData.Add(new Orders { Symbol = rd["Symbol"].ToString(), Side = rd["Side"].ToString(), Account = rd["Account"].ToString(), Quantity = rd["Quantity"].ToString(), AvgPrice = rd["AvgPrice"].ToString(), RemainingQuantity = rd["RemainingQuantity"].ToString(), OrderStatus = rd["OrderStatus"].ToString(), CLOrderID = rd["CLOrderId"].ToString(), ParentCLOrderID = rd["ParentCLOrderId"].ToString(), StaggedOrderID = rd["StagedOrderID"].ToString(), OriginalCLOrderID = rd["OriginalCLOrderId"].ToString() });
                }
            }
            return SubData;
        }

        /// <summary>
        /// Selects the data portfolio.
        /// </summary>
        /// <returns></returns>
        public static List<Orders> SelectDataPortfolio()
        {
            List<Orders> SubData = new List<Orders>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand T_TradedOrders = new SqlCommand("Select * from T_TradedOrders", con);
                SqlDataReader rd = T_TradedOrders.ExecuteReader();

                while (rd.Read())
                {
                    SubData.Add(new Orders { Symbol = rd["Symbol"].ToString(), Side = rd["Side"].ToString(), Account = rd["Account"].ToString(), Quantity = rd["Quantity"].ToString(), AvgPrice = rd["AvgPrice"].ToString(), RemainingQuantity = rd["RemainingQuantity"].ToString(), OrderStatus = rd["OrderStatus"].ToString(), CLOrderID = rd["CLOrderId"].ToString(), ParentCLOrderID = rd["ParentCLOrderId"].ToString(), StaggedOrderID = rd["StagedOrderID"].ToString(), OriginalCLOrderID = rd["OriginalCLOrderId"].ToString() });
                }
            }
            return SubData;
        }

        /// <summary>
        /// Inputs from blotter.
        /// </summary>
        /// <param name="CLOrderId">The cl order identifier.</param>
        /// <returns></returns>
        public static List<Orders> InputFromBlotter(string CLOrderId)
        {
            List<Orders> SubData = new List<Orders>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand T_TradedOrders = new SqlCommand("Select * from T_OrderAndSub where CLOrderId = '" + Convert.ToInt32(CLOrderId) + "'", con);
                SqlDataReader rd = T_TradedOrders.ExecuteReader();

                while (rd.Read())
                {
                    SubData.Add(new Orders { Symbol = rd["Symbol"].ToString(), Side = rd["Side"].ToString(), Account = rd["Account"].ToString(), Quantity = rd["Quantity"].ToString(), AvgPrice = rd["AvgPrice"].ToString(), RemainingQuantity = rd["RemainingQuantity"].ToString(), OrderStatus = rd["OrderStatus"].ToString(), CLOrderID = rd["CLOrderId"].ToString(), ParentCLOrderID = rd["ParentCLOrderId"].ToString(), StaggedOrderID = rd["StagedOrderID"].ToString(), OriginalCLOrderID = rd["OriginalCLOrderId"].ToString() });
                }
            }
            return SubData;
        }

        /// <summary>
        /// Selects the data allocation.
        /// </summary>
        /// <param name="Account">The account.</param>
        /// <returns></returns>
        public static List<Orders> SelectDataAllocation(string Account)
        {
            List<Orders> SubData = new List<Orders>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand T_TradedOrders = null;
                if (Account == "Unallocated")
                {
                    T_TradedOrders = new SqlCommand("Select * from T_TradedOrders where Account = 'Unallocated'", con);
                }
                else if (Account == "Allocated")
                {
                    T_TradedOrders = new SqlCommand("Select * from T_TradedOrders where Account <> 'Unallocated'", con);
                }

                SqlDataReader rd = T_TradedOrders.ExecuteReader();

                while (rd.Read())
                {
                    SubData.Add(new Orders { Symbol = rd["Symbol"].ToString(), Side = rd["Side"].ToString(), Account = rd["Account"].ToString(), Quantity = rd["Quantity"].ToString(), AvgPrice = rd["AvgPrice"].ToString(), RemainingQuantity = rd["RemainingQuantity"].ToString(), OrderStatus = rd["OrderStatus"].ToString(), CLOrderID = rd["CLOrderId"].ToString(), ParentCLOrderID = rd["ParentCLOrderId"].ToString(), StaggedOrderID = rd["StagedOrderID"].ToString(), OriginalCLOrderID = rd["OriginalCLOrderId"].ToString() });
                }
            }
            return SubData;
        }

        /// <summary>
        /// Selects the data closing.
        /// </summary>
        /// <param name="Side">The side.</param>
        /// <returns></returns>
        public static List<Orders> SelectDataClosing(string Side)
        {
            List<Orders> SubData = new List<Orders>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand T_TradedOrders = null;
                if (Side == "Opening")
                {
                    T_TradedOrders = new SqlCommand("Select * from T_TradedOrders where Side = 'Buy' or Side = 'Buy to Close'", con);
                }
                else if (Side == "Closing")
                {
                    T_TradedOrders = new SqlCommand("Select * from T_TradedOrders where Side = 'Sell' or Side = 'Sell Short'", con);
                }
                //else if (Side == "Closed")
                //{
                //    T_TradedOrders = new SqlCommand("Select * from T_TradedOrders where Side = 'Sell' or Side = 'SellShort'", con);
                //}

                SqlDataReader rd = T_TradedOrders.ExecuteReader();

                while (rd.Read())
                {
                    SubData.Add(new Orders { Symbol = rd["Symbol"].ToString(), Side = rd["Side"].ToString(), Account = rd["Account"].ToString(), Quantity = rd["Quantity"].ToString(), AvgPrice = rd["AvgPrice"].ToString(), RemainingQuantity = rd["RemainingQuantity"].ToString(), OrderStatus = rd["OrderStatus"].ToString(), CLOrderID = rd["CLOrderId"].ToString(), ParentCLOrderID = rd["ParentCLOrderId"].ToString(), StaggedOrderID = rd["StagedOrderID"].ToString(), OriginalCLOrderID = rd["OriginalCLOrderId"].ToString() });
                }
            }
            return SubData;
        }

        /// <summary>
        /// Logins the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="passWord">The pass word.</param>
        /// <returns></returns>
        public static bool Login(string userName, string passWord)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand logincmd = new SqlCommand("select * from T_User where Username = '" + userName + "' and Password = '" + passWord + "'", con);

                SqlDataAdapter sda = new SqlDataAdapter(logincmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Fills the side.
        /// </summary>
        /// <returns></returns>
        public static List<string> FillSide()
        {
            List<string> SelectSide = new List<string>();
            SelectSide.Add("Buy");
            SelectSide.Add("Sell");
            SelectSide.Add("Sell Short");
            SelectSide.Add("Buy to Close");

            return SelectSide;
        }

        /// <summary>
        /// Fills the Account.
        /// </summary>
        /// <returns></returns>
        public static List<string> FillAccount()
        {
            //List<string> SelectAccount = new List<string>();
            //SelectAccount.Add("Unallocated");
            //SelectAccount.Add("Account1");
            //SelectAccount.Add("Account2");
            //SelectAccount.Add("Account3");

            //return SelectAccount;

            List<string> SelectAccount = new List<string>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand T_TradedOrders = null;
                T_TradedOrders = new SqlCommand("Select FundName from T_CompanyFunds", con);
                SqlDataReader rd = T_TradedOrders.ExecuteReader();

                while (rd.Read())
                {
                    SelectAccount.Add(rd["FundName"].ToString());
                }
            }
            return SelectAccount;
        }

        /// <summary>
        /// Fills the Account on Allocation.
        /// </summary>
        /// <returns></returns>
        public static List<string> FillAccountAllocate()
        {
            //List<string> SelectAccount = new List<string>();
            //SelectAccount.Add("Account1");
            //SelectAccount.Add("Account2");
            //SelectAccount.Add("Account3");

            //return SelectAccount;

            List<string> SelectAccount = new List<string>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand T_TradedOrders = null;
                T_TradedOrders = new SqlCommand("Select FundName from T_CompanyFunds where FundName <> 'Unallocated'", con);
                SqlDataReader rd = T_TradedOrders.ExecuteReader();

                while (rd.Read())
                {
                    SelectAccount.Add(rd["FundName"].ToString());
                }
            }
            return SelectAccount;
        }
    }
}
