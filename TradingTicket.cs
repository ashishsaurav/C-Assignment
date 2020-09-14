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
    public partial class TradingTicket : Form
    {
        public static int idForOrder = 0;
        public static int QtyFilled = 0;
        public TradingTicket()
        {
            InitializeComponent();
            
            Load+=TradingTicket_Load;
        }

        /// <summary>
        /// Handles the Load event of the TradingTicket control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TradingTicket_Load(object sender, EventArgs e)
        {

            ultraComboEditorSide.DataSource = PerformOperation.FillSide();
            ultraComboEditorSide.DataBind();

            ultraComboEditorAccount.DataSource = PerformOperation.FillAccount();
            ultraComboEditorAccount.DataBind();

            // adding the placeholder to text box
            ultraTextEditorSymbol.Text = "Enter Symbol";
        }

        /// <summary>
        /// Initializes a parameterised constructor.
        /// </summary>
        /// <param name="frm">The FRM.</param>
        /// <param name="menuStrip">The menu strip.</param>
        public TradingTicket( Form frm, string menuStrip)
        {
            try
            {
                if (frm.Text == "Blotter")
                {
                    InitializeComponent();

                    //foreach (DataRow dr in PerformOperation.StoreOrder.Rows) // search whole table
                    //{
                    List<Orders> dr = PerformOperation.InputFromBlotter(Blotter.BlotterPassTT);
                        if (dr[0].CLOrderID.ToString() == Blotter.BlotterPassTT)
                        {
                            ultraTextEditorSymbol.Text = dr[0].Symbol.ToString();
                            ultraTextEditorSymbol.Enabled = false;
                            ultraComboEditorSide.Value = dr[0].Side.ToString();
                            ultraComboEditorSide.Enabled = false;
                            if (menuStrip == "toolStripCreate")
                            {
                                ultraComboEditorAccount.Value = dr[0].Account.ToString();
                                ultraComboEditorAccount.Enabled = false;
                                ultraBtnCreateBlotter.Visible = true;
                            }
                            else if (menuStrip == "toolStripEdit")
                            {
                                ultraComboEditorAccount.DataSource = PerformOperation.FillAccount();
                                ultraComboEditorAccount.DataBind();

                                ultraComboEditorAccount.SelectedIndex = ultraComboEditorAccount.FindString(dr[0].Account.ToString());
                                ultraBtnEditBlotter.Visible = true;
                            }
                            ultraTextEditorQuantity.Value = dr[0].Quantity.ToString();
                            ultraTextEditorPrice.Value = dr[0].AvgPrice.ToString();

                            ultraButtonCreateOrder.Visible = false;
                            ultraButtonDoneAway.Visible = false;

                            //break;
                        }
                    //}
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// create order button click event
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ultraButtonCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (ultraTextEditorSymbol.Text != "" && ultraTextEditorSymbol.Text != "Enter Symbol" && ultraComboEditorSide.Value.ToString() != "Select Side" && ultraComboEditorSide.Value.ToString() != "" && ultraComboEditorAccount.Value.ToString() != "Select Account" && ultraComboEditorAccount.Value.ToString() != "" && ultraTextEditorQuantity.Value.ToString() != "" && ultraTextEditorQuantity.Value.ToString() != "0" && ultraTextEditorPrice.Value.ToString() != "" && ultraTextEditorPrice.Value.ToString() != "0")
                {
                    //idForOrder++;

                    Orders order = new Orders();
                    order.Symbol = ultraTextEditorSymbol.Text;
                    order.Side = ultraComboEditorSide.SelectedItem.ToString();
                    order.Account = ultraComboEditorAccount.SelectedItem.ToString();
                    order.Quantity = ultraTextEditorQuantity.Value.ToString();
                    order.AvgPrice = ultraTextEditorPrice.Value.ToString();
                    order.RemainingQuantity = ultraTextEditorQuantity.Value.ToString();
                    order.OrderStatus = "New";
                    //order.CLOrderID = "Order" + idForOrder;
                    //order.ParentCLOrderID = "Order" + idForOrder;
                    //order.StaggedOrderID = " ";
                    //order.OriginalCLOrderID = " ";

                    PerformOperation.InsertData(order,"Create");
                    string message = "Order Placed Successfully !!!";
                    string title = "Success Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
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

        /// <summary>
        /// done order button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ultraButtonDoneOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (ultraTextEditorSymbol.Text != "" && ultraTextEditorSymbol.Text != "Enter Symbol" && ultraComboEditorSide.Value.ToString() != "Select Side" && ultraComboEditorSide.Value.ToString() != "" && ultraComboEditorAccount.Value.ToString() != "Select Account" && ultraComboEditorAccount.Value.ToString() != "" && ultraTextEditorQuantity.Value.ToString() != "" && ultraTextEditorQuantity.Value.ToString() != "0" && ultraTextEditorPrice.Value.ToString() != "" && ultraTextEditorPrice.Value.ToString() != "0")
                {
                    //idForOrder++;

                    Orders order = new Orders();
                    order.Symbol = ultraTextEditorSymbol.Text;
                    order.Side = ultraComboEditorSide.SelectedItem.ToString();
                    order.Account = ultraComboEditorAccount.SelectedItem.ToString();
                    order.Quantity = ultraTextEditorQuantity.Value.ToString();
                    order.AvgPrice = ultraTextEditorPrice.Value.ToString();
                    order.RemainingQuantity = "0";
                    order.OrderStatus = "Filled";
                    //order.CLOrderID = "Order" + idForOrder;
                    //order.ParentCLOrderID = "Order" + idForOrder;
                    //order.StaggedOrderID = " ";
                    //order.OriginalCLOrderID = " ";

                    PerformOperation.InsertData(order,"Done");
                    string message = "Order Placed Successfully !!!";
                    string title = "Success Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
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

        /// <summary>
        ///  removing the placeholder from text box on entering event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ultraTextEditorSymbol_Enter(object sender, EventArgs e)
        {
            if (ultraTextEditorSymbol.Text == "Enter Symbol")
            {
                ultraTextEditorSymbol.Text = "";
            }
        }

        /// <summary>
        ///  adding the placeholder to text box on leaving event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ultraTextEditorSymbol_Leave(object sender, EventArgs e)
        {
            if (ultraTextEditorSymbol.Text == "")
            {
                ultraTextEditorSymbol.Text = "Enter Symbol";
            }
        }

        /// <summary>
        /// Creating new sub order after processing from blotter.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ultraBtnCreateBlotter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ultraTextEditorQuantity.Value.ToString() != "" && ultraTextEditorQuantity.Value.ToString() != "0" && ultraTextEditorPrice.Value.ToString() != "" && ultraTextEditorPrice.Value.ToString() != "0")
                {
                    Orders order = new Orders();

                    order.Symbol = ultraTextEditorSymbol.Value.ToString();
                    order.Side = ultraComboEditorSide.Value.ToString();
                    order.Account = ultraComboEditorAccount.Value.ToString();
                    order.Quantity = Blotter.BlotterPassTTQty.ToString();
                    order.AvgPrice = ultraTextEditorPrice.Value.ToString();
                    if (Blotter.BlotterPassTTRemQty > Convert.ToInt32(ultraTextEditorQuantity.Value.ToString()))
                    {
                        order.RemainingQuantity = (Blotter.BlotterPassTTRemQty - Convert.ToInt32(ultraTextEditorQuantity.Value.ToString())).ToString();
                        order.OrderStatus = "PartiallyFilled";
                        QtyFilled = Convert.ToInt32(ultraTextEditorQuantity.Value.ToString());

                        PerformOperation.UpdateData(order, Blotter.BlotterPassTT,"Create");

                        string message = "Order Placed Successfully !!!";
                        string title = "Success Message";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    }
                    else if (Blotter.BlotterPassTTRemQty == Convert.ToInt32(ultraTextEditorQuantity.Value.ToString()))
                    {
                        QtyFilled = Convert.ToInt32(ultraTextEditorQuantity.Value.ToString());
                        order.RemainingQuantity = "0";
                        order.OrderStatus = "Filled";

                        PerformOperation.UpdateData(order, Blotter.BlotterPassTT, "Create");

                        string message = "Order Placed Successfully !!!";
                        string title = "Success Message";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                    }
                    else
                    {
                        string message = "Can't trade more than specified quantity !!!";
                        string title = "Validation Message";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    }                    
                    this.Close();
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

        /// <summary>
        /// Edit sub order after processing from blotter.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ultraBtnEditBlotter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ultraComboEditorAccount.Value.ToString() != "Select Account" && ultraComboEditorAccount.Value.ToString() != "" && ultraTextEditorQuantity.Value.ToString() != "" && ultraTextEditorQuantity.Value.ToString() != "0" && ultraTextEditorPrice.Value.ToString() != "" && ultraTextEditorPrice.Value.ToString() != "0")
                {
                    Orders order = new Orders();

                    order.Account = ultraComboEditorAccount.Value.ToString();
                    order.Quantity = ultraTextEditorQuantity.Value.ToString();
                    order.AvgPrice = ultraTextEditorPrice.Value.ToString();
                    order.RemainingQuantity = (Convert.ToInt32(ultraTextEditorQuantity.Value.ToString()) - Convert.ToInt32(Blotter.BlotterPassTTQty) + Blotter.BlotterPassTTRemQty).ToString();

                    PerformOperation.UpdateData(order, Blotter.BlotterPassTT,"Edit");
                    
                    string message = "Order Edited Successfully !!!";
                    string title = "Success Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
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

        /// <summary>
        ///  Validating the chararcters to enter int quantity text editor
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void ultraTextEditorQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        /// <summary>
        /// Validating the chararcters to enter int and float price text editor
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void ultraTextEditorPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;
            // Is Float Number?
            if (e.KeyChar == '.' && text.Length > 0 && !text.Contains("."))
            {
                e.Handled = false;
                return;
            }

            // Is Digit?
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        /// <summary>
        /// converting the lowercase char to upper case in symbol text editor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ultraTextEditorSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
