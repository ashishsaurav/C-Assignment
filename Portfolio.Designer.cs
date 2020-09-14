namespace PortfolioManagement
{
    partial class Portfolio
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraGroupBoxPortfolio = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGridPortfolio = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.tTradedOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxPortfolio)).BeginInit();
            this.ultraGroupBoxPortfolio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPortfolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTradedOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraGroupBoxPortfolio);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(827, 381);
            this.ultraPanel1.TabIndex = 0;
            // 
            // ultraGroupBoxPortfolio
            // 
            this.ultraGroupBoxPortfolio.Controls.Add(this.ultraGridPortfolio);
            this.ultraGroupBoxPortfolio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBoxPortfolio.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBoxPortfolio.Name = "ultraGroupBoxPortfolio";
            this.ultraGroupBoxPortfolio.Size = new System.Drawing.Size(827, 381);
            this.ultraGroupBoxPortfolio.TabIndex = 8;
            this.ultraGroupBoxPortfolio.Text = "Unallocated and Some Other Accounts";
            // 
            // ultraGridPortfolio
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGridPortfolio.DisplayLayout.Appearance = appearance1;
            this.ultraGridPortfolio.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGridPortfolio.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridPortfolio.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridPortfolio.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraGridPortfolio.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGridPortfolio.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraGridPortfolio.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGridPortfolio.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGridPortfolio.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGridPortfolio.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGridPortfolio.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.WithinBand;
            this.ultraGridPortfolio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGridPortfolio.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGridPortfolio.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridPortfolio.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGridPortfolio.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGridPortfolio.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ultraGridPortfolio.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGridPortfolio.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ultraGridPortfolio.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraGridPortfolio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGridPortfolio.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraGridPortfolio.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraGridPortfolio.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            this.ultraGridPortfolio.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGridPortfolio.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.ultraGridPortfolio.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.ultraGridPortfolio.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGridPortfolio.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGridPortfolio.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGridPortfolio.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridPortfolio.DisplayLayout.UseFixedHeaders = true;
            this.ultraGridPortfolio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGridPortfolio.Location = new System.Drawing.Point(3, 16);
            this.ultraGridPortfolio.Name = "ultraGridPortfolio";
            this.ultraGridPortfolio.Size = new System.Drawing.Size(821, 362);
            this.ultraGridPortfolio.TabIndex = 0;
            this.ultraGridPortfolio.Text = "ultraGrid1";
            // 
            // Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 381);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "Portfolio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portfolio";
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxPortfolio)).EndInit();
            this.ultraGroupBoxPortfolio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPortfolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTradedOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxPortfolio;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridPortfolio;
        private System.Windows.Forms.BindingSource tTradedOrdersBindingSource;
    }
}