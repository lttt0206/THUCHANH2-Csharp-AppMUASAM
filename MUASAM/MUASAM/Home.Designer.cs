
namespace MUASAM
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.bt_nhasach = new FontAwesome.Sharp.IconButton();
            this.bt_GioHang = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_mypham = new FontAwesome.Sharp.IconButton();
            this.bt_thoitrangnu = new FontAwesome.Sharp.IconButton();
            this.bt_thoitrangnam = new FontAwesome.Sharp.IconButton();
            this.bt_dientu = new FontAwesome.Sharp.IconButton();
            this.bt_giadung = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton_mini = new FontAwesome.Sharp.IconButton();
            this.iconButton_Close = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.iconButton_mini);
            this.panel1.Controls.Add(this.iconButton_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 22);
            this.panel1.TabIndex = 7;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 3;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.bt_nhasach);
            this.panelMenu.Controls.Add(this.bt_GioHang);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.bt_mypham);
            this.panelMenu.Controls.Add(this.bt_thoitrangnu);
            this.panelMenu.Controls.Add(this.bt_thoitrangnam);
            this.panelMenu.Controls.Add(this.bt_dientu);
            this.panelMenu.Controls.Add(this.bt_giadung);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 22);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 619);
            this.panelMenu.TabIndex = 8;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(200, 22);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(784, 619);
            this.panelDesktop.TabIndex = 9;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // bt_nhasach
            // 
            this.bt_nhasach.FlatAppearance.BorderSize = 0;
            this.bt_nhasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nhasach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_nhasach.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_nhasach.IconColor = System.Drawing.Color.Beige;
            this.bt_nhasach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_nhasach.Location = new System.Drawing.Point(0, 416);
            this.bt_nhasach.Name = "bt_nhasach";
            this.bt_nhasach.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.bt_nhasach.Size = new System.Drawing.Size(200, 55);
            this.bt_nhasach.TabIndex = 12;
            this.bt_nhasach.Text = "NHÀ SÁCH";
            this.bt_nhasach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_nhasach.UseVisualStyleBackColor = true;
            this.bt_nhasach.Click += new System.EventHandler(this.bt_nhasach_Click);
            // 
            // bt_GioHang
            // 
            this.bt_GioHang.FlatAppearance.BorderSize = 0;
            this.bt_GioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GioHang.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.bt_GioHang.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_GioHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_GioHang.IconSize = 60;
            this.bt_GioHang.Location = new System.Drawing.Point(55, 538);
            this.bt_GioHang.Name = "bt_GioHang";
            this.bt_GioHang.Size = new System.Drawing.Size(75, 69);
            this.bt_GioHang.TabIndex = 11;
            this.bt_GioHang.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MUASAM.Properties.Resources.Surrender__2_;
            this.pictureBox1.Location = new System.Drawing.Point(43, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bt_mypham
            // 
            this.bt_mypham.FlatAppearance.BorderSize = 0;
            this.bt_mypham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mypham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_mypham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_mypham.IconColor = System.Drawing.Color.Beige;
            this.bt_mypham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_mypham.Location = new System.Drawing.Point(0, 355);
            this.bt_mypham.Name = "bt_mypham";
            this.bt_mypham.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.bt_mypham.Size = new System.Drawing.Size(200, 55);
            this.bt_mypham.TabIndex = 9;
            this.bt_mypham.Text = "MỸ PHẨM - TRANG SỨC";
            this.bt_mypham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_mypham.UseVisualStyleBackColor = true;
            this.bt_mypham.Click += new System.EventHandler(this.bt_mypham_Click);
            // 
            // bt_thoitrangnu
            // 
            this.bt_thoitrangnu.FlatAppearance.BorderSize = 0;
            this.bt_thoitrangnu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoitrangnu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_thoitrangnu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_thoitrangnu.IconColor = System.Drawing.Color.Beige;
            this.bt_thoitrangnu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_thoitrangnu.Location = new System.Drawing.Point(0, 294);
            this.bt_thoitrangnu.Name = "bt_thoitrangnu";
            this.bt_thoitrangnu.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.bt_thoitrangnu.Size = new System.Drawing.Size(200, 55);
            this.bt_thoitrangnu.TabIndex = 3;
            this.bt_thoitrangnu.Text = "THỜI TRANG NỮ";
            this.bt_thoitrangnu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoitrangnu.UseVisualStyleBackColor = true;
            this.bt_thoitrangnu.Click += new System.EventHandler(this.bt_thoitrangnu_Click);
            // 
            // bt_thoitrangnam
            // 
            this.bt_thoitrangnam.FlatAppearance.BorderSize = 0;
            this.bt_thoitrangnam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoitrangnam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_thoitrangnam.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_thoitrangnam.IconColor = System.Drawing.Color.Beige;
            this.bt_thoitrangnam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_thoitrangnam.Location = new System.Drawing.Point(0, 233);
            this.bt_thoitrangnam.Name = "bt_thoitrangnam";
            this.bt_thoitrangnam.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.bt_thoitrangnam.Size = new System.Drawing.Size(200, 55);
            this.bt_thoitrangnam.TabIndex = 2;
            this.bt_thoitrangnam.Text = "THỜI TRANG NAM";
            this.bt_thoitrangnam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoitrangnam.UseVisualStyleBackColor = true;
            this.bt_thoitrangnam.Click += new System.EventHandler(this.bt_thoitrangnam_Click);
            // 
            // bt_dientu
            // 
            this.bt_dientu.FlatAppearance.BorderSize = 0;
            this.bt_dientu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dientu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_dientu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_dientu.IconColor = System.Drawing.Color.Beige;
            this.bt_dientu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_dientu.Location = new System.Drawing.Point(0, 172);
            this.bt_dientu.Name = "bt_dientu";
            this.bt_dientu.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.bt_dientu.Size = new System.Drawing.Size(200, 55);
            this.bt_dientu.TabIndex = 1;
            this.bt_dientu.Text = "ĐIỆN TỬ - ĐIỆN LẠNH";
            this.bt_dientu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dientu.UseVisualStyleBackColor = true;
            this.bt_dientu.Click += new System.EventHandler(this.bt_dientu_Click);
            // 
            // bt_giadung
            // 
            this.bt_giadung.FlatAppearance.BorderSize = 0;
            this.bt_giadung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_giadung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_giadung.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_giadung.IconColor = System.Drawing.Color.Beige;
            this.bt_giadung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_giadung.Location = new System.Drawing.Point(0, 111);
            this.bt_giadung.Name = "bt_giadung";
            this.bt_giadung.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.bt_giadung.Size = new System.Drawing.Size(200, 55);
            this.bt_giadung.TabIndex = 0;
            this.bt_giadung.Text = "NHÀ CỬA - ĐỜI SỐNG";
            this.bt_giadung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_giadung.UseVisualStyleBackColor = true;
            this.bt_giadung.Click += new System.EventHandler(this.btgiadung_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // iconButton_mini
            // 
            this.iconButton_mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.iconButton_mini.FlatAppearance.BorderSize = 0;
            this.iconButton_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_mini.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_mini.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_mini.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton_mini.IconColor = System.Drawing.Color.White;
            this.iconButton_mini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_mini.IconSize = 15;
            this.iconButton_mini.Location = new System.Drawing.Point(897, 0);
            this.iconButton_mini.Name = "iconButton_mini";
            this.iconButton_mini.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iconButton_mini.Size = new System.Drawing.Size(42, 22);
            this.iconButton_mini.TabIndex = 9;
            this.iconButton_mini.UseVisualStyleBackColor = false;
            this.iconButton_mini.Click += new System.EventHandler(this.iconButton_mini_Click);
            this.iconButton_mini.MouseLeave += new System.EventHandler(this.iconButton_mini_MouseLeave);
            this.iconButton_mini.MouseHover += new System.EventHandler(this.iconButton_mini_MouseHover);
            // 
            // iconButton_Close
            // 
            this.iconButton_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.iconButton_Close.FlatAppearance.BorderSize = 0;
            this.iconButton_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Close.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton_Close.IconColor = System.Drawing.Color.White;
            this.iconButton_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Close.IconSize = 15;
            this.iconButton_Close.Location = new System.Drawing.Point(942, 0);
            this.iconButton_Close.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_Close.Name = "iconButton_Close";
            this.iconButton_Close.Size = new System.Drawing.Size(42, 22);
            this.iconButton_Close.TabIndex = 8;
            this.iconButton_Close.UseVisualStyleBackColor = false;
            this.iconButton_Close.Click += new System.EventHandler(this.iconButton_Close_Click);
            this.iconButton_Close.MouseLeave += new System.EventHandler(this.iconButton_Close_MouseLeave);
            this.iconButton_Close.MouseHover += new System.EventHandler(this.iconButton_Close_MouseHover);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Cornsilk;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton_Close;
        private FontAwesome.Sharp.IconButton iconButton_mini;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton bt_giadung;
        private FontAwesome.Sharp.IconButton bt_mypham;
        private FontAwesome.Sharp.IconButton bt_thoitrangnu;
        private FontAwesome.Sharp.IconButton bt_thoitrangnam;
        private FontAwesome.Sharp.IconButton bt_dientu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton bt_GioHang;
        private FontAwesome.Sharp.IconButton bt_nhasach;
    }
}

