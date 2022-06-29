
namespace ModernFlatUI.usercontrolling
{
    partial class FormError
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(147, 154);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(97, 39);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorMessage.Location = new System.Drawing.Point(-1, 43);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(395, 97);
            this.ErrorMessage.TabIndex = 3;
            this.ErrorMessage.Text = "Fehler asdadasd asdadadsad";
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorMessage.Click += new System.EventHandler(this.ErrorMessage_Click);
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 218);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Window";
            this.Load += new System.EventHandler(this.FormError_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ErrorMessage;
    }
}