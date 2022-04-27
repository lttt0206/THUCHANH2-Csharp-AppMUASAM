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
    public partial class Timkiem : KryptonForm
    {
        string strNhan;
        public Timkiem()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
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
            label_head.Text = "TÌM KIẾM '" + strNhan + "'";
            Xuly_Data s = new Xuly_Data();
            string danhmuc = strNhan;
            List<Sanpham> list = s.timkiemSanpham(danhmuc);
            panel3.Size = new Size(960, 564);
            XemthemTimkiem ct = new XemthemTimkiem();
            int i = 1;
            ct.Message = strNhan + "-" + i;
            i += 8;
            ct.TopLevel = false;
            ct.FormBorderStyle = FormBorderStyle.None;
            ct.Dock = DockStyle.Fill;
            panel3.Controls.Add(ct);
            ct.BringToFront();
            ct.Show();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            panel16.Hide();
            int tmp = 573;
            int tmp2 = 8;
            if (list.Count > tmp2)
            {
                panel4.Show();
                panel4.Size = new Size(960, 564);
                panel4.Location = new Point(12, tmp);
                tmp += 570;
                tmp2 += 8;
                XemthemTimkiem ct3 = new XemthemTimkiem();
                ct3.Message = strNhan + "-" + i;
                i += 8;
                ct3.TopLevel = false;
                ct3.FormBorderStyle = FormBorderStyle.None;
                ct3.Dock = DockStyle.Fill;
                panel4.Controls.Add(ct3);
                ct3.BringToFront();
                ct3.Show();
                if (list.Count > tmp2)
                {
                    panel5.Show();
                    panel5.Size = new Size(960, 564);
                    panel5.Location = new Point(12, tmp);
                    tmp += 570;
                    tmp2 += 8;
                    XemthemTimkiem ct4 = new XemthemTimkiem();
                    ct4.Message = strNhan + "-" + i;
                    i += 8;
                    ct4.TopLevel = false;
                    ct4.FormBorderStyle = FormBorderStyle.None;
                    ct4.Dock = DockStyle.Fill;
                    panel5.Controls.Add(ct4);
                    ct4.BringToFront();
                    ct4.Show();
                    if (list.Count > tmp2)
                    {
                        panel6.Show();
                        panel6.Size = new Size(960, 564);
                        panel6.Location = new Point(12, tmp);
                        tmp += 570;
                        tmp2 += 8;
                        XemthemTimkiem ct5 = new XemthemTimkiem();
                        ct5.Message = strNhan + "-" + i;
                        i += 8;
                        ct5.TopLevel = false;
                        ct5.FormBorderStyle = FormBorderStyle.None;
                        ct5.Dock = DockStyle.Fill;
                        panel6.Controls.Add(ct5);
                        ct5.BringToFront();
                        ct5.Show();
                        if (list.Count > tmp2)
                        {
                            panel7.Show();
                            panel7.Size = new Size(960, 564);
                            panel7.Location = new Point(12, tmp);
                            tmp += 570;
                            tmp2 += 8;
                            XemthemTimkiem ct6 = new XemthemTimkiem();
                            ct6.Message = strNhan + "-" + i;
                            i += 8;
                            ct6.TopLevel = false;
                            ct6.FormBorderStyle = FormBorderStyle.None;
                            ct6.Dock = DockStyle.Fill;
                            panel7.Controls.Add(ct6);
                            ct6.BringToFront();
                            ct6.Show();
                            if (list.Count > tmp2)
                            {
                                panel8.Show();
                                panel8.Size = new Size(960, 564);
                                panel8.Location = new Point(12, tmp);
                                tmp += 570;
                                tmp2 += 8;
                                XemthemTimkiem ct7 = new XemthemTimkiem();
                                ct7.Message = strNhan + "-" + i;
                                i += 8;
                                ct7.TopLevel = false;
                                ct7.FormBorderStyle = FormBorderStyle.None;
                                ct7.Dock = DockStyle.Fill;
                                panel8.Controls.Add(ct7);
                                ct7.BringToFront();
                                ct7.Show();
                                if (list.Count > tmp2)
                                {
                                    panel9.Show();
                                    panel9.Size = new Size(960, 564);
                                    panel9.Location = new Point(12, tmp);
                                    tmp += 570;
                                    tmp2 += 8;
                                    XemthemTimkiem ct8 = new XemthemTimkiem();
                                    ct8.Message = strNhan + "-" + i;
                                    i += 8;
                                    ct8.TopLevel = false;
                                    ct8.FormBorderStyle = FormBorderStyle.None;
                                    ct8.Dock = DockStyle.Fill;
                                    panel9.Controls.Add(ct8);
                                    ct8.BringToFront();
                                    ct8.Show();
                                    if (list.Count > tmp2)
                                    {
                                        panel10.Show();
                                        panel10.Size = new Size(960, 564);
                                        panel10.Location = new Point(12, tmp);
                                        tmp += 570;
                                        tmp2 += 8;
                                        XemthemTimkiem ct9 = new XemthemTimkiem();
                                        ct9.Message = strNhan + "-" + i;
                                        i += 8;
                                        ct9.TopLevel = false;
                                        ct9.FormBorderStyle = FormBorderStyle.None;
                                        ct9.Dock = DockStyle.Fill;
                                        panel10.Controls.Add(ct9);
                                        ct9.BringToFront();
                                        ct9.Show();
                                        if (list.Count > tmp2)
                                        {
                                            panel11.Show();
                                            panel11.Size = new Size(960, 564);
                                            panel11.Location = new Point(12, tmp);
                                            tmp += 570;
                                            tmp2 += 8;
                                            XemthemTimkiem ct10 = new XemthemTimkiem();
                                            ct10.Message = strNhan + "-" + i;
                                            i += 8;
                                            ct10.TopLevel = false;
                                            ct10.FormBorderStyle = FormBorderStyle.None;
                                            ct10.Dock = DockStyle.Fill;
                                            panel11.Controls.Add(ct10);
                                            ct10.BringToFront();
                                            ct10.Show();
                                            if (list.Count > tmp2)
                                            {
                                                panel12.Show();
                                                panel12.Size = new Size(960, 564);
                                                panel12.Location = new Point(12, tmp);
                                                tmp += 570;
                                                tmp2 += 8;
                                                XemthemTimkiem ct11 = new XemthemTimkiem();
                                                ct11.Message = strNhan + "-" + i;
                                                i += 8;
                                                ct11.TopLevel = false;
                                                ct11.FormBorderStyle = FormBorderStyle.None;
                                                ct11.Dock = DockStyle.Fill;
                                                panel12.Controls.Add(ct11);
                                                ct11.BringToFront();
                                                ct11.Show();
                                                if (list.Count > tmp2)
                                                {
                                                    panel13.Show();
                                                    panel13.Size = new Size(960, 564);
                                                    panel13.Location = new Point(12, tmp);
                                                    tmp += 570;
                                                    tmp2 += 8;
                                                    XemthemTimkiem ct12 = new XemthemTimkiem();
                                                    ct12.Message = strNhan + "-" + i;
                                                    i += 8;
                                                    ct12.TopLevel = false;
                                                    ct12.FormBorderStyle = FormBorderStyle.None;
                                                    ct12.Dock = DockStyle.Fill;
                                                    panel13.Controls.Add(ct12);
                                                    ct12.BringToFront();
                                                    ct12.Show();
                                                    if (list.Count > tmp2)
                                                    {
                                                        panel14.Show();
                                                        panel14.Size = new Size(960, 564);
                                                        panel14.Location = new Point(12, tmp);
                                                        tmp += 570;
                                                        tmp2 += 8;
                                                        XemthemTimkiem ct13 = new XemthemTimkiem();
                                                        ct13.Message = strNhan + "-" + i;
                                                        i += 8;
                                                        ct13.TopLevel = false;
                                                        ct13.FormBorderStyle = FormBorderStyle.None;
                                                        ct13.Dock = DockStyle.Fill;
                                                        panel14.Controls.Add(ct13);
                                                        ct13.BringToFront();
                                                        ct13.Show();
                                                        if (list.Count > tmp2)
                                                        {
                                                            panel15.Show();
                                                            panel15.Size = new Size(960, 564);
                                                            panel15.Location = new Point(12, tmp);
                                                            tmp += 570;
                                                            tmp2 += 8;
                                                            XemthemTimkiem ct14 = new XemthemTimkiem();
                                                            ct14.Message = strNhan + "-" + i;
                                                            i += 8;
                                                            ct14.TopLevel = false;
                                                            ct14.FormBorderStyle = FormBorderStyle.None;
                                                            ct14.Dock = DockStyle.Fill;
                                                            panel15.Controls.Add(ct14);
                                                            ct14.BringToFront();
                                                            ct14.Show();
                                                            if (list.Count > tmp2)
                                                            {
                                                                panel16.Show();
                                                                panel16.Size = new Size(960, 564);
                                                                panel16.Location = new Point(12, tmp);
                                                                tmp += 570;
                                                                tmp2 += 8;
                                                                XemthemTimkiem ct15 = new XemthemTimkiem();
                                                                ct15.Message = strNhan + "-" + i;
                                                                i += 8;
                                                                ct15.TopLevel = false;
                                                                ct15.FormBorderStyle = FormBorderStyle.None;
                                                                ct15.Dock = DockStyle.Fill;
                                                                panel16.Controls.Add(ct15);
                                                                ct15.BringToFront();
                                                                ct15.Show();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

       
    }
}
