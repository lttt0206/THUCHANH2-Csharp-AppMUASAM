
namespace MUASAM
{
    partial class Barcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label_head = new System.Windows.Forms.Label();
            this.picbarcode = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tensp = new System.Windows.Forms.Label();
            this.bt_xemsp = new FontAwesome.Sharp.IconButton();
            this.masp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_head.Location = new System.Drawing.Point(6, 4);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(397, 31);
            this.label_head.TabIndex = 0;
            this.label_head.Text = "TÌM KIẾM SẢN PHẨM BẰNG BARCODE";
            // 
            // picbarcode
            // 
            this.picbarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbarcode.Location = new System.Drawing.Point(24, 53);
            this.picbarcode.Name = "picbarcode";
            this.picbarcode.Size = new System.Drawing.Size(453, 140);
            this.picbarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbarcode.TabIndex = 1;
            this.picbarcode.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(544, 85);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(171, 52);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "CHỌN BARCODE";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(120, 219);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(357, 33);
            this.txtBarcode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Barcode:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tensp
            // 
            this.tensp.AutoSize = true;
            this.tensp.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tensp.Location = new System.Drawing.Point(354, 285);
            this.tensp.MaximumSize = new System.Drawing.Size(400, 0);
            this.tensp.Name = "tensp";
            this.tensp.Size = new System.Drawing.Size(391, 124);
            this.tensp.TabIndex = 6;
            this.tensp.Text = "Tên sản phẩm aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // bt_xemsp
            // 
            this.bt_xemsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(87)))), ((int)(((byte)(25)))));
            this.bt_xemsp.FlatAppearance.BorderSize = 0;
            this.bt_xemsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xemsp.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xemsp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xemsp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_xemsp.IconColor = System.Drawing.Color.Black;
            this.bt_xemsp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_xemsp.Location = new System.Drawing.Point(360, 477);
            this.bt_xemsp.Name = "bt_xemsp";
            this.bt_xemsp.Size = new System.Drawing.Size(396, 54);
            this.bt_xemsp.TabIndex = 19;
            this.bt_xemsp.Text = "XEM CHI TIẾT SẢN PHẨM";
            this.bt_xemsp.UseVisualStyleBackColor = false;
            this.bt_xemsp.Click += new System.EventHandler(this.bt_xemsp_Click);
            // 
            // masp
            // 
            this.masp.AutoSize = true;
            this.masp.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.masp.Location = new System.Drawing.Point(620, 534);
            this.masp.Name = "masp";
            this.masp.Size = new System.Drawing.Size(95, 27);
            this.masp.TabIndex = 20;
            this.masp.Text = "Barcode:";
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(784, 619);
            this.Controls.Add(this.masp);
            this.Controls.Add(this.bt_xemsp);
            this.Controls.Add(this.tensp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.picbarcode);
            this.Controls.Add(this.label_head);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barcode";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Cornsilk;
            this.Load += new System.EventHandler(this.Barcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox picbarcode;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tensp;
        private FontAwesome.Sharp.IconButton bt_xemsp;
        private System.Windows.Forms.Label masp;
    }
}

