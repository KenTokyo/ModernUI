
namespace ModernFlatUI.usercontrolling
{
    partial class UserControlDashboard
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
            this.labelDashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Location = new System.Drawing.Point(328, 299);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(64, 15);
            this.labelDashboard.TabIndex = 2;
            this.labelDashboard.Text = "Dashboard";
            // 
            // DashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDashboard);
            this.Name = "DashboardUserControl";
            this.Size = new System.Drawing.Size(922, 748);
            this.Load += new System.EventHandler(this.DashboardUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDashboard;
    }
}
