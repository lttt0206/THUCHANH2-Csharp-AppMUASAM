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
    public partial class Dathang : KryptonForm
    {
        string strNhan;
        public Dathang()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Xuly_Data s = new Xuly_Data();
            List<Giohang> list = s.sqlGetGiohang();
            panel4.Size = new Size(434, 404);
            SPHoadon ct = new SPHoadon();
            int i = 1;
            ct.Message = i.ToString();
            i += 4;
            ct.TopLevel = false;
            ct.FormBorderStyle = FormBorderStyle.None;
            ct.Dock = DockStyle.Fill;
            panel4.Controls.Add(ct);
            ct.BringToFront();
            ct.Show();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            int tmp = 106;
            if (list.Count > i)
            {
                panel5.Show();
                panel5.Size = new Size(434, 404);
                panel5.Location = new Point(3, tmp);
                tmp += 410;
                SPHoadon ct2 = new SPHoadon();
                ct2.Message = i.ToString();
                ct2.TopLevel = false;
                ct2.FormBorderStyle = FormBorderStyle.None;
                ct2.Dock = DockStyle.Fill;
                panel5.Controls.Add(ct2);
                ct2.BringToFront();
                ct2.Show();
                i += 4;
                if (list.Count > i)
                {
                    panel6.Show();
                    panel6.Size = new Size(434, 404);
                    panel6.Location = new Point(3, tmp);
                    tmp += 410;
                    SPHoadon ct3 = new SPHoadon();
                    ct3.Message = i.ToString();
                    ct3.TopLevel = false;
                    ct3.FormBorderStyle = FormBorderStyle.None;
                    ct3.Dock = DockStyle.Fill;
                    panel6.Controls.Add(ct3);
                    ct3.BringToFront();
                    ct3.Show();
                    i += 4;
                    if (list.Count > i)
                    {
                        panel7.Show();
                        panel7.Size = new Size(434, 404);
                        panel7.Location = new Point(3, tmp);
                        tmp += 410;
                        SPHoadon ct4 = new SPHoadon();
                        ct4.Message = i.ToString();
                        ct4.TopLevel = false;
                        ct4.FormBorderStyle = FormBorderStyle.None;
                        ct4.Dock = DockStyle.Fill;
                        panel7.Controls.Add(ct4);
                        ct4.BringToFront();
                        ct4.Show();
                        i += 4;
                        if (list.Count > i)
                        {
                            panel8.Show();
                            panel8.Size = new Size(434, 404);
                            panel8.Location = new Point(3, tmp);
                            tmp += 410;
                            SPHoadon ct5 = new SPHoadon();
                            ct5.Message = i.ToString();
                            ct5.TopLevel = false;
                            ct5.FormBorderStyle = FormBorderStyle.None;
                            ct5.Dock = DockStyle.Fill;
                            panel8.Controls.Add(ct5);
                            ct5.BringToFront();
                            ct5.Show();
                            i += 4;                            
                        }
                    }
                }

            }
        }
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
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
            this.Close();
        }

        private void iconButton_Close_MouseLeave(object sender, EventArgs e)
        {
            iconButton_Close.BackColor = Color.FromArgb(35, 40, 52);
        }

        private void CTSanPham_Load(object sender, EventArgs e)
        {
            label6.Text = Convert.ToInt32(strNhan).ToString("#,##0") + " VNĐ";
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
