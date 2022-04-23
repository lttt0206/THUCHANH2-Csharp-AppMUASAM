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
    public partial class Giadung : KryptonForm
    {
        public Giadung()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.Controls.Add(Xemthem);
        }
        private void OpenChildForm(Form childForm)
        {
            /*if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
*/
            panel_them.Size = new Size(758, 619);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Bottom;
            panel_them.Controls.Add(childForm);
            panel_them.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label_head_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Xemthem());
        }

        private void Giadung_Load(object sender, EventArgs e)
        {

        }

        private void giasp1_Click(object sender, EventArgs e)
        {

        }
    }
}
