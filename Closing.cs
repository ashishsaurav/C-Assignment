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
    public partial class Closing : Form
    {
        public Closing()
        {
            InitializeComponent();

            Load += Closing_Load;
        }

        void Closing_Load(object sender, EventArgs e)
        {
            openingGrid();
            closingGrid();
            closedDataGrid();
        }

        /// <summary>
        ///  Adding data to opening transaction ultra grid
        /// </summary>
        private void openingGrid()
        {

            //if (PerformOperation.StoreOrder.Rows.Count != 0)
            //{
            //    List<Orders> GridData = new List<Orders>();
            //    foreach (DataRow dr in PerformOperation.StoreOrder.Rows) // search whole table
            //    {
            //        if ((dr["Side"].ToString() == "Buy" || dr["Side"].ToString() == "Buy to Close") && dr["OrderStatus"].ToString() == "Filled")
            //        {
            //            GridData.Add(new Orders { Symbol = dr["Symbol"].ToString(), Side = dr["Side"].ToString(), Account = dr["Account"].ToString(), Quantity = dr["Quantity"].ToString(), AvgPrice = dr["AvgPrice"].ToString(), RemainingQuantity = dr["RemainingQuantity"].ToString(), OrderStatus = dr["OrderStatus"].ToString(), CLOrderID = dr["CLOrderID"].ToString(), ParentCLOrderID = dr["ParentCLOrderID"].ToString(), StaggedOrderID = dr["StaggedOrderID"].ToString(), OriginalCLOrderID = dr["OriginalCLOrderID"].ToString() });
            //        }
            //    }
            OpeningUltaGrid.DataSource = PerformOperation.SelectDataClosing("Opening");
            OpeningUltaGrid.DataBind();
            //}
            //else
            //{
            //    //creating column header if data is empty for UI
            //    Orders order = new Orders();
            //    OpeningUltaGrid.DataSource = order;
            //    OpeningUltaGrid.DataBind();
            //}
        }

        /// <summary>
        ///  Adding data to closing transaction ultra grid
        /// </summary>
        private void closingGrid()
        {
            //if (PerformOperation.StoreOrder.Rows.Count != 0)
            //{
            //    List<Orders> GridData = new List<Orders>();
            //    foreach (DataRow dr in PerformOperation.StoreOrder.Rows) // search whole table
            //    {
            //        if ((dr["Side"].ToString() == "Sell" || dr["Side"].ToString() == "Sell Short") && dr["OrderStatus"].ToString() == "Filled")
            //        {
            //            GridData.Add(new Orders { Symbol = dr["Symbol"].ToString(), Side = dr["Side"].ToString(), Account = dr["Account"].ToString(), Quantity = dr["Quantity"].ToString(), AvgPrice = dr["AvgPrice"].ToString(), RemainingQuantity = dr["RemainingQuantity"].ToString(), OrderStatus = dr["OrderStatus"].ToString(), CLOrderID = dr["CLOrderID"].ToString(), ParentCLOrderID = dr["ParentCLOrderID"].ToString(), StaggedOrderID = dr["StaggedOrderID"].ToString(), OriginalCLOrderID = dr["OriginalCLOrderID"].ToString() });
            //        }
            //    }
            CloseUltraGrid.DataSource = PerformOperation.SelectDataClosing("Closing");
            CloseUltraGrid.DataBind();
            //}
            //else
            //{
            //    //creating column header if data is empty for UI
            //    Orders order = new Orders();
            //    CloseUltraGrid.DataSource = order;
            //    CloseUltraGrid.DataBind();
            //}
        }

        /// <summary>
        ///  Adding data to closed data ultra grid
        /// </summary>
        private void closedDataGrid()
        {
            //if (PerformOperation.StoreOrder.Rows.Count != 0)
            //{
            //    List<Orders> GridData = new List<Orders>();
            //    foreach (DataRow dr in PerformOperation.StoreOrder.Rows) // search whole table
            //    {
            //        if (dr["Side"].ToString() == "Sell" && dr["OrderStatus"].ToString() == "Filled")
            //        {
            //            GridData.Add(new Orders { Symbol = dr["Symbol"].ToString(), Side = dr["Side"].ToString(), Account = dr["Account"].ToString(), Quantity = dr["Quantity"].ToString(), AvgPrice = dr["AvgPrice"].ToString(), RemainingQuantity = dr["RemainingQuantity"].ToString(), OrderStatus = dr["OrderStatus"].ToString(), CLOrderID = dr["CLOrderID"].ToString(), ParentCLOrderID = dr["ParentCLOrderID"].ToString(), StaggedOrderID = dr["StaggedOrderID"].ToString(), OriginalCLOrderID = dr["OriginalCLOrderID"].ToString() });
            //        }
            //    }
            //    ClosedDataUltraGrid.DataSource = GridData;
            //    ClosedDataUltraGrid.DataBind();
            //}
            //else
            //{
            //    //creating column header if data is empty for UI
            //    Orders order = new Orders();
            //    ClosedDataUltraGrid.DataSource = order;
            //    ClosedDataUltraGrid.DataBind();
            //}
        }
    }
}
