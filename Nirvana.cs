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
    public partial class Nirvana : Form
    {
        public Nirvana()
        {
            InitializeComponent();          
        }

        /// <summary>
        /// Opens Trading Ticket Form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tradingTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking if any form is already open or not!
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(TradingTicket))
                {
                    form.Activate();
                    return;
                }
            }

            TradingTicket trading = new TradingTicket();
            trading.Show();
        }

        /// <summary>
        ///Opens Blotter Form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void blotterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking if any form is already open or not!
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Blotter))
                {
                    form.Activate();
                    return;
                }
            }

            Blotter blotter = new Blotter();
            blotter.Show();
        }

        /// <summary>
        /// Opens Allocation Form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void allocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking if any form is already open or not!
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Allocation))
                {
                    form.Activate();
                    return;
                }
            }

            Allocation allocate = new Allocation();
            allocate.Show();
          
        }

        /// <summary>
        /// Opens Closing Form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking if any form is already open or not!
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Closing))
                {
                    form.Activate();
                    return;
                }
            }

            Closing close = new Closing();
            close.Show();
            
        }

        private void dailyValuationToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        /// <summary>
        /// Opens Potfolio Management Form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void portfolioManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking if any form is already open or not!
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Portfolio))
                {
                    form.Activate();
                    return;
                }
            }

            Portfolio port = new Portfolio();
            port.Show();
        }  
    }
}
