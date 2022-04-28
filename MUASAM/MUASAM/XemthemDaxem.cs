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
    public partial class XemthemDaxem : KryptonForm
    {
        string strNhan;
        public XemthemDaxem()
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

        private void label_head_Click(object sender, EventArgs e)
        {

        }

        private void Xemthem_Load(object sender, EventArgs e)
        {
            int tmp = Convert.ToInt32(strNhan);
            Xuly_Data s = new Xuly_Data();
            List<Sanpham> list = s.sqlGetSanphamDaxem();
            int i = tmp-1;

            if (list.Count > i)
            {
                string st = s.getlinkHA(list[i].idsanpham);
                st = st.Substring(1);
                pictureBox1.ImageLocation = st;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp1.Text = list[i].tensanpham;
                ma1.Text = list[i].idsanpham.ToString();
                ma1.Hide();
                giasp1.Text = list[i].gia.ToString("#,##0") + " VNĐ";
                daban1.Text = list[i].daban.ToString();
                i++;
            }
            else
            {
                panel1.Hide();
            }

            if (list.Count > i)
            {
                string st = s.getlinkHA(list[i].idsanpham);
                st = st.Substring(1);
                pictureBox2.ImageLocation = st;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp2.Text = list[i].tensanpham;
                ma2.Text = list[i].idsanpham.ToString();
                ma2.Hide();
                giasp2.Text = list[i].gia.ToString("#,##0") + " VNĐ";
                daban2.Text = list[i].daban.ToString();
                i++;
            }
            else
            {
                panel2.Hide();
            }

            if (list.Count > i)
            {
                string st = s.getlinkHA(list[i].idsanpham);
                st = st.Substring(1);
                pictureBox3.ImageLocation = st;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp3.Text = list[i].tensanpham;
                ma3.Text = list[i].idsanpham.ToString();
                ma3.Hide();
                giasp3.Text = list[i].gia.ToString("#,##0") + " VNĐ";
                daban3.Text = list[i].daban.ToString();
                i++;
            }
            else
            {
                panel3.Hide();
            }

            if (list.Count > i)
            {
                string st = s.getlinkHA(list[i].idsanpham);
                st = st.Substring(1);
                pictureBox4.ImageLocation = st;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp4.Text = list[i].tensanpham;
                ma4.Text = list[i].idsanpham.ToString();
                ma4.Hide();
                giasp4.Text = list[i].gia.ToString("#,##0") + " VNĐ";
                daban4.Text = list[i].daban.ToString();
                i++;
            }
            else
            {
                panel4.Hide();
            }

            if (list.Count > i)
            {
                string st = s.getlinkHA(list[i].idsanpham);
                st = st.Substring(1);
                pictureBox5.ImageLocation = st;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp5.Text = list[i].tensanpham;
                ma5.Text = list[i].idsanpham.ToString();
                ma5.Hide();
                giasp5.Text = list[i].gia.ToString("#,##0") + " VNĐ";
                daban5.Text = list[i].daban.ToString();
                i++;
            }
            else
            {
                panel5.Hide();
            }

            if (list.Count > i)
            {
                string st = s.getlinkHA(list[i].idsanpham);
                st = st.Substring(1);
                pictureBox6.ImageLocation = st;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp6.Text = list[i].tensanpham;
                ma6.Text = list[i].idsanpham.ToString();
                ma6.Hide();
                giasp6.Text = list[i].gia.ToString("#,##0") + " VNĐ";
                daban6.Text = list[i].daban.ToString();
                i++;
            }
            else
            {
                panel6.Hide();
            }

            if (list.Count > i)
            {
                string st = s.getlinkHA(list[i].idsanpham);
                st = st.Substring(1);
                pictureBox7.ImageLocation = st;
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp7.Text = list[i].tensanpham;
                ma7.Text = list[i].idsanpham.ToString();
                ma7.Hide();
                giasp7.Text = list[i].gia.ToString("#,##0") + " VNĐ";
                daban7.Text = list[i].daban.ToString();
                i++;
            }
            else
            {
                panel7.Hide();
            }

            if (list.Count > i)
            {
                string st = s.getlinkHA(list[i].idsanpham);
                st = st.Substring(1);
                pictureBox8.ImageLocation = st;
                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp8.Text = list[i].tensanpham;
                ma8.Text = list[i].idsanpham.ToString();
                ma8.Hide();
                giasp8.Text = list[i].gia.ToString("#,##0") + " VNĐ";
                daban8.Text = list[i].daban.ToString();
                i++;
            }
            else
            {
                panel8.Hide();
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (!tensp1.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = ma1.Text;
                ct.Show();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!tensp2.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = ma2.Text;
                ct.Show();
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!tensp3.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = ma3.Text;
                ct.Show();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (!tensp4.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = ma4.Text;
                ct.Show();
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!tensp5.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = ma5.Text;
                ct.Show();
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!tensp6.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = ma6.Text;
                ct.Show();
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (!tensp7.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = ma7.Text;
                ct.Show();
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (!tensp8.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = ma8.Text;
                ct.Show();
            }
        }
    }
}
