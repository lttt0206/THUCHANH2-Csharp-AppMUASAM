using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;

namespace MUASAM
{
    public partial class Home : KryptonForm
    {
        private IconButton currentBtn;
        private Form currentChildForm;
        private Panel leftBorderBtn;

        public Home()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
                currentBtn.Padding= new Padding(0);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(35, 40, 52);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.Padding = new Padding(18,0,0,0);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {            
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void iconButton_mini_MouseHover(object sender, EventArgs e)
        {
            iconButton_mini.BackColor = Color.FromArgb(189, 23, 70);
        }

        private void iconButton_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton_Close_MouseHover(object sender, EventArgs e)
        {
            iconButton_Close.BackColor = Color.FromArgb(189, 23, 70);
        }

        private void iconButton_mini_MouseLeave(object sender, EventArgs e)
        {
            iconButton_mini.BackColor = Color.FromArgb(35, 40, 52);
        }

        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn đóng cửa sổ không?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }

        private void iconButton_Close_MouseLeave(object sender, EventArgs e)
        {
            iconButton_Close.BackColor = Color.FromArgb(35, 40, 52);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btgiadung_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new GiadungDS());
        }

        private void bt_dientu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Dientu());
        }

        private void bt_thoitrangnam_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Thoitrangnam());
        }

        private void bt_thoitrangnu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Thoitrangnu());
        }

        private void bt_mypham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Mypham());
        }

        private void bt_nhasach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Nhasach());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Invalidate();
        }

        private void text_search_Enter(object sender, EventArgs e)
        {
            text_search.Text = "";
        }

        private void bt_barcode_Click(object sender, EventArgs e)
        {
            bt_barcode.BackColor = Color.FromArgb(24, 161, 251);
            OpenChildForm(new Barcode());
        }

        private void bt_GioHang_Click(object sender, EventArgs e)
        {
            bt_GioHang.BackColor = Color.FromArgb(24, 161, 251);
            OpenChildForm(new GiohangUI());
        }

        private void bt_GioHang_Leave(object sender, EventArgs e)
        {
            bt_GioHang.BackColor = Color.FromArgb(35, 40, 52);
        }

        private void bt_barcode_Leave(object sender, EventArgs e)
        {
            bt_barcode.BackColor = Color.FromArgb(35, 40, 52);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(24, 161, 251);
            OpenChildForm(new Account());
        }

        private void iconButton1_Leave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(35, 40, 52);
        }
    }
}
