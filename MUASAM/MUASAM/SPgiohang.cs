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
    public partial class SPgiohang : KryptonForm
    {
        string strNhan;
        public SPgiohang()
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
            Xuly_Data s = new Xuly_Data();
            List<Giohang> list = s.sqlGetGiohang();
            int i = Convert.ToInt32(strNhan)-1;
            Sanpham tmp = new Sanpham();
            if (list.Count > i)
            {
                tmp = s.getSP(list[i].idsanpham.ToString());
                string st = s.getlinkHA(tmp.idsanpham);
                st = st.Substring(1);
                pictureBox1.ImageLocation = st;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp1.Text = tmp.tensanpham;
                ma1.Text = tmp.idsanpham.ToString();
                ma1.Hide();
                gia1.Text = list[i].soluong.ToString() + " x " + tmp.gia.ToString("#,##0");
                soluong1.Text = list[i].soluong.ToString();
                tien1.Text = (tmp.gia * list[i].soluong).ToString("#,##0") + " VNĐ";
                i++;
            }
            else
            {
                panel1.Hide();
            }

            if (list.Count > i)
            {
                tmp = s.getSP(list[i].idsanpham.ToString());
                string st = s.getlinkHA(tmp.idsanpham);
                st = st.Substring(1);
                pictureBox2.ImageLocation = st;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp2.Text = tmp.tensanpham;
                ma2.Text = tmp.idsanpham.ToString();
                ma2.Hide();
                gia2.Text = list[i].soluong.ToString() + " x " + tmp.gia.ToString("#,##0");
                soluong2.Text = list[i].soluong.ToString();
                tien2.Text = (tmp.gia * list[i].soluong).ToString("#,##0") + " VNĐ";
                i++;
            }
            else
            {
                panel2.Hide();
            }

            if (list.Count > i)
            {
                tmp = s.getSP(list[i].idsanpham.ToString());
                string st = s.getlinkHA(tmp.idsanpham);
                st = st.Substring(1);
                pictureBox3.ImageLocation = st;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                tensp3.Text = tmp.tensanpham;
                ma3.Text = tmp.idsanpham.ToString();
                ma3.Hide();
                gia3.Text = list[i].soluong.ToString() + " x " + tmp.gia.ToString("#,##0");
                soluong3.Text = list[i].soluong.ToString();
                tien3.Text = (tmp.gia * list[i].soluong).ToString("#,##0") + " VNĐ";
                i++;
            }
            else
            {
                panel3.Hide();
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

        private void bt_xoa1_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            var tmp = s.xoaspgiohang(ma1.Text);
            this.Invalidate();
            panel1.Hide();
        }

        private void xoa2_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            var tmp = s.xoaspgiohang(ma2.Text);
            this.Invalidate();
            panel2.Hide();
        }

        private void xoa3_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            var tmp = s.xoaspgiohang(ma3.Text);
            this.Invalidate();
            panel3.Hide();
        }

        private void bt_cong1_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            Sanpham sp = s.getSP(ma1.Text);
            int tmp = Convert.ToInt32(soluong1.Text);
            if (tmp < sp.soluong)
            {
                s.conggiohang(ma1.Text, tmp);
                soluong1.Text = (tmp + 1).ToString();
            }
            else
            {
                Notification ct = new Notification();
                ct.Message = "Đã đạt số lượng tối đa";
                ct.Show();
            }
        }

        private void bt_tru1_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            int tmp = Convert.ToInt32(soluong1.Text);
            if (tmp > 1)
            {
                s.trugiohang(ma1.Text, tmp);
                soluong1.Text = (tmp - 1).ToString();
            }
            else
            {
                s.xoaspgiohang(ma1.Text);
            }
        }

        private void bt_tru2_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            int tmp = Convert.ToInt32(soluong2.Text);
            if (tmp > 1)
            {
                s.trugiohang(ma2.Text, tmp);
                soluong2.Text = (tmp - 1).ToString();
            }
            else
            {
                s.xoaspgiohang(ma2.Text);
            }
        }

        private void bt_cong2_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            Sanpham sp = s.getSP(ma2.Text);
            int tmp = Convert.ToInt32(soluong2.Text);
            if (tmp < sp.soluong)
            {
                s.conggiohang(ma2.Text, tmp);
                soluong2.Text = (tmp + 1).ToString();
            }
            else
            {
                Notification ct = new Notification();
                ct.Message = "Đã đạt số lượng tối đa";
                ct.Show();
            }
        }

        private void tru3_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            int tmp = Convert.ToInt32(soluong3.Text);
            if (tmp > 1)
            {
                s.trugiohang(ma3.Text, tmp);
                soluong3.Text = (tmp - 1).ToString();
            }
            else
            {
                s.xoaspgiohang(ma3.Text);
            }
        }

        private void cong3_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            Sanpham sp = s.getSP(ma3.Text);
            int tmp = Convert.ToInt32(soluong3.Text);
            if (tmp < sp.soluong)
            {
                s.conggiohang(ma3.Text, tmp);
                soluong3.Text = (tmp + 1).ToString();
            }
            else
            {
                Notification ct = new Notification();
                ct.Message = "Đã đạt số lượng tối đa";
                ct.Show();
            }
        }
    }
}
