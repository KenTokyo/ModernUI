
namespace ModernFlatUI
{
    partial class UserControlAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ExistingAccountsGrid = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateExistingAccountLabel = new System.Windows.Forms.Label();
            this.SelectCategoryLabel = new System.Windows.Forms.Label();
            this.KeywordsLabel = new System.Windows.Forms.Label();
            this.KeywordsText = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExistingAccountsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Username",
            "Name",
            "Email"});
            this.CategoryComboBox.Location = new System.Drawing.Point(46, 403);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 23);
            this.CategoryComboBox.TabIndex = 110;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectLoginDataCategory_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(46, 507);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(195, 35);
            this.SearchButton.TabIndex = 109;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Thistle;
            this.label8.Location = new System.Drawing.Point(47, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 108;
            this.label8.Text = "Search Account:";
            // 
            // ExistingAccountsGrid
            // 
            this.ExistingAccountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExistingAccountsGrid.Location = new System.Drawing.Point(318, 343);
            this.ExistingAccountsGrid.Name = "ExistingAccountsGrid";
            this.ExistingAccountsGrid.RowTemplate.Height = 25;
            this.ExistingAccountsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExistingAccountsGrid.Size = new System.Drawing.Size(315, 182);
            this.ExistingAccountsGrid.TabIndex = 107;
            this.ExistingAccountsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExistingAccountsGrid_CellContentClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(46, 564);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(195, 35);
            this.UpdateButton.TabIndex = 106;
            this.UpdateButton.Text = "Update Selected Account";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateLoginDataButton_Click);
            // 
            // UpdateExistingAccountLabel
            // 
            this.UpdateExistingAccountLabel.AutoSize = true;
            this.UpdateExistingAccountLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateExistingAccountLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.UpdateExistingAccountLabel.Location = new System.Drawing.Point(46, 302);
            this.UpdateExistingAccountLabel.Name = "UpdateExistingAccountLabel";
            this.UpdateExistingAccountLabel.Size = new System.Drawing.Size(237, 23);
            this.UpdateExistingAccountLabel.TabIndex = 105;
            this.UpdateExistingAccountLabel.Text = "Update Existing Account";
            // 
            // SelectCategoryLabel
            // 
            this.SelectCategoryLabel.AutoSize = true;
            this.SelectCategoryLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectCategoryLabel.Location = new System.Drawing.Point(46, 375);
            this.SelectCategoryLabel.Name = "SelectCategoryLabel";
            this.SelectCategoryLabel.Size = new System.Drawing.Size(94, 16);
            this.SelectCategoryLabel.TabIndex = 104;
            this.SelectCategoryLabel.Text = "Select Category";
            // 
            // KeywordsLabel
            // 
            this.KeywordsLabel.AutoSize = true;
            this.KeywordsLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeywordsLabel.Location = new System.Drawing.Point(46, 436);
            this.KeywordsLabel.Name = "KeywordsLabel";
            this.KeywordsLabel.Size = new System.Drawing.Size(59, 16);
            this.KeywordsLabel.TabIndex = 103;
            this.KeywordsLabel.Text = "Keywords";
            // 
            // KeywordsText
            // 
            this.KeywordsText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeywordsText.Location = new System.Drawing.Point(46, 459);
            this.KeywordsText.Name = "KeywordsText";
            this.KeywordsText.Size = new System.Drawing.Size(154, 21);
            this.KeywordsText.TabIndex = 102;
            this.KeywordsText.TextChanged += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(318, 564);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(191, 35);
            this.DeleteButton.TabIndex = 101;
            this.DeleteButton.Text = "Delete Selected Account";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.RemoveLoginData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Email";
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailText.Location = new System.Drawing.Point(236, 157);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(154, 21);
            this.EmailText.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(236, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "Name";
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameText.Location = new System.Drawing.Point(236, 98);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(154, 21);
            this.NameText.TabIndex = 97;
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccountLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.CreateAccountLabel.Location = new System.Drawing.Point(46, 32);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(157, 23);
            this.CreateAccountLabel.TabIndex = 96;
            this.CreateAccountLabel.Text = "Create Account";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.Location = new System.Drawing.Point(46, 134);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(58, 16);
            this.QuantityLabel.TabIndex = 95;
            this.QuantityLabel.Text = "Password";
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordText.Location = new System.Drawing.Point(46, 157);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(154, 21);
            this.PasswordText.TabIndex = 94;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(46, 75);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(61, 16);
            this.TitleLabel.TabIndex = 93;
            this.TitleLabel.Text = "Username";
            // 
            // UsernameText
            // 
            this.UsernameText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameText.Location = new System.Drawing.Point(46, 98);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(154, 21);
            this.UsernameText.TabIndex = 92;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateBtn.Location = new System.Drawing.Point(46, 238);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(353, 35);
            this.CreateBtn.TabIndex = 91;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Admin.Location = new System.Drawing.Point(47, 200);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(65, 21);
            this.Admin.TabIndex = 111;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.Admin_CheckedChanged);
            // 
            // UserControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExistingAccountsGrid);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdateExistingAccountLabel);
            this.Controls.Add(this.SelectCategoryLabel);
            this.Controls.Add(this.KeywordsLabel);
            this.Controls.Add(this.KeywordsText);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.CreateAccountLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.CreateBtn);
            this.Name = "UserControlAdmin";
            this.Size = new System.Drawing.Size(839, 683);
            this.Load += new System.EventHandler(this.UserControlAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExistingAccountsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ExistingAccountsGrid;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label UpdateExistingAccountLabel;
        private System.Windows.Forms.Label SelectCategoryLabel;
        private System.Windows.Forms.Label KeywordsLabel;
        private System.Windows.Forms.TextBox KeywordsText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label CreateAccountLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.CheckBox Admin;
    }
}
