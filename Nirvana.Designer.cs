namespace PortfolioManagement
{
    partial class Nirvana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tradingTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyValuationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNirvana = new System.Windows.Forms.MenuStrip();
            this.ultraRadialMenu1 = new Infragistics.Win.UltraWinRadialMenu.UltraRadialMenu(this.components);
            this.menuStripNirvana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraRadialMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // tradingTicketToolStripMenuItem
            // 
            this.tradingTicketToolStripMenuItem.Name = "tradingTicketToolStripMenuItem";
            this.tradingTicketToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tradingTicketToolStripMenuItem.Text = "Trading Ticket";
            this.tradingTicketToolStripMenuItem.Click += new System.EventHandler(this.tradingTicketToolStripMenuItem_Click);
            // 
            // blotterToolStripMenuItem
            // 
            this.blotterToolStripMenuItem.Name = "blotterToolStripMenuItem";
            this.blotterToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.blotterToolStripMenuItem.Text = "Blotter";
            this.blotterToolStripMenuItem.Click += new System.EventHandler(this.blotterToolStripMenuItem_Click);
            // 
            // allocationToolStripMenuItem
            // 
            this.allocationToolStripMenuItem.Name = "allocationToolStripMenuItem";
            this.allocationToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.allocationToolStripMenuItem.Text = "Allocation";
            this.allocationToolStripMenuItem.Click += new System.EventHandler(this.allocationToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // dailyValuationToolStripMenuItem
            // 
            this.dailyValuationToolStripMenuItem.Name = "dailyValuationToolStripMenuItem";
            this.dailyValuationToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.dailyValuationToolStripMenuItem.Text = "Daily Valuation";
            this.dailyValuationToolStripMenuItem.Click += new System.EventHandler(this.dailyValuationToolStripMenuItem_Click);
            // 
            // portfolioManagementToolStripMenuItem
            // 
            this.portfolioManagementToolStripMenuItem.Name = "portfolioManagementToolStripMenuItem";
            this.portfolioManagementToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.portfolioManagementToolStripMenuItem.Text = "Portfolio Management";
            this.portfolioManagementToolStripMenuItem.Click += new System.EventHandler(this.portfolioManagementToolStripMenuItem_Click);
            // 
            // menuStripNirvana
            // 
            this.menuStripNirvana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tradingTicketToolStripMenuItem,
            this.blotterToolStripMenuItem,
            this.allocationToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.dailyValuationToolStripMenuItem,
            this.portfolioManagementToolStripMenuItem});
            this.menuStripNirvana.Location = new System.Drawing.Point(0, 0);
            this.menuStripNirvana.Name = "menuStripNirvana";
            this.menuStripNirvana.Size = new System.Drawing.Size(532, 24);
            this.menuStripNirvana.TabIndex = 2;
            // 
            // ultraRadialMenu1
            // 
            this.ultraRadialMenu1.OwningControl = this;
            // 
            // Nirvana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 32);
            this.Controls.Add(this.menuStripNirvana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Nirvana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nirvana";
            this.menuStripNirvana.ResumeLayout(false);
            this.menuStripNirvana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraRadialMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tradingTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blotterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyValuationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioManagementToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripNirvana;
        private Infragistics.Win.UltraWinRadialMenu.UltraRadialMenu ultraRadialMenu1;

    }
}