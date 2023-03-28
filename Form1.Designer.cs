namespace GyumolcsArazo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btAlma = new Button();
            BtKorte = new Button();
            BtBanan = new Button();
            btNarancs = new Button();
            tbTomeg = new TextBox();
            llAr = new Label();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btAlma);
            flowLayoutPanel1.Controls.Add(BtKorte);
            flowLayoutPanel1.Controls.Add(BtBanan);
            flowLayoutPanel1.Controls.Add(btNarancs);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(720, 242);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btAlma
            // 
            btAlma.Image = (Image)resources.GetObject("btAlma.Image");
            btAlma.Location = new Point(3, 3);
            btAlma.Name = "btAlma";
            btAlma.Size = new Size(132, 121);
            btAlma.TabIndex = 0;
            btAlma.Text = "400";
            btAlma.UseVisualStyleBackColor = true;
            btAlma.Click += bt_Click;
            // 
            // BtKorte
            // 
            BtKorte.Image = (Image)resources.GetObject("BtKorte.Image");
            BtKorte.Location = new Point(141, 3);
            BtKorte.Name = "BtKorte";
            BtKorte.Size = new Size(132, 121);
            BtKorte.TabIndex = 1;
            BtKorte.Text = "700";
            BtKorte.UseVisualStyleBackColor = true;
            BtKorte.Click += bt_Click;
            // 
            // BtBanan
            // 
            BtBanan.Image = (Image)resources.GetObject("BtBanan.Image");
            BtBanan.Location = new Point(279, 3);
            BtBanan.Name = "BtBanan";
            BtBanan.Size = new Size(132, 121);
            BtBanan.TabIndex = 2;
            BtBanan.Text = "300";
            BtBanan.UseVisualStyleBackColor = true;
            BtBanan.Click += bt_Click;
            // 
            // btNarancs
            // 
            btNarancs.Image = (Image)resources.GetObject("btNarancs.Image");
            btNarancs.Location = new Point(417, 3);
            btNarancs.Name = "btNarancs";
            btNarancs.Size = new Size(132, 121);
            btNarancs.TabIndex = 3;
            btNarancs.Text = "500";
            btNarancs.UseVisualStyleBackColor = true;
            btNarancs.Click += bt_Click;
            // 
            // tbTomeg
            // 
            tbTomeg.Location = new Point(29, 258);
            tbTomeg.Name = "tbTomeg";
            tbTomeg.PlaceholderText = "Kg";
            tbTomeg.Size = new Size(150, 31);
            tbTomeg.TabIndex = 1;
            // 
            // llAr
            // 
            llAr.AutoSize = true;
            llAr.Location = new Point(251, 264);
            llAr.Name = "llAr";
            llAr.Size = new Size(22, 25);
            llAr.TabIndex = 2;
            llAr.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 264);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 3;
            label1.Text = "Ár:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 372);
            Controls.Add(label1);
            Controls.Add(llAr);
            Controls.Add(tbTomeg);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Gyümölcsárazó";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btAlma;
        private Button BtKorte;
        private Button BtBanan;
        private Button btNarancs;
        private TextBox tbTomeg;
        private Label llAr;
        private Label label1;
    }
}