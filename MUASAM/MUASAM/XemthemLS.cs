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
    public partial class XemthemLS : KryptonForm
    {
        string strNhan;
        public XemthemLS()
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
            List<Donhang> list = s.getDonhang();
            int i = tmp-1;

            if (list.Count > i)
            {
                ma1.Text = "#" + list[i].iddonhang.ToString();
                ten.Text = "Tên: " + list[i].tennguoinhan;
                diachi1.Text = "Địa chỉ:" + list[i].diachinhan;
                sdt.Text = "Số điện thoại: " + list[i].sdt;
                tien1.Text = "Thành tiền: " + list[i].thanhtien.ToString("#,##0") + " VNĐ";
                if (list[i].tinhtrang == 1) tinhtrang1.Text = "Tình trạng: Đã giao";
                else
                {
                    tinhtrang1.Text = "Tình trạng: Chưa giao";
                    tinhtrang1.ForeColor = Color.FromArgb(255, 0, 0);
                }
                i++;
            }
            else
            {
                panel1.Hide();
            }

            if (list.Count > i)
            {
                ma2.Text = "#" + list[i].iddonhang.ToString();
                ten2.Text = "Tên: " + list[i].tennguoinhan;
                diachi2.Text = "Địa chỉ:" + list[i].diachinhan;
                sdt2.Text = "Số điện thoại: " + list[i].sdt;
                tien2.Text = "Thành tiền: " + list[i].thanhtien.ToString("#,##0") + " VNĐ";
                if (list[i].tinhtrang == 1) tinhtrang2.Text = "Tình trạng: Đã giao";
                else
                {
                    tinhtrang2.Text = "Tình trạng: Chưa giao";
                    tinhtrang2.ForeColor = Color.FromArgb(255, 0, 0);
                }
                i++;
            }
            else
            {
                panel2.Hide();
            }

            if (list.Count > i)
            {
                ma3.Text = "#" + list[i].iddonhang.ToString();
                ten3.Text = "Tên: " + list[i].tennguoinhan;
                diachi3.Text = "Địa chỉ:" + list[i].diachinhan;
                sdt3.Text = "Số điện thoại: " + list[i].sdt;
                tien3.Text = "Thành tiền: " + list[i].thanhtien.ToString("#,##0") + " VNĐ";
                if (list[i].tinhtrang == 1) tinhtrang3.Text = "Tình trạng: Đã giao";
                else
                {
                    tinhtrang3.Text = "Tình trạng: Chưa giao";
                    tinhtrang3.ForeColor = Color.FromArgb(255, 0, 0);
                }
                i++;
            }
            else
            {
                panel3.Hide();
            }

            
        }

       
    }
}
