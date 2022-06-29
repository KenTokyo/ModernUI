
namespace ModernFlatUI
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnArticles = new FontAwesome.Sharp.IconButton();
            this.btnOrders = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.userControlArticleMenu2 = new ModernFlatUI.usercontrolling.UserControlArticleMenu();
            this.userControlAdmin2 = new ModernFlatUI.UserControlAdmin();
            this.userControlSettings1 = new ModernFlatUI.usercontrolling.UserControlSettings();
            this.userControlOrder1 = new ModernFlatUI.usercontrolling.UserControlOrder();
            this.userControlDashboard1 = new ModernFlatUI.usercontrolling.UserControlDashboard();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnArticles);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 807);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnAdmin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 32;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 397);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnAdmin.Size = new System.Drawing.Size(251, 68);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 329);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnSettings.Size = new System.Drawing.Size(251, 68);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnArticles
            // 
            this.btnArticles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArticles.FlatAppearance.BorderSize = 0;
            this.btnArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticles.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArticles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArticles.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnArticles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnArticles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArticles.IconSize = 32;
            this.btnArticles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticles.Location = new System.Drawing.Point(0, 261);
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnArticles.Size = new System.Drawing.Size(251, 68);
            this.btnArticles.TabIndex = 3;
            this.btnArticles.Text = "Articles";
            this.btnArticles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArticles.UseVisualStyleBackColor = true;
            this.btnArticles.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrders.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrders.IconSize = 32;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 193);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnOrders.Size = new System.Drawing.Size(251, 68);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Order";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 125);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnDashboard.Size = new System.Drawing.Size(251, 68);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 125);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(14, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(217, 93);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "GameCenter";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(251, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(919, 74);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.DarkGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 17;
            this.btnClose.Location = new System.Drawing.Point(887, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 17;
            this.btnMaximize.Location = new System.Drawing.Point(858, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 32);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 17;
            this.btnMinimize.Location = new System.Drawing.Point(830, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(70, 25);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(156, 36);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            this.labelTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitleChildForm.Click += new System.EventHandler(this.labelTitleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 34;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 29);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(34, 34);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(251, 74);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(919, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.userControlArticleMenu2);
            this.panelDesktop.Controls.Add(this.userControlAdmin2);
            this.panelDesktop.Controls.Add(this.userControlSettings1);
            this.panelDesktop.Controls.Add(this.userControlOrder1);
            this.panelDesktop.Controls.Add(this.userControlDashboard1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(251, 83);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(919, 724);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // userControlArticleMenu2
            // 
            this.userControlArticleMenu2.BackColor = System.Drawing.SystemColors.Control;
            this.userControlArticleMenu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlArticleMenu2.Location = new System.Drawing.Point(0, 0);
            this.userControlArticleMenu2.Name = "userControlArticleMenu2";
            this.userControlArticleMenu2.Size = new System.Drawing.Size(919, 724);
            this.userControlArticleMenu2.TabIndex = 5;
            this.userControlArticleMenu2.Load += new System.EventHandler(this.userControlArticleMenu2_Load);
            // 
            // userControlAdmin2
            // 
            this.userControlAdmin2.BackColor = System.Drawing.SystemColors.Control;
            this.userControlAdmin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAdmin2.Location = new System.Drawing.Point(0, 0);
            this.userControlAdmin2.Name = "userControlAdmin2";
            this.userControlAdmin2.Size = new System.Drawing.Size(919, 724);
            this.userControlAdmin2.TabIndex = 4;
            // 
            // userControlSettings1
            // 
            this.userControlSettings1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSettings1.Location = new System.Drawing.Point(0, 0);
            this.userControlSettings1.Name = "userControlSettings1";
            this.userControlSettings1.Size = new System.Drawing.Size(919, 724);
            this.userControlSettings1.TabIndex = 3;
            this.userControlSettings1.Load += new System.EventHandler(this.userControlSettings1_Load);
            // 
            // userControlOrder1
            // 
            this.userControlOrder1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlOrder1.Location = new System.Drawing.Point(0, 0);
            this.userControlOrder1.Name = "userControlOrder1";
            this.userControlOrder1.Size = new System.Drawing.Size(919, 724);
            this.userControlOrder1.TabIndex = 2;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(919, 724);
            this.userControlDashboard1.TabIndex = 1;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 807);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnArticles;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnOrders;
        private UserControlAdmin userControlAdmin1;
        private usercontrolling.UserControlOrder userControlOrder1;
        private usercontrolling.UserControlDashboard userControlDashboard1;
        private usercontrolling.UserControlSettings userControlSettings1;
        private usercontrolling.UserControlArticleMenu userControlArticleMenu2;
        private UserControlAdmin userControlAdmin2;
    }
}

