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
using ZXing;

namespace MUASAM
{
    public partial class Barcode : KryptonForm
    {
        public Barcode()
        {
            InitializeComponent();
            tensp.Hide();
            masp.Hide();
            bt_xemsp.Hide();
        }
        private void Barcode_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "JPG|*.jpg|*.png|*.gif" })
            {
                if (of.ShowDialog()== DialogResult.OK)
                {
                    BarcodeReader reader = new BarcodeReader();
                    picbarcode.Image = Image.FromFile(of.FileName);
                    var result = reader.Decode((Bitmap)picbarcode.Image);
                    if (result!=null)
                    {
                        txtBarcode.Text = result.ToString();
                        Xuly_Data s = new Xuly_Data();
                        Sanpham sp = new Sanpham();
                        int tmp = Convert.ToInt32(result.ToString());
                        sp = s.getSP(tmp.ToString());
                        tensp.Text = sp.tensanpham;
                        masp.Text = sp.idsanpham.ToString();
                        string st = s.getlinkHA(tmp);
                        st = st.Substring(1);
                        pictureBox1.ImageLocation = st;
                        Console.WriteLine(st);                        
                        tensp.Show();
                        bt_xemsp.Show();
                    }

                }
            }
            
        }

        private void bt_xemsp_Click(object sender, EventArgs e)
        {
            if (!tensp.Text.Equals(""))
            {
                CTSanPham ct = new CTSanPham();
                ct.Message = masp.Text;
                ct.Show();
            }
        }
    }
}
