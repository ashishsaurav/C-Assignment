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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// for validating the user to go to main page
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ultraButtonLogin_Click(object sender, EventArgs e)
        {
            bool login = PerformOperation.Login(ultraTextEditorUsername.Text, ultraTextEditorPassword.Text);
            if (login)
            {
                Nirvana nirvana = new Nirvana();
                nirvana.Show(this);
                Hide();
            }
            else
            {
                string message = "Entered username or password is incorrect !!!";
                string title = "Error Message";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }
    }
}
