using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModernFlatUI.usercontrolling
{
    public partial class UserControllError : UserControl
    {
        public UserControllError()
        {
            InitializeComponent();
        }

        private void ErrorUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ErrorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
