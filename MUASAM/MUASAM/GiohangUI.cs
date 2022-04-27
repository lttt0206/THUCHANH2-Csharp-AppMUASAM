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
    public partial class GiohangUI : KryptonForm
    {
        public GiohangUI()
        {
            InitializeComponent();
            Xuly_Data s = new Xuly_Data();
            List<Giohang> list = s.sqlGetGiohang();
            panel3.Size = new Size(758, 460);
            SPgiohang ct = new SPgiohang();
            int i = 1;
            ct.Message = i.ToString();
            i += 3;
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
            int tmp = 466;
            if (list.Count >= i)
            {
                panel4.Show();
                panel4.Size = new Size(758, 460);
                panel4.Location = new Point(3, tmp);
                tmp += 466;
                SPgiohang ct2 = new SPgiohang();
                ct2.Message = i.ToString();
                ct2.TopLevel = false;
                ct2.FormBorderStyle = FormBorderStyle.None;
                ct2.Dock = DockStyle.Fill;
                panel4.Controls.Add(ct2);
                ct2.BringToFront();
                ct2.Show();
                i += 3;
                if (list.Count >= i)
                {
                    panel5.Show();
                    panel5.Size = new Size(758, 460);
                    panel5.Location = new Point(3, tmp);
                    tmp += 466;
                    SPgiohang ct3 = new SPgiohang();
                    ct3.Message = i.ToString();
                    ct3.TopLevel = false;
                    ct3.FormBorderStyle = FormBorderStyle.None;
                    ct3.Dock = DockStyle.Fill;
                    panel5.Controls.Add(ct3);
                    ct3.BringToFront();
                    ct3.Show(); 
                    i += 3;
                    if (list.Count >= i)
                    {
                        panel6.Show();
                        panel6.Size = new Size(758, 460);
                        panel6.Location = new Point(3, tmp);
                        tmp += 466;
                        SPgiohang ct4 = new SPgiohang();
                        ct4.Message = i.ToString();
                        ct4.TopLevel = false;
                        ct4.FormBorderStyle = FormBorderStyle.None;
                        ct4.Dock = DockStyle.Fill;
                        panel6.Controls.Add(ct4);
                        ct4.BringToFront();
                        ct4.Show();
                        i += 3;
                        if (list.Count >= i)
                        {
                            panel7.Show();
                            panel7.Size = new Size(758, 460);
                            panel7.Location = new Point(3, tmp);
                            tmp += 466;
                            SPgiohang ct5 = new SPgiohang();
                            ct5.Message = i.ToString();
                            ct5.TopLevel = false;
                            ct5.FormBorderStyle = FormBorderStyle.None;
                            ct5.Dock = DockStyle.Fill;
                            panel7.Controls.Add(ct5);
                            ct5.BringToFront();
                            ct5.Show();
                            i += 3;
                            if (list.Count >= i)
                            {
                                panel8.Show();
                                panel8.Size = new Size(758, 460);
                                panel8.Location = new Point(3, tmp);
                                tmp += 466;
                                SPgiohang ct6 = new SPgiohang();
                                ct6.Message = i.ToString();
                                ct6.TopLevel = false;
                                ct6.FormBorderStyle = FormBorderStyle.None;
                                ct6.Dock = DockStyle.Fill;
                                panel8.Controls.Add(ct3);
                                ct6.BringToFront();
                                ct6.Show();
                                i += 3;
                                if (list.Count >= i)
                                {
                                    panel9.Show();
                                    panel9.Size = new Size(758, 460);
                                    panel9.Location = new Point(3, tmp);
                                    tmp += 466;
                                    SPgiohang ct7 = new SPgiohang();
                                    ct7.Message = i.ToString();
                                    ct7.TopLevel = false;
                                    ct7.FormBorderStyle = FormBorderStyle.None;
                                    ct7.Dock = DockStyle.Fill;
                                    panel9.Controls.Add(ct7);
                                    ct7.BringToFront();
                                    ct7.Show();
                                    i += 3;
                                    if (list.Count >= i)
                                    {
                                        panel10.Show();
                                        panel10.Size = new Size(758, 460);
                                        panel10.Location = new Point(3, tmp);
                                        tmp += 466;
                                        SPgiohang ct8 = new SPgiohang();
                                        ct8.Message = i.ToString();
                                        ct8.TopLevel = false;
                                        ct8.FormBorderStyle = FormBorderStyle.None;
                                        ct8.Dock = DockStyle.Fill;
                                        panel10.Controls.Add(ct8);
                                        ct8.BringToFront();
                                        ct8.Show();
                                        i += 3;
                                        if (list.Count >= i)
                                        {
                                            panel11.Show();
                                            panel11.Size = new Size(758, 460);
                                            panel11.Location = new Point(3, tmp);
                                            tmp += 466;
                                            SPgiohang ct9 = new SPgiohang();
                                            ct9.Message = i.ToString();
                                            ct9.TopLevel = false;
                                            ct9.FormBorderStyle = FormBorderStyle.None;
                                            ct9.Dock = DockStyle.Fill;
                                            panel11.Controls.Add(ct9);
                                            ct9.BringToFront();
                                            ct9.Show();
                                            i += 3;
                                            if (list.Count >= i)
                                            {
                                                panel12.Show();
                                                panel12.Size = new Size(758, 460);
                                                panel12.Location = new Point(3, tmp);
                                                tmp += 466;
                                                SPgiohang ct10 = new SPgiohang();
                                                ct10.Message = i.ToString();
                                                ct10.TopLevel = false;
                                                ct10.FormBorderStyle = FormBorderStyle.None;
                                                ct10.Dock = DockStyle.Fill;
                                                panel12.Controls.Add(ct10);
                                                ct3.BringToFront();
                                                ct3.Show();
                                                i += 3;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }

            Sanpham tmpsp = new Sanpham();
            int tmpi = 0;
            int sum = 0;
            while (list.Count > tmpi)
            {
                tmpsp = s.getSP(list[tmpi].idsanpham.ToString());
                sum += (tmpsp.gia * list[tmpi].soluong);
                tmpi++;
            }
            tien.Text = sum.ToString();
            tien.Hide();
            tongtien.Text = sum.ToString("#,##0") + " VNĐ";
            int giam = Convert.ToInt32(sum * 0.1);
            int tt = sum - giam;
            label4.Text = "Giảm: " + giam.ToString("#,##0") + " VNĐ";
            thanhtien.Text = tt.ToString("#,##0") + " VNĐ";
        }


        private void Giadung_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void bt_addgiohang_Click(object sender, EventArgs e)
        {
            Dathang ct = new Dathang();
            ct.Message = thanhtien.Text;
            ct.Show();
        }
    }
}
