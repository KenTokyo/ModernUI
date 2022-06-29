
namespace ModernFlatUI.usercontrolling
{
    partial class UserControlSettings
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
            this.labelSettings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Location = new System.Drawing.Point(325, 303);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(49, 15);
            this.labelSettings.TabIndex = 2;
            this.labelSettings.Text = "Settings";
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSettings);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(624, 546);
            this.Load += new System.EventHandler(this.SettingsUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSettings;
    }
}
