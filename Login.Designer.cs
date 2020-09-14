namespace PortfolioManagement
{
    partial class Login
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.ultraLabelUsername = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabelNirvana = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorUsername = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabelPassword = new Infragistics.Win.Misc.UltraLabel();
            this.ultraTextEditorPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraButtonLogin = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabelUsername
            // 
            this.ultraLabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabelUsername.Location = new System.Drawing.Point(30, 78);
            this.ultraLabelUsername.Name = "ultraLabelUsername";
            this.ultraLabelUsername.Size = new System.Drawing.Size(100, 23);
            this.ultraLabelUsername.TabIndex = 0;
            this.ultraLabelUsername.Text = "Username";
            // 
            // ultraLabelNirvana
            // 
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Top";
            this.ultraLabelNirvana.Appearance = appearance2;
            this.ultraLabelNirvana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabelNirvana.Location = new System.Drawing.Point(72, 34);
            this.ultraLabelNirvana.Name = "ultraLabelNirvana";
            this.ultraLabelNirvana.Size = new System.Drawing.Size(152, 27);
            this.ultraLabelNirvana.TabIndex = 1;
            this.ultraLabelNirvana.Text = "Nirvana Login";
            // 
            // ultraTextEditorUsername
            // 
            this.ultraTextEditorUsername.Location = new System.Drawing.Point(30, 96);
            this.ultraTextEditorUsername.Name = "ultraTextEditorUsername";
            this.ultraTextEditorUsername.Size = new System.Drawing.Size(206, 21);
            this.ultraTextEditorUsername.TabIndex = 2;
            // 
            // ultraLabelPassword
            // 
            this.ultraLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabelPassword.Location = new System.Drawing.Point(30, 133);
            this.ultraLabelPassword.Name = "ultraLabelPassword";
            this.ultraLabelPassword.Size = new System.Drawing.Size(100, 23);
            this.ultraLabelPassword.TabIndex = 3;
            this.ultraLabelPassword.Text = "Password";
            // 
            // ultraTextEditorPassword
            // 
            this.ultraTextEditorPassword.Location = new System.Drawing.Point(30, 153);
            this.ultraTextEditorPassword.Name = "ultraTextEditorPassword";
            this.ultraTextEditorPassword.PasswordChar = '●';
            this.ultraTextEditorPassword.Size = new System.Drawing.Size(206, 21);
            this.ultraTextEditorPassword.TabIndex = 4;
            // 
            // ultraButtonLogin
            // 
            this.ultraButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraButtonLogin.Location = new System.Drawing.Point(93, 198);
            this.ultraButtonLogin.Name = "ultraButtonLogin";
            this.ultraButtonLogin.Size = new System.Drawing.Size(75, 28);
            this.ultraButtonLogin.TabIndex = 5;
            this.ultraButtonLogin.Text = "Login";
            this.ultraButtonLogin.Click += new System.EventHandler(this.ultraButtonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ultraButtonLogin);
            this.Controls.Add(this.ultraTextEditorPassword);
            this.Controls.Add(this.ultraLabelPassword);
            this.Controls.Add(this.ultraTextEditorUsername);
            this.Controls.Add(this.ultraLabelNirvana);
            this.Controls.Add(this.ultraLabelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabelUsername;
        private Infragistics.Win.Misc.UltraLabel ultraLabelNirvana;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorUsername;
        private Infragistics.Win.Misc.UltraLabel ultraLabelPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorPassword;
        private Infragistics.Win.Misc.UltraButton ultraButtonLogin;
    }
}

