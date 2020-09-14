namespace PortfolioManagement
{
    partial class TradingTicket
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
            this.ultraLabelSymbol = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelSide = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelAccount = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelQuantity = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelPrice = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorSymbol = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraComboEditorSide = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraComboEditorAccount = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraButtonDoneAway = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonCreateOrder = new Infragistics.Win.Misc.UltraButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ultraBtnCreateBlotter = new Infragistics.Win.Misc.UltraButton();
            this.ultraBtnEditBlotter = new Infragistics.Win.Misc.UltraButton();
            this.ultraTextEditorQuantity = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditorPrice = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabelSymbol
            // 
            this.ultraLabelSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabelSymbol.Location = new System.Drawing.Point(0, 0);
            this.ultraLabelSymbol.Name = "ultraLabelSymbol";
            this.ultraLabelSymbol.Size = new System.Drawing.Size(69, 23);
            this.ultraLabelSymbol.TabIndex = 0;
            this.ultraLabelSymbol.Text = "Symbol";
            // 
            // ultraLabelSide
            // 
            this.ultraLabelSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabelSide.Location = new System.Drawing.Point(125, 0);
            this.ultraLabelSide.Name = "ultraLabelSide";
            this.ultraLabelSide.Size = new System.Drawing.Size(69, 23);
            this.ultraLabelSide.TabIndex = 1;
            this.ultraLabelSide.Text = "Side";
            // 
            // ultraLabelAccount
            // 
            this.ultraLabelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabelAccount.Location = new System.Drawing.Point(296, 0);
            this.ultraLabelAccount.Name = "ultraLabelAccount";
            this.ultraLabelAccount.Size = new System.Drawing.Size(69, 19);
            this.ultraLabelAccount.TabIndex = 2;
            this.ultraLabelAccount.Text = "Account";
            // 
            // ultraLabelQuantity
            // 
            this.ultraLabelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabelQuantity.Location = new System.Drawing.Point(456, 0);
            this.ultraLabelQuantity.Name = "ultraLabelQuantity";
            this.ultraLabelQuantity.Size = new System.Drawing.Size(69, 19);
            this.ultraLabelQuantity.TabIndex = 3;
            this.ultraLabelQuantity.Text = "Quantity";
            // 
            // ultraLabelPrice
            // 
            this.ultraLabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabelPrice.Location = new System.Drawing.Point(583, 0);
            this.ultraLabelPrice.Name = "ultraLabelPrice";
            this.ultraLabelPrice.Size = new System.Drawing.Size(69, 19);
            this.ultraLabelPrice.TabIndex = 4;
            this.ultraLabelPrice.Text = "Price";
            // 
            // ultraTextEditorSymbol
            // 
            this.ultraTextEditorSymbol.Location = new System.Drawing.Point(0, 29);
            this.ultraTextEditorSymbol.Name = "ultraTextEditorSymbol";
            this.ultraTextEditorSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultraTextEditorSymbol.Size = new System.Drawing.Size(116, 21);
            this.ultraTextEditorSymbol.TabIndex = 6;
            this.ultraTextEditorSymbol.Tag = "";
            this.ultraTextEditorSymbol.Enter += new System.EventHandler(this.ultraTextEditorSymbol_Enter);
            this.ultraTextEditorSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ultraTextEditorSymbol_KeyPress);
            this.ultraTextEditorSymbol.Leave += new System.EventHandler(this.ultraTextEditorSymbol_Leave);
            // 
            // ultraComboEditorSide
            // 
            this.ultraComboEditorSide.Location = new System.Drawing.Point(122, 29);
            this.ultraComboEditorSide.Name = "ultraComboEditorSide";
            this.ultraComboEditorSide.Size = new System.Drawing.Size(144, 21);
            this.ultraComboEditorSide.TabIndex = 7;
            this.ultraComboEditorSide.Text = "Select Side";
            // 
            // ultraComboEditorAccount
            // 
            this.ultraComboEditorAccount.Location = new System.Drawing.Point(296, 29);
            this.ultraComboEditorAccount.Name = "ultraComboEditorAccount";
            this.ultraComboEditorAccount.Size = new System.Drawing.Size(144, 21);
            this.ultraComboEditorAccount.TabIndex = 8;
            this.ultraComboEditorAccount.Text = "Select Account";
            // 
            // ultraButtonDoneAway
            // 
            this.ultraButtonDoneAway.Location = new System.Drawing.Point(583, 62);
            this.ultraButtonDoneAway.Name = "ultraButtonDoneAway";
            this.ultraButtonDoneAway.Size = new System.Drawing.Size(116, 23);
            this.ultraButtonDoneAway.TabIndex = 11;
            this.ultraButtonDoneAway.Text = "Done Away";
            this.ultraButtonDoneAway.Click += new System.EventHandler(this.ultraButtonDoneOrder_Click);
            // 
            // ultraButtonCreateOrder
            // 
            this.ultraButtonCreateOrder.Location = new System.Drawing.Point(456, 62);
            this.ultraButtonCreateOrder.Name = "ultraButtonCreateOrder";
            this.ultraButtonCreateOrder.Size = new System.Drawing.Size(116, 23);
            this.ultraButtonCreateOrder.TabIndex = 12;
            this.ultraButtonCreateOrder.Text = "Create Order";
            this.ultraButtonCreateOrder.Click += new System.EventHandler(this.ultraButtonCreateOrder_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(706, 97);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 119;
            this.lineShape1.X2 = 120;
            this.lineShape1.Y1 = -1;
            this.lineShape1.Y2 = 98;
            // 
            // ultraBtnCreateBlotter
            // 
            this.ultraBtnCreateBlotter.Location = new System.Drawing.Point(583, 62);
            this.ultraBtnCreateBlotter.Name = "ultraBtnCreateBlotter";
            this.ultraBtnCreateBlotter.Size = new System.Drawing.Size(116, 23);
            this.ultraBtnCreateBlotter.TabIndex = 16;
            this.ultraBtnCreateBlotter.Text = "Done Away";
            this.ultraBtnCreateBlotter.Visible = false;
            this.ultraBtnCreateBlotter.Click += new System.EventHandler(this.ultraBtnCreateBlotter_Click);
            // 
            // ultraBtnEditBlotter
            // 
            this.ultraBtnEditBlotter.Location = new System.Drawing.Point(583, 61);
            this.ultraBtnEditBlotter.Name = "ultraBtnEditBlotter";
            this.ultraBtnEditBlotter.Size = new System.Drawing.Size(116, 23);
            this.ultraBtnEditBlotter.TabIndex = 17;
            this.ultraBtnEditBlotter.Text = "Save";
            this.ultraBtnEditBlotter.Visible = false;
            this.ultraBtnEditBlotter.Click += new System.EventHandler(this.ultraBtnEditBlotter_Click);
            // 
            // ultraTextEditorQuantity
            // 
            this.ultraTextEditorQuantity.Location = new System.Drawing.Point(456, 28);
            this.ultraTextEditorQuantity.MaxLength = 7;
            this.ultraTextEditorQuantity.Name = "ultraTextEditorQuantity";
            this.ultraTextEditorQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraTextEditorQuantity.Size = new System.Drawing.Size(116, 21);
            this.ultraTextEditorQuantity.TabIndex = 18;
            this.ultraTextEditorQuantity.Tag = "";
            this.ultraTextEditorQuantity.Text = "0";
            this.ultraTextEditorQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ultraTextEditorQuantity_KeyPress);
            // 
            // ultraTextEditorPrice
            // 
            this.ultraTextEditorPrice.Location = new System.Drawing.Point(583, 28);
            this.ultraTextEditorPrice.MaxLength = 9;
            this.ultraTextEditorPrice.Name = "ultraTextEditorPrice";
            this.ultraTextEditorPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraTextEditorPrice.Size = new System.Drawing.Size(116, 21);
            this.ultraTextEditorPrice.TabIndex = 19;
            this.ultraTextEditorPrice.Tag = "";
            this.ultraTextEditorPrice.Text = "0.0";
            this.ultraTextEditorPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ultraTextEditorPrice_KeyPress);
            // 
            // TradingTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 97);
            this.Controls.Add(this.ultraTextEditorPrice);
            this.Controls.Add(this.ultraTextEditorQuantity);
            this.Controls.Add(this.ultraBtnEditBlotter);
            this.Controls.Add(this.ultraBtnCreateBlotter);
            this.Controls.Add(this.ultraButtonCreateOrder);
            this.Controls.Add(this.ultraButtonDoneAway);
            this.Controls.Add(this.ultraComboEditorAccount);
            this.Controls.Add(this.ultraComboEditorSide);
            this.Controls.Add(this.ultraTextEditorSymbol);
            this.Controls.Add(this.ultraLabelPrice);
            this.Controls.Add(this.ultraLabelQuantity);
            this.Controls.Add(this.ultraLabelAccount);
            this.Controls.Add(this.ultraLabelSide);
            this.Controls.Add(this.ultraLabelSymbol);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TradingTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TradingTicket";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabelSymbol;
        private Infragistics.Win.Misc.UltraLabel ultraLabelSide;
        private Infragistics.Win.Misc.UltraLabel ultraLabelAccount;
        private Infragistics.Win.Misc.UltraLabel ultraLabelQuantity;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPrice;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorSymbol;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditorSide;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor ultraComboEditorAccount;
        private Infragistics.Win.Misc.UltraButton ultraButtonDoneAway;
        private Infragistics.Win.Misc.UltraButton ultraButtonCreateOrder;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Infragistics.Win.Misc.UltraButton ultraBtnCreateBlotter;
        private Infragistics.Win.Misc.UltraButton ultraBtnEditBlotter;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorQuantity;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorPrice;
    }
}