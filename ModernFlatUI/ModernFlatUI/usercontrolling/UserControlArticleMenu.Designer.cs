
namespace ModernFlatUI.usercontrolling
{
    partial class UserControlArticleMenu
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
            this.KeywordsLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.WhereToSearchLable = new System.Windows.Forms.Label();
            this.descendingButton = new FontAwesome.Sharp.IconButton();
            this.ascendingButton = new FontAwesome.Sharp.IconButton();
            this.SelectWhereBox = new System.Windows.Forms.ComboBox();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.stockListGrid = new System.Windows.Forms.DataGridView();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.SortingLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.AddStockButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.labelStockList = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // KeywordsLabel
            // 
            this.KeywordsLabel.AutoSize = true;
            this.KeywordsLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeywordsLabel.Location = new System.Drawing.Point(476, 336);
            this.KeywordsLabel.Name = "KeywordsLabel";
            this.KeywordsLabel.Size = new System.Drawing.Size(62, 16);
            this.KeywordsLabel.TabIndex = 95;
            this.KeywordsLabel.Text = "Keywords:";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(476, 408);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(151, 41);
            this.SearchButton.TabIndex = 94;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.Location = new System.Drawing.Point(477, 359);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(154, 21);
            this.SearchTextBox.TabIndex = 93;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchButton_Click);
            // 
            // WhereToSearchLable
            // 
            this.WhereToSearchLable.AutoSize = true;
            this.WhereToSearchLable.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WhereToSearchLable.Location = new System.Drawing.Point(475, 273);
            this.WhereToSearchLable.Name = "WhereToSearchLable";
            this.WhereToSearchLable.Size = new System.Drawing.Size(61, 16);
            this.WhereToSearchLable.TabIndex = 92;
            this.WhereToSearchLable.Text = "Category:";
            // 
            // descendingButton
            // 
            this.descendingButton.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.descendingButton.IconColor = System.Drawing.Color.DimGray;
            this.descendingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descendingButton.IconSize = 32;
            this.descendingButton.Location = new System.Drawing.Point(245, 96);
            this.descendingButton.Name = "descendingButton";
            this.descendingButton.Size = new System.Drawing.Size(37, 39);
            this.descendingButton.TabIndex = 91;
            this.descendingButton.UseVisualStyleBackColor = true;
            this.descendingButton.Click += new System.EventHandler(this.descendingButton_Click);
            // 
            // ascendingButton
            // 
            this.ascendingButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ascendingButton.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.ascendingButton.IconColor = System.Drawing.Color.DimGray;
            this.ascendingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ascendingButton.IconSize = 32;
            this.ascendingButton.Location = new System.Drawing.Point(202, 96);
            this.ascendingButton.Name = "ascendingButton";
            this.ascendingButton.Size = new System.Drawing.Size(37, 39);
            this.ascendingButton.TabIndex = 90;
            this.ascendingButton.UseVisualStyleBackColor = true;
            this.ascendingButton.Click += new System.EventHandler(this.ascendingButton_Click);
            // 
            // SelectWhereBox
            // 
            this.SelectWhereBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectWhereBox.FormattingEnabled = true;
            this.SelectWhereBox.Items.AddRange(new object[] {
            "Id",
            "Title",
            "Qty",
            "Price"});
            this.SelectWhereBox.Location = new System.Drawing.Point(477, 302);
            this.SelectWhereBox.Name = "SelectWhereBox";
            this.SelectWhereBox.Size = new System.Drawing.Size(121, 24);
            this.SelectWhereBox.TabIndex = 89;
            this.SelectWhereBox.SelectedIndexChanged += new System.EventHandler(this.SelectWhereBox_SelectedIndexChanged);
            // 
            // SortComboBox
            // 
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Id",
            "Title",
            "Qty",
            "Price"});
            this.SortComboBox.Location = new System.Drawing.Point(58, 109);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(121, 23);
            this.SortComboBox.TabIndex = 88;
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortingComboBox_SelectedIndexChanged);
            // 
            // stockListGrid
            // 
            this.stockListGrid.AllowUserToOrderColumns = true;
            this.stockListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockListGrid.Location = new System.Drawing.Point(58, 155);
            this.stockListGrid.Name = "stockListGrid";
            this.stockListGrid.RowTemplate.Height = 25;
            this.stockListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockListGrid.Size = new System.Drawing.Size(355, 207);
            this.stockListGrid.TabIndex = 87;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.Location = new System.Drawing.Point(475, 134);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(55, 16);
            this.QuantityLabel.TabIndex = 86;
            this.QuantityLabel.Text = "Quantity";
            // 
            // QuantityText
            // 
            this.QuantityText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityText.Location = new System.Drawing.Point(475, 157);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(135, 21);
            this.QuantityText.TabIndex = 85;
            // 
            // SortingLabel
            // 
            this.SortingLabel.AutoSize = true;
            this.SortingLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortingLabel.Location = new System.Drawing.Point(58, 85);
            this.SortingLabel.Name = "SortingLabel";
            this.SortingLabel.Size = new System.Drawing.Size(47, 16);
            this.SortingLabel.TabIndex = 84;
            this.SortingLabel.Text = "Sort by:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(475, 75);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 16);
            this.TitleLabel.TabIndex = 83;
            this.TitleLabel.Text = "Title";
            // 
            // TitleText
            // 
            this.TitleText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleText.Location = new System.Drawing.Point(475, 98);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(135, 21);
            this.TitleText.TabIndex = 82;
            // 
            // AddStockButton
            // 
            this.AddStockButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStockButton.Location = new System.Drawing.Point(475, 201);
            this.AddStockButton.Name = "AddStockButton";
            this.AddStockButton.Size = new System.Drawing.Size(151, 35);
            this.AddStockButton.TabIndex = 81;
            this.AddStockButton.Text = "Add Stock";
            this.AddStockButton.UseVisualStyleBackColor = true;
            this.AddStockButton.Click += new System.EventHandler(this.AddStockButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(262, 388);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(151, 41);
            this.DeleteButton.TabIndex = 79;
            this.DeleteButton.Text = "Delete Item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.RemoveStock_Click);
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateItemButton.Location = new System.Drawing.Point(58, 388);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(151, 41);
            this.UpdateItemButton.TabIndex = 78;
            this.UpdateItemButton.Text = "Update Item";
            this.UpdateItemButton.UseVisualStyleBackColor = true;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateStockButton_Click);
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshListButton.Location = new System.Drawing.Point(58, 468);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(151, 41);
            this.RefreshListButton.TabIndex = 80;
            this.RefreshListButton.Text = "Refresh List";
            this.RefreshListButton.UseVisualStyleBackColor = true;
            this.RefreshListButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // labelStockList
            // 
            this.labelStockList.AutoSize = true;
            this.labelStockList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStockList.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelStockList.Location = new System.Drawing.Point(58, 47);
            this.labelStockList.Name = "labelStockList";
            this.labelStockList.Size = new System.Drawing.Size(112, 25);
            this.labelStockList.TabIndex = 77;
            this.labelStockList.Text = "Article List";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(630, 98);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(135, 21);
            this.textBoxPrice.TabIndex = 82;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(630, 75);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 16);
            this.labelPrice.TabIndex = 83;
            this.labelPrice.Text = "Price";
            // 
            // UserControlArticleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KeywordsLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.WhereToSearchLable);
            this.Controls.Add(this.descendingButton);
            this.Controls.Add(this.ascendingButton);
            this.Controls.Add(this.SelectWhereBox);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.stockListGrid);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityText);
            this.Controls.Add(this.SortingLabel);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.AddStockButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateItemButton);
            this.Controls.Add(this.RefreshListButton);
            this.Controls.Add(this.labelStockList);
            this.Name = "UserControlArticleMenu";
            this.Size = new System.Drawing.Size(806, 607);
            this.Load += new System.EventHandler(this.UserControlArticleMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeywordsLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label WhereToSearchLable;
        private FontAwesome.Sharp.IconButton descendingButton;
        private FontAwesome.Sharp.IconButton ascendingButton;
        private System.Windows.Forms.ComboBox SelectWhereBox;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.DataGridView stockListGrid;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Label SortingLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Button AddStockButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.Button RefreshListButton;
        private System.Windows.Forms.Label labelStockList;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
    }
}
