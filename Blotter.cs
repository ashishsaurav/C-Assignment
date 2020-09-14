using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Infragistics.Win.UltraWinGrid;

namespace PortfolioManagement
{
    public partial class Blotter : Form
    {
        public static string BlotterPassTT = null;
        public static int BlotterPassTTQty = 0;
        public static int BlotterPassTTRemQty = 0;
        public Blotter()
        {
            InitializeComponent();

            Load += Blotter_Load;
        }

        /// <summary>
        /// Handles the Load event of the Blotter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void Blotter_Load(object sender, EventArgs e)
        {
           OrdersGrid();
        }

        /// <summary>
        /// Orderses the grid.
        /// </summary>
        private void OrdersGrid()
        {
            //if (PerformOperation.StoreOrder.Rows.Count != 0)
            //{
            OrderUltraGrid.DataSource = PerformOperation.SelectDataBlotter();
            OrderUltraGrid.DataBind();
            //}
            //else
            //{
                //creating column header if data is empty for UI
                //Orders order = new Orders();
                //OrderUltraGrid.DataSource = order;
                //OrderUltraGrid.DataBind();
            //}
        }

       /// <summary>
        ///  adding rows in sub order grid after selection in order grid
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Orders_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            try
            {
                if (OrderUltraGrid.Selected.Rows.Count != 0)
                {
                    UltraGridRow row = this.OrderUltraGrid.Selected.Rows[0];

                    if (row.Cells["OrderStatus"].Value.ToString() == "Filled" || row.Cells["OrderStatus"].Value.ToString() == "PartiallyFilled")
                    {
                        SubOrdersUltraGrid.DataSource = PerformOperation.SelectData(row.Cells["CLOrderId"].Value.ToString());
                        SubOrdersUltraGrid.DataBind();
                    }
                    else
                    {
                        SubOrdersUltraGrid.DataSource = null;
                        SubOrdersUltraGrid.DataBind();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Showing Context menu strip on right click
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void OrderUltraGrid_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                OrderUltraGrid.Selected.Rows.Clear();
                Infragistics.Win.UltraWinGrid.UltraGridRow row;
                Infragistics.Win.UIElement element;

                if (e.Button == MouseButtons.Right)
                {
                    element = OrderUltraGrid.DisplayLayout.UIElement.ElementFromPoint(e.Location);

                    row = element.GetContext(typeof(Infragistics.Win.UltraWinGrid.UltraGridRow)) as Infragistics.Win.UltraWinGrid.UltraGridRow;
                    if (row != null && row.IsDataRow)
                    {
                         row.Selected = true;
                         contextMenuStripRightEnabled.Show(Cursor.Position.X, Cursor.Position.Y);                       
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Handles the Click event of the menu strip create new sub order control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderUltraGrid.Selected.Rows.Count != 0)
                {
                    BlotterPassTT = this.OrderUltraGrid.Selected.Rows[0].Cells["CLOrderId"].Value.ToString();
                    BlotterPassTTQty = Convert.ToInt32(this.OrderUltraGrid.Selected.Rows[0].Cells["Quantity"].Value.ToString());
                    BlotterPassTTRemQty = Convert.ToInt32(this.OrderUltraGrid.Selected.Rows[0].Cells["RemainingQuantity"].Value.ToString());

                    TradingTicket trading = new TradingTicket(this, "toolStripCreate");
                    trading.ShowDialog();
                    OrdersGrid();
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Handles the Click event of the menu strip edit control..
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderUltraGrid.Selected.Rows.Count != 0)
                {
                    BlotterPassTT = this.OrderUltraGrid.Selected.Rows[0].Cells["CLOrderId"].Value.ToString();
                    BlotterPassTTQty = Convert.ToInt32(this.OrderUltraGrid.Selected.Rows[0].Cells["Quantity"].Value.ToString());
                    BlotterPassTTRemQty = Convert.ToInt32(this.OrderUltraGrid.Selected.Rows[0].Cells["RemainingQuantity"].Value.ToString());
                   
                    TradingTicket trading = new TradingTicket(this, "toolStripEdit");
                    trading.ShowDialog();
                    OrdersGrid();
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Handles the Click event of the Remove control for order status = new.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderUltraGrid.Selected.Rows.Count != 0)
                {
                    UltraGridRow row = this.OrderUltraGrid.Selected.Rows[0];

                    PerformOperation.DeleteData(row.Cells["CLOrderId"].Value.ToString());
                    OrdersGrid();
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// showing the context menu on specific checking of the row i.e, new or filled order status.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void contextMenuStripRightEnabled_Opening(object sender, CancelEventArgs e)
        {
            if (OrderUltraGrid.Selected.Rows.Count != 0)
            {
                UltraGridRow row = this.OrderUltraGrid.Selected.Rows[0];

                if (row.Cells["OrderStatus"].Value.ToString() == "Filled")
                {
                    contextMenuStripRightEnabled.Items["toolStripCreate"].Enabled = false;
                    contextMenuStripRightEnabled.Items["toolStripEdit"].Enabled = false;
                    contextMenuStripRightEnabled.Items["toolStripRemove"].Enabled = true;
                }
                else
                {
                    contextMenuStripRightEnabled.Items["toolStripCreate"].Enabled = true;
                    contextMenuStripRightEnabled.Items["toolStripEdit"].Enabled = true;
                    contextMenuStripRightEnabled.Items["toolStripRemove"].Enabled = true;
                }
            }
        }
    }
}
