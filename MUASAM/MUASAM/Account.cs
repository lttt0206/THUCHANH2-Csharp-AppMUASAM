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
    public partial class Account : KryptonForm
    {
        public Account()
        {
            InitializeComponent();
        }
        private void Barcode_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            YeuthichUI ct = new YeuthichUI();
            ct.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Lichsudonhang ct = new Lichsudonhang();
            ct.Show();
        }
    }
}
