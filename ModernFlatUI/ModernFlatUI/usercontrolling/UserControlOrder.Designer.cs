
namespace ModernFlatUI.usercontrolling
{
    partial class UserControlOrder
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
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.AddStockButton = new System.Windows.Forms.Button();
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.labelOrderList = new System.Windows.Forms.Label();
            this.SortingLabel = new System.Windows.Forms.Label();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.ascendingButton = new FontAwesome.Sharp.IconButton();
            this.descendingButton = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.Location = new System.Drawing.Point(696, 141);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(55, 16);
            this.QuantityLabel.TabIndex = 107;
            this.QuantityLabel.Text = "Quantity";
            // 
            // QuantityText
            // 
            this.QuantityText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityText.Location = new System.Drawing.Point(696, 164);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(130, 21);
            this.QuantityText.TabIndex = 106;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(696, 84);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 16);
            this.TitleLabel.TabIndex = 103;
            this.TitleLabel.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(696, 107);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(130, 21);
            this.textBoxTitle.TabIndex = 101;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddStockButton
            // 
            this.AddStockButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStockButton.Location = new System.Drawing.Point(696, 210);
            this.AddStockButton.Name = "AddStockButton";
            this.AddStockButton.Size = new System.Drawing.Size(130, 35);
            this.AddStockButton.TabIndex = 100;
            this.AddStockButton.Text = "Add To Sellout";
            this.AddStockButton.UseVisualStyleBackColor = true;
            this.AddStockButton.Click += new System.EventHandler(this.AddArticleToSellout);
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshListButton.Location = new System.Drawing.Point(40, 464);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(264, 73);
            this.RefreshListButton.TabIndex = 99;
            this.RefreshListButton.Text = "Clear Sale";
            this.RefreshListButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(696, 273);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 41);
            this.DeleteButton.TabIndex = 98;
            this.DeleteButton.Text = "Delete Item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateItemButton.Location = new System.Drawing.Point(696, 339);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(130, 41);
            this.UpdateItemButton.TabIndex = 97;
            this.UpdateItemButton.Text = "Update Item";
            this.UpdateItemButton.UseVisualStyleBackColor = true;
            // 
            // labelOrderList
            // 
            this.labelOrderList.AutoSize = true;
            this.labelOrderList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderList.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelOrderList.Location = new System.Drawing.Point(40, 40);
            this.labelOrderList.Name = "labelOrderList";
            this.labelOrderList.Size = new System.Drawing.Size(106, 25);
            this.labelOrderList.TabIndex = 96;
            this.labelOrderList.Text = "Order List";
            // 
            // SortingLabel
            // 
            this.SortingLabel.AutoSize = true;
            this.SortingLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortingLabel.Location = new System.Drawing.Point(40, 78);
            this.SortingLabel.Name = "SortingLabel";
            this.SortingLabel.Size = new System.Drawing.Size(47, 16);
            this.SortingLabel.TabIndex = 105;
            this.SortingLabel.Text = "Sort by:";
            // 
            // SortComboBox
            // 
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Id",
            "Title",
            "Qty",
            "Price"});
            this.SortComboBox.Location = new System.Drawing.Point(40, 102);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(121, 23);
            this.SortComboBox.TabIndex = 109;
            // 
            // ascendingButton
            // 
            this.ascendingButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ascendingButton.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.ascendingButton.IconColor = System.Drawing.Color.DimGray;
            this.ascendingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ascendingButton.IconSize = 32;
            this.ascendingButton.Location = new System.Drawing.Point(184, 89);
            this.ascendingButton.Name = "ascendingButton";
            this.ascendingButton.Size = new System.Drawing.Size(37, 39);
            this.ascendingButton.TabIndex = 111;
            this.ascendingButton.UseVisualStyleBackColor = true;
            // 
            // descendingButton
            // 
            this.descendingButton.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.descendingButton.IconColor = System.Drawing.Color.DimGray;
            this.descendingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.descendingButton.IconSize = 32;
            this.descendingButton.Location = new System.Drawing.Point(227, 89);
            this.descendingButton.Name = "descendingButton";
            this.descendingButton.Size = new System.Drawing.Size(37, 39);
            this.descendingButton.TabIndex = 112;
            this.descendingButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(339, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 73);
            this.button1.TabIndex = 99;
            this.button1.Text = "Commit Sale";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 15;
            this.listBoxOrder.Location = new System.Drawing.Point(40, 153);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(264, 229);
            this.listBoxOrder.TabIndex = 113;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(311, 229);
            this.dataGridView1.TabIndex = 114;
            // 
            // UserControlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.descendingButton);
            this.Controls.Add(this.ascendingButton);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityText);
            this.Controls.Add(this.SortingLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.AddStockButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateItemButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RefreshListButton);
            this.Controls.Add(this.labelOrderList);
            this.Name = "UserControlOrder";
            this.Size = new System.Drawing.Size(1218, 786);
            this.Load += new System.EventHandler(this.OrderUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button AddStockButton;
        private System.Windows.Forms.Button RefreshListButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.Label labelOrderList;
        private System.Windows.Forms.Label SortingLabel;
        private System.Windows.Forms.ComboBox SortComboBox;
        private FontAwesome.Sharp.IconButton ascendingButton;
        private FontAwesome.Sharp.IconButton descendingButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
