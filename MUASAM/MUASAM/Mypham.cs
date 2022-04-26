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
    public partial class Mypham : KryptonForm
    {
        public Mypham()
        {
            InitializeComponent();
            Xuly_Data s = new Xuly_Data();
            List<Sanpham> list = s.sqlGetSanpham("Dientu");
            panel2.Size = new Size(758, 564);
            Xemthem ct = new Xemthem();
            int i = 1;
            ct.Message = "Dientu-" + i;
            i += 8;
            ct.TopLevel = false;
            ct.FormBorderStyle = FormBorderStyle.None;
            ct.Dock = DockStyle.Fill;
            panel2.Controls.Add(ct);
            ct.BringToFront();
            ct.Show();
            panel3.Hide();
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
                panel3.Show();
                panel3.Size = new Size(758, 564);
                panel3.Location = new Point(3, tmp);
                tmp += 570;
                tmp2 += 8;
                Xemthem ct2 = new Xemthem();
                ct2.Message = "Dientu-" + i;
                ct2.TopLevel = false;
                ct2.FormBorderStyle = FormBorderStyle.None;
                ct2.Dock = DockStyle.Fill;
                panel3.Controls.Add(ct2);
                ct2.BringToFront();
                ct2.Show();
                if (list.Count > tmp2)
                {
                    panel4.Show();
                    panel4.Size = new Size(758, 564);
                    panel4.Location = new Point(3, tmp);
                    tmp += 570;
                    tmp2 += 8;
                    Xemthem ct3 = new Xemthem();
                    ct3.Message = "Dientu- " + i;
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
                        panel5.Size = new Size(758, 564);
                        panel5.Location = new Point(3, tmp);
                        tmp += 570;
                        tmp2 += 8;
                        Xemthem ct4 = new Xemthem();
                        ct4.Message = "Dientu-" + i;
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
                            panel6.Size = new Size(758, 564);
                            panel6.Location = new Point(3, tmp);
                            tmp += 570;
                            tmp2 += 8;
                            Xemthem ct5 = new Xemthem();
                            ct5.Message = "Dientu-" + i;
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
                                panel7.Size = new Size(758, 564);
                                panel7.Location = new Point(3, tmp);
                                tmp += 570;
                                tmp2 += 8;
                                Xemthem ct6 = new Xemthem();
                                ct6.Message = "Dientu-" + i;
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
                                    panel8.Size = new Size(758, 564);
                                    panel8.Location = new Point(3, tmp);
                                    tmp += 570;
                                    tmp2 += 8;
                                    Xemthem ct7 = new Xemthem();
                                    ct7.Message = "Dientu-" + i;
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
                                        panel9.Size = new Size(758, 564);
                                        panel9.Location = new Point(3, tmp);
                                        tmp += 570;
                                        tmp2 += 8;
                                        Xemthem ct8 = new Xemthem();
                                        ct8.Message = "Dientu-" + i;
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
                                            panel10.Size = new Size(758, 564);
                                            panel10.Location = new Point(3, tmp);
                                            tmp += 570;
                                            tmp2 += 8;
                                            Xemthem ct9 = new Xemthem();
                                            ct9.Message = "Dientu-" + i;
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
                                                panel11.Size = new Size(758, 564);
                                                panel11.Location = new Point(3, tmp);
                                                tmp += 570;
                                                tmp2 += 8;
                                                Xemthem ct10 = new Xemthem();
                                                ct10.Message = "Dientu-" + i;
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
                                                    panel12.Size = new Size(758, 564);
                                                    panel12.Location = new Point(3, tmp);
                                                    tmp += 570;
                                                    tmp2 += 8;
                                                    Xemthem ct11 = new Xemthem();
                                                    ct11.Message = "Dientu-" + i;
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
                                                        panel13.Size = new Size(758, 564);
                                                        panel13.Location = new Point(3, tmp);
                                                        tmp += 570;
                                                        tmp2 += 8;
                                                        Xemthem ct12 = new Xemthem();
                                                        ct12.Message = "Dientu-" + i;
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
                                                            panel14.Size = new Size(758, 564);
                                                            panel14.Location = new Point(3, tmp);
                                                            tmp += 570;
                                                            tmp2 += 8;
                                                            Xemthem ct13 = new Xemthem();
                                                            ct5.Message = "Dientu-" + i;
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
                                                                panel15.Size = new Size(758, 564);
                                                                panel15.Location = new Point(3, tmp);
                                                                tmp += 570;
                                                                tmp2 += 8;
                                                                Xemthem ct14 = new Xemthem();
                                                                ct14.Message = "Dientu-" + i;
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
                                                                    panel16.Size = new Size(758, 564);
                                                                    panel16.Location = new Point(3, tmp);
                                                                    tmp += 570;
                                                                    tmp2 += 8;
                                                                    Xemthem ct15 = new Xemthem();
                                                                    ct15.Message = "Dientu-" + i;
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

        private void Dientu_Load(object sender, EventArgs e)
        {

        }
    }
}
