using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModernFlatUI.usercontrolling
{
    public partial class FormError : Form
    {
        public FormError(string p_errorText)
        {
            InitializeComponent();
            SetErrorText(p_errorText);
        }

        private void FormError_Load(object sender, EventArgs e)
        {

        }

        private void SetErrorText(string p_errorText)
        {
            ErrorMessage.Text = p_errorText;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void ErrorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
