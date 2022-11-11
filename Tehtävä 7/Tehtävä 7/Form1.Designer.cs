namespace Tehtävä_7
{
    partial class KustannusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutuksetTB = new System.Windows.Forms.TextBox();
            this.MuutKulutTB = new System.Windows.Forms.TextBox();
            this.PolttonesteTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.KilometritCB = new System.Windows.Forms.ComboBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auton kustannus laskuri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lainan lyhennys korkoineen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vakuutusmaksut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Muut kulut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Polttoneste:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pesut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Huollot:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Renkaat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 298);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 30);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kilometrit / Vuosi:";
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(311, 88);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(100, 37);
            this.LainaTB.TabIndex = 10;
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(311, 157);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(100, 37);
            this.NesteetTB.TabIndex = 11;
            // 
            // VakuutuksetTB
            // 
            this.VakuutuksetTB.Location = new System.Drawing.Point(311, 226);
            this.VakuutuksetTB.Name = "VakuutuksetTB";
            this.VakuutuksetTB.Size = new System.Drawing.Size(100, 37);
            this.VakuutuksetTB.TabIndex = 12;
            // 
            // MuutKulutTB
            // 
            this.MuutKulutTB.Location = new System.Drawing.Point(311, 295);
            this.MuutKulutTB.Name = "MuutKulutTB";
            this.MuutKulutTB.Size = new System.Drawing.Size(100, 37);
            this.MuutKulutTB.TabIndex = 13;
            // 
            // PolttonesteTB
            // 
            this.PolttonesteTB.Location = new System.Drawing.Point(311, 364);
            this.PolttonesteTB.Name = "PolttonesteTB";
            this.PolttonesteTB.Size = new System.Drawing.Size(100, 37);
            this.PolttonesteTB.TabIndex = 14;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(742, 226);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(100, 37);
            this.RenkaatTB.TabIndex = 15;
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(742, 157);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(100, 37);
            this.HuollotTB.TabIndex = 16;
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(742, 88);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(100, 37);
            this.PesutTB.TabIndex = 17;
            // 
            // KilometritCB
            // 
            this.KilometritCB.FormattingEnabled = true;
            this.KilometritCB.Items.AddRange(new object[] {
            "5000",
            "15000",
            "20000",
            "25000",
            "30000",
            "35000",
            "40000",
            "45000",
            "50000",
            "55000",
            "60000",
            "65000",
            "70000",
            "75000",
            "80000",
            "85000",
            "90000",
            "95000",
            "100000"});
            this.KilometritCB.Location = new System.Drawing.Point(742, 295);
            this.KilometritCB.Name = "KilometritCB";
            this.KilometritCB.Size = new System.Drawing.Size(121, 38);
            this.KilometritCB.TabIndex = 18;
            this.KilometritCB.SelectedIndexChanged += new System.EventHandler(this.KilometritCB_SelectedIndexChanged);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(390, 447);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(81, 30);
            this.VastausLB.TabIndex = 19;
            this.VastausLB.Text = "Teksti";
            this.VastausLB.Visible = false;
            // 
            // KustannusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 522);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KilometritCB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.PolttonesteTB);
            this.Controls.Add(this.MuutKulutTB);
            this.Controls.Add(this.VakuutuksetTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KustannusForm";
            this.Text = "Kilometri kulutus laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox LainaTB;
        private TextBox NesteetTB;
        private TextBox VakuutuksetTB;
        private TextBox MuutKulutTB;
        private TextBox PolttonesteTB;
        private TextBox RenkaatTB;
        private TextBox HuollotTB;
        private TextBox PesutTB;
        private ComboBox KilometritCB;
        private Label VastausLB;
    }
}