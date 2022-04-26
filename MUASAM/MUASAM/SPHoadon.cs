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
    public partial class SPHoadon : KryptonForm
    {
        string strNhan;
        public SPHoadon()
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
            Console.WriteLine(list.Count);
            Sanpham tmp = new Sanpham();
            if (list.Count > i)
            {
                tmp = s.getSP(list[i].idsanpham.ToString());
                tensp1.Text = tmp.tensanpham;
                sl1.Text = list[i].soluong.ToString();
                i++;
            }
            else
            {
                panel1.Hide();
            }

            if (list.Count > i)
            {
                tmp = s.getSP(list[i].idsanpham.ToString());
                tensp2.Text = tmp.tensanpham;
                sl2.Text = list[i].soluong.ToString();
                i++;
            }
            else
            {
                panel2.Hide();
            }

            if (list.Count > i)
            {
                tmp = s.getSP(list[i].idsanpham.ToString());
                tensp3.Text = tmp.tensanpham;
                sl3.Text = list[i].soluong.ToString();
                i++;
            }
            else
            {
                panel3.Hide();
            }

            if(list.Count > i)
            {
                tmp = s.getSP(list[i].idsanpham.ToString());
                tensp4.Text = tmp.tensanpham;
                sl4.Text = list[i].soluong.ToString();
                i++;
            }
            else
            {
                panel4.Hide();
            }
        }

        

        
    }
}
