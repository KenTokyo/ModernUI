using ModernFlatUI.usercontrolling;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ModernFlatUI.UserControls
{
    public class Utils
    {


        public static void ShowErrorForm(String errorMsg)
        {
            FormError errorForm = new FormError(errorMsg);
            errorForm.Dock = DockStyle.Fill;
            errorForm.Show();
        }

    }
}
