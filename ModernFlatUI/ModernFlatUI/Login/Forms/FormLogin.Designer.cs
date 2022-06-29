
namespace ModernFlatUI.Login.Forms
{
    partial class FormLogin
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.AttemptLoginLabel = new System.Windows.Forms.Label();
            this.LoginDataGrid = new System.Windows.Forms.DataGridView();
            this.ShowMainMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.LoginLabel.Location = new System.Drawing.Point(34, 27);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(59, 23);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(34, 157);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(34, 180);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(154, 23);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(34, 77);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 17);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(34, 100);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(154, 23);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(34, 228);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(154, 50);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Location = new System.Drawing.Point(77, 263);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 15);
            this.ErrorMessage.TabIndex = 8;
            // 
            // AttemptLoginLabel
            // 
            this.AttemptLoginLabel.AutoSize = true;
            this.AttemptLoginLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttemptLoginLabel.Location = new System.Drawing.Point(34, 320);
            this.AttemptLoginLabel.Name = "AttemptLoginLabel";
            this.AttemptLoginLabel.Size = new System.Drawing.Size(0, 17);
            this.AttemptLoginLabel.TabIndex = 9;
            this.AttemptLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttemptLoginLabel.Click += new System.EventHandler(this.AttemptLoginLabel_Click);
            // 
            // LoginDataGrid
            // 
            this.LoginDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoginDataGrid.Location = new System.Drawing.Point(276, 77);
            this.LoginDataGrid.Name = "LoginDataGrid";
            this.LoginDataGrid.RowTemplate.Height = 25;
            this.LoginDataGrid.Size = new System.Drawing.Size(292, 228);
            this.LoginDataGrid.TabIndex = 10;
            // 
            // ShowMainMenuBtn
            // 
            this.ShowMainMenuBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowMainMenuBtn.Location = new System.Drawing.Point(34, 368);
            this.ShowMainMenuBtn.Name = "ShowMainMenuBtn";
            this.ShowMainMenuBtn.Size = new System.Drawing.Size(154, 50);
            this.ShowMainMenuBtn.TabIndex = 11;
            this.ShowMainMenuBtn.Text = "Show Dashboard";
            this.ShowMainMenuBtn.UseVisualStyleBackColor = true;
            this.ShowMainMenuBtn.Visible = false;
            this.ShowMainMenuBtn.Click += new System.EventHandler(this.ShowMainMenuBtn_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 589);
            this.Controls.Add(this.ShowMainMenuBtn);
            this.Controls.Add(this.LoginDataGrid);
            this.Controls.Add(this.AttemptLoginLabel);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Label AttemptLoginLabel;
        private System.Windows.Forms.DataGridView LoginDataGrid;
        private System.Windows.Forms.Button ShowMainMenuBtn;
    }
}