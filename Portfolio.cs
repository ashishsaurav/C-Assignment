using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioManagement
{
    public partial class Portfolio : Form
    {
        public Portfolio()
        {
            InitializeComponent();

            Load += Portfolio_Load;
        }

        void Portfolio_Load(object sender, EventArgs e)
        {
            portfolioGrid();
        }

        /// <summary>
        ///  Adding data to portfolio ultra grid
        /// </summary>
        private void portfolioGrid()
        {
            //if (PerformOperation.StoreOrder.Rows.Count != 0)
            //{
            //    List<Orders> GridData = new List<Orders>();
            //    foreach (DataRow dr in PerformOperation.StoreOrder.Rows) // search whole table
            //    {
            //        if (dr["OrderStatus"].ToString() == "Filled")
            //        {
            //            GridData.Add(new Orders { Symbol = dr["Symbol"].ToString(), Side = dr["Side"].ToString(), Account = dr["Account"].ToString(), Quantity = dr["Quantity"].ToString(), AvgPrice = dr["AvgPrice"].ToString(), RemainingQuantity = dr["RemainingQuantity"].ToString(), OrderStatus = dr["OrderStatus"].ToString(), CLOrderID = dr["CLOrderID"].ToString(), ParentCLOrderID = dr["ParentCLOrderID"].ToString(), StaggedOrderID = dr["StaggedOrderID"].ToString(), OriginalCLOrderID = dr["OriginalCLOrderID"].ToString() });
            //        }
            //    }
            ultraGridPortfolio.DataSource = PerformOperation.SelectDataPortfolio();
            ultraGridPortfolio.DataBind();
            //}
            //else
            //{
            //    //creating column header if data is empty for UI
            //    Orders order = new Orders();
            //    ultraGridPortfolio.DataSource = order;
            //    ultraGridPortfolio.DataBind();
            //}
        }
    }
}
