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
    public partial class  Allocation : Form
    {
        public Allocation()
        {
            InitializeComponent();

            Load += Allocation_Load;
        }

        /// <summary>
        /// Handles the Load event of the Allocation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void Allocation_Load(object sender, EventArgs e)
        {
            AllocatedGrid();
            UnallocatedGrid();

            ultraComboEditorAccount.DataSource = PerformOperation.FillAccountAllocate();
            ultraComboEditorAccount.DataBind();
        }
        
        /// <summary>
        /// Using the Splitter Control for hiding and unhiding the right panel
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ultraSplitter1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableLayoutPanel1.ColumnStyles[2].Width != 0)
                {
                    tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
                    tableLayoutPanel1.ColumnStyles[2].Width = 0;
                }
                else
                {
                    tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.ColumnStyles[2].Width = 229;
                }
            }
            catch (Exception)
            {
            }
        }
        
        /// <summary>
        /// Adding data to unallocated ultra grid
        /// </summary>
        private void UnallocatedGrid()
        {
            try
            {           
                //if (PerformOperation.StoreOrder.Rows.Count != 0)
                //{
                //    List<Orders> GridData = new List<Orders>();
                //    foreach (DataRow dr in PerformOperation.StoreOrder.Rows) // search whole table
                //    {
                //        if (dr["Account"].ToString() == "Unallocated" && dr["OrderStatus"].ToString() == "Filled")
                //        {
                //            GridData.Add(new Orders { Symbol = dr["Symbol"].ToString(), Side = dr["Side"].ToString(), Account = dr["Account"].ToString(), Quantity = dr["Quantity"].ToString(), AvgPrice = dr["AvgPrice"].ToString(), RemainingQuantity = dr["RemainingQuantity"].ToString(), OrderStatus = dr["OrderStatus"].ToString(), CLOrderID = dr["CLOrderID"].ToString(), ParentCLOrderID = dr["ParentCLOrderID"].ToString(), StaggedOrderID = dr["StaggedOrderID"].ToString(), OriginalCLOrderID = dr["OriginalCLOrderID"].ToString() });
                //        }
                //    }
                //    UnallocatedUltraGrid.DataSource = GridData;
                //    UnallocatedUltraGrid.DataBind();
                //}
                //else
                //{
                //    //creating column header if data is empty for UI
                //    Orders order = new Orders();
                //    UnallocatedUltraGrid.DataSource = order;
                //    UnallocatedUltraGrid.DataBind();
                //}

                UnallocatedUltraGrid.DataSource = PerformOperation.SelectDataAllocation("Unallocated");
                UnallocatedUltraGrid.DataBind();
            }
            catch (Exception)
            {
            }
        }
      
        /// <summary>
        /// Adding data to Allocated ultra grid 
        /// </summary>
        private void AllocatedGrid()
        {
            try
            {
                //if (PerformOperation.StoreOrder.Rows.Count != 0)
                //{
                //    List<Orders> GridData = new List<Orders>();
                //    foreach (DataRow dr in PerformOperation.StoreOrder.Rows) // search whole table
                //    {
                //        if (dr["Account"].ToString() != "Unallocated" && dr["OrderStatus"].ToString() == "Filled")
                //        {
                //            GridData.Add(new Orders { Symbol = dr["Symbol"].ToString(), Side = dr["Side"].ToString(), Account = dr["Account"].ToString(), Quantity = dr["Quantity"].ToString(), AvgPrice = dr["AvgPrice"].ToString(), RemainingQuantity = dr["RemainingQuantity"].ToString(), OrderStatus = dr["OrderStatus"].ToString(), CLOrderID = dr["CLOrderID"].ToString(), ParentCLOrderID = dr["ParentCLOrderID"].ToString(), StaggedOrderID = dr["StaggedOrderID"].ToString(), OriginalCLOrderID = dr["OriginalCLOrderID"].ToString() });
                //        }
                //    }
                //    AllocatedUltraGrid.DataSource = GridData;
                //    AllocatedUltraGrid.DataBind();
                //}
                //else
                //{
                //    //creating column header if data is empty for UI
                //    Orders order = new Orders();
                //    AllocatedUltraGrid.DataSource = order;
                //    AllocatedUltraGrid.DataBind();
                //}

                AllocatedUltraGrid.DataSource = PerformOperation.SelectDataAllocation("Allocated");
                AllocatedUltraGrid.DataBind();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Handles the Click event of the btnAllocate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ultraComboEditorAccount.Value.ToString() != "Select Account" && ultraComboEditorAccount.Value.ToString() != "")
                {
                    if (UnallocatedUltraGrid.Selected.Rows.Count != 0)
                    {
                        string PreviousAccount = this.UnallocatedUltraGrid.Selected.Rows[0].Cells["CLOrderID"].Value.ToString();

                        Orders order = new Orders();

                        order.Account = ultraComboEditorAccount.Value.ToString();

                        PerformOperation.UpdateAccount(order, PreviousAccount);
                        
                        string message = "Account allocated Successfully !!!";
                        string title = "Success Message";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                        AllocatedGrid();
                        UnallocatedGrid();
                    }
                    else
                    {
                        string message = "No Row Selected !!";
                        string title = "Failure Message";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    string message = "Please fill data properly !!!";
                    string title = "Validation Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                string message = "Please fill data properly !!!";
                string title = "Validation Message";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
        }
    }
}
