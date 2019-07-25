namespace Merida_Gui
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.tb_PGN = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Bt_Sortir = new System.Windows.Forms.Button();
            this.Rb_Negre = new System.Windows.Forms.RadioButton();
            this.Rb_Blanc = new System.Windows.Forms.RadioButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tb_Analisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(295, 296);
            this.Panel1.TabIndex = 2;
            this.Panel1.Click += new System.EventHandler(this.Panel1_MouseClick_1);
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // tb_PGN
            // 
            this.tb_PGN.Location = new System.Drawing.Point(367, 128);
            this.tb_PGN.Multiline = true;
            this.tb_PGN.Name = "tb_PGN";
            this.tb_PGN.Size = new System.Drawing.Size(347, 180);
            this.tb_PGN.TabIndex = 3;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(487, 23);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(179, 50);
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(364, 105);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(119, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Torneig, Localitat (Any) ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(364, 89);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 16);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Blanc - Negre";
            // 
            // Bt_Sortir
            // 
            this.Bt_Sortir.Location = new System.Drawing.Point(647, 487);
            this.Bt_Sortir.Name = "Bt_Sortir";
            this.Bt_Sortir.Size = new System.Drawing.Size(67, 34);
            this.Bt_Sortir.TabIndex = 12;
            this.Bt_Sortir.Text = "Sortir";
            this.Bt_Sortir.UseVisualStyleBackColor = true;
            this.Bt_Sortir.Click += new System.EventHandler(this.Bt_Sortir_Click);
            // 
            // Rb_Negre
            // 
            this.Rb_Negre.AutoSize = true;
            this.Rb_Negre.Enabled = false;
            this.Rb_Negre.Location = new System.Drawing.Point(318, 23);
            this.Rb_Negre.Name = "Rb_Negre";
            this.Rb_Negre.Size = new System.Drawing.Size(14, 13);
            this.Rb_Negre.TabIndex = 14;
            this.Rb_Negre.TabStop = true;
            this.Rb_Negre.UseVisualStyleBackColor = true;
            // 
            // Rb_Blanc
            // 
            this.Rb_Blanc.AutoSize = true;
            this.Rb_Blanc.Enabled = false;
            this.Rb_Blanc.Location = new System.Drawing.Point(318, 285);
            this.Rb_Blanc.Name = "Rb_Blanc";
            this.Rb_Blanc.Size = new System.Drawing.Size(14, 13);
            this.Rb_Blanc.TabIndex = 13;
            this.Rb_Blanc.TabStop = true;
            this.Rb_Blanc.UseVisualStyleBackColor = true;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "wwk.gif");
            this.ImageList1.Images.SetKeyName(1, "bwk.gif");
            this.ImageList1.Images.SetKeyName(2, "wwq.gif");
            this.ImageList1.Images.SetKeyName(3, "bwq.gif");
            this.ImageList1.Images.SetKeyName(4, "wwr.gif");
            this.ImageList1.Images.SetKeyName(5, "bwr.gif");
            this.ImageList1.Images.SetKeyName(6, "wwb.gif");
            this.ImageList1.Images.SetKeyName(7, "bwb.gif");
            this.ImageList1.Images.SetKeyName(8, "wwn.gif");
            this.ImageList1.Images.SetKeyName(9, "bwn.gif");
            this.ImageList1.Images.SetKeyName(10, "wwp.gif");
            this.ImageList1.Images.SetKeyName(11, "bwp.gif");
            this.ImageList1.Images.SetKeyName(12, "wbk.gif");
            this.ImageList1.Images.SetKeyName(13, "bbk.gif");
            this.ImageList1.Images.SetKeyName(14, "wbq.gif");
            this.ImageList1.Images.SetKeyName(15, "bbq.gif");
            this.ImageList1.Images.SetKeyName(16, "wbr.gif");
            this.ImageList1.Images.SetKeyName(17, "bbr.gif");
            this.ImageList1.Images.SetKeyName(18, "wbb.gif");
            this.ImageList1.Images.SetKeyName(19, "bbb.gif");
            this.ImageList1.Images.SetKeyName(20, "wbn.gif");
            this.ImageList1.Images.SetKeyName(21, "bbn.gif");
            this.ImageList1.Images.SetKeyName(22, "wbp.gif");
            this.ImageList1.Images.SetKeyName(23, "bbp.gif");
            this.ImageList1.Images.SetKeyName(24, "wsq.gif");
            this.ImageList1.Images.SetKeyName(25, "bsq.gif");
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "wwk.gif");
            this.ImageList2.Images.SetKeyName(1, "wwq.gif");
            this.ImageList2.Images.SetKeyName(2, "wwr.gif");
            this.ImageList2.Images.SetKeyName(3, "wwb.gif");
            this.ImageList2.Images.SetKeyName(4, "wwn.gif");
            this.ImageList2.Images.SetKeyName(5, "wwp.gif");
            this.ImageList2.Images.SetKeyName(6, "wbk.gif");
            this.ImageList2.Images.SetKeyName(7, "wbq.gif");
            this.ImageList2.Images.SetKeyName(8, "wbr.gif");
            this.ImageList2.Images.SetKeyName(9, "wbb.gif");
            this.ImageList2.Images.SetKeyName(10, "wbn.gif");
            this.ImageList2.Images.SetKeyName(11, "wbp.gif");
            // 
            // tb_Analisi
            // 
            this.tb_Analisi.Location = new System.Drawing.Point(12, 361);
            this.tb_Analisi.Multiline = true;
            this.tb_Analisi.Name = "tb_Analisi";
            this.tb_Analisi.Size = new System.Drawing.Size(702, 120);
            this.tb_Analisi.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Anàlisi";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Analisi);
            this.Controls.Add(this.Rb_Negre);
            this.Controls.Add(this.Rb_Blanc);
            this.Controls.Add(this.Bt_Sortir);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.tb_PGN);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox tb_PGN;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Bt_Sortir;
        internal System.Windows.Forms.RadioButton Rb_Negre;
        internal System.Windows.Forms.RadioButton Rb_Blanc;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ImageList ImageList2;
        internal System.Windows.Forms.TextBox tb_Analisi;
        internal System.Windows.Forms.Label label3;
    }
}

