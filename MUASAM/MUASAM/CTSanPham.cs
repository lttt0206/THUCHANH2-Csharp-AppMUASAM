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
    public partial class CTSanPham : KryptonForm
    {
        string strNhan;
        public CTSanPham()
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
            Xuly_Data s = new Xuly_Data();
            Sanpham sp = new Sanpham();
            sp = s.getSP(strNhan);
            tensp.Text = sp.tensanpham;
            masp.Text = sp.idsanpham.ToString();
            masp.Hide();
            gia.Text = sp.gia.ToString("#,##0") + " VNĐ";
            mota.Text = sp.mota;
            string st = s.getlinkHA(sp.idsanpham);
            st = st.Substring(1);
            pictureBox1.ImageLocation = st;
        }

        private void bt_addgiohang_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            var tmp = s.themgiohang(masp.Text);
            if (tmp == 1) Console.WriteLine("Thanh Cong");
            else Console.WriteLine("SAI!!!!");
            Notification ct = new Notification();
            ct.Message = "Đã thêm vào giỏ hàng";
            ct.Show();
        }

        private void icon_search_Click(object sender, EventArgs e)
        {
            Xuly_Data s = new Xuly_Data();
            var tmp = s.themyeuthich(masp.Text);
            if (tmp == 1) Console.WriteLine("Thanh Cong");
            else Console.WriteLine("SAI!!!!");
            Notification ct = new Notification();
            ct.Message = "Đã thêm vào yêu thích";
            ct.Show();
        }

        private void icon_search_MouseHover(object sender, EventArgs e)
        {
            icon_search.IconFont = IconFont.Solid;
        }

        private void icon_search_MouseLeave(object sender, EventArgs e)
        {
            icon_search.IconFont = IconFont.Regular;
        }
    }
}
