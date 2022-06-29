
namespace ModernFlatUI.usercontrolling
{
    partial class UserControllError
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
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorMessage.Location = new System.Drawing.Point(3, 56);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(454, 20);
            this.ErrorMessage.TabIndex = 5;
            this.ErrorMessage.Text = "Fehler asdadasd asdadadsad";
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorMessage.Click += new System.EventHandler(this.ErrorMessage_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(181, 114);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(97, 39);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ErrorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.CloseButton);
            this.Name = "ErrorUserControl";
            this.Size = new System.Drawing.Size(474, 219);
            this.Load += new System.EventHandler(this.ErrorUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Button CloseButton;
    }
}
