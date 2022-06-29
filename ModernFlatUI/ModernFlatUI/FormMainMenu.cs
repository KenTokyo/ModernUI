using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using ModernFlatUI.database;
using ModernFlatUI.usercontrolling;
using Color = System.Drawing.Color;

namespace ModernFlatUI
{
    public partial class FormMainMenu : Form
    {

        //Fields

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private UserControl currentUserControl;
        public static DBStorageAccess m_dbStorageAccess;
        public static DBLoginAccess m_dbLoginAccess;
        private bool m_isAdmin;
        public FormMainMenu(DBStorageAccess p_dbStorageAccess, DBLoginAccess p_dbLoginAccess, bool p_isAdmin)
        {
            m_dbStorageAccess = p_dbStorageAccess;
            m_dbLoginAccess = p_dbLoginAccess;
            m_isAdmin = p_isAdmin;
            InitializeComponent();
            HideAllUserControls();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);

            panelMenu.Controls.Add(leftBorderBtn);
            if (!p_isAdmin)
            {
                btnAdmin.Visible = false;
            }


            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void HideAllUserControls()
        {
            userControlDashboard1.Hide();
            userControlAdmin2.Hide();
            userControlOrder1.Hide();
            userControlSettings1.Hide();
            userControlArticleMenu2.Hide();
        }


        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


                //left border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }


        private void ShowUserControl(UserControl userControl, string labelTitleUserControl)
        {
            if (currentUserControl != null)
            {  // open only form
                currentUserControl.Hide();
            }
            currentUserControl = userControl;


            userControl.Show();
            userControl.BringToFront();
            labelTitleChildForm.Text = labelTitleUserControl;

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ShowUserControl(userControlDashboard1, "Dashboard");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ShowUserControl(userControlOrder1, "Order");
            userControlOrder1.LoadConnection();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            ShowUserControl(userControlArticleMenu2, "ArticleMenu");
            userControlArticleMenu2.LoadStockList();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            ShowUserControl(userControlAdmin2, "Admin");
            userControlAdmin2.LoadAccountList();
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            ShowUserControl(userControlSettings1, "Settings");
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentUserControl != null)
            {
                currentUserControl.Hide();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTitleChildForm.Text = "Home";
        }

        private void labelTitleChildForm_Click(object sender, EventArgs e)
        {

        }


        //DRAG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void settingsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void userControlAdmin1_Load(object sender, EventArgs e)
        {

        }

        private void userControlArticles1_Load(object sender, EventArgs e)
        {

        }

        private void userControlSettings1_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlArticleStorage1_Load(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlArticleMenu2_Load(object sender, EventArgs e)
        {

        }
    }
}
