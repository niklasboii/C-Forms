namespace _4._Harjoitus___iän_laskeminen
{
    partial class IkaForm
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
            this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeIkaBT = new System.Windows.Forms.Button();
            this.VuosinaLB = new System.Windows.Forms.Label();
            this.KuukausinaLB = new System.Windows.Forms.Label();
            this.PaivinaLB = new System.Windows.Forms.Label();
            this.TunteinaLB = new System.Windows.Forms.Label();
            this.MinuutteinaLB = new System.Windows.Forms.Label();
            this.SekuntteinaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            this.SyntymaAikaDT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyntymaAikaDT.Location = new System.Drawing.Point(14, 14);
            this.SyntymaAikaDT.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SyntymaAikaDT.Name = "SyntymaAikaDT";
            this.SyntymaAikaDT.Size = new System.Drawing.Size(345, 36);
            this.SyntymaAikaDT.TabIndex = 0;
            // 
            // LaskeIkaBT
            // 
            this.LaskeIkaBT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeIkaBT.Location = new System.Drawing.Point(369, 11);
            this.LaskeIkaBT.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LaskeIkaBT.Name = "LaskeIkaBT";
            this.LaskeIkaBT.Size = new System.Drawing.Size(100, 46);
            this.LaskeIkaBT.TabIndex = 1;
            this.LaskeIkaBT.Text = "Laske";
            this.LaskeIkaBT.UseVisualStyleBackColor = true;
            this.LaskeIkaBT.Click += new System.EventHandler(this.LaskeIkaBT_Click);
            // 
            // VuosinaLB
            // 
            this.VuosinaLB.AutoSize = true;
            this.VuosinaLB.Location = new System.Drawing.Point(14, 70);
            this.VuosinaLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VuosinaLB.Name = "VuosinaLB";
            this.VuosinaLB.Size = new System.Drawing.Size(80, 25);
            this.VuosinaLB.TabIndex = 2;
            this.VuosinaLB.Text = "Vuosina";
            this.VuosinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            this.KuukausinaLB.AutoSize = true;
            this.KuukausinaLB.Location = new System.Drawing.Point(14, 119);
            this.KuukausinaLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.KuukausinaLB.Name = "KuukausinaLB";
            this.KuukausinaLB.Size = new System.Drawing.Size(109, 25);
            this.KuukausinaLB.TabIndex = 3;
            this.KuukausinaLB.Text = "Kuukausina";
            this.KuukausinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            this.PaivinaLB.AutoSize = true;
            this.PaivinaLB.Location = new System.Drawing.Point(14, 161);
            this.PaivinaLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PaivinaLB.Name = "PaivinaLB";
            this.PaivinaLB.Size = new System.Drawing.Size(72, 25);
            this.PaivinaLB.TabIndex = 4;
            this.PaivinaLB.Text = "Päivinä";
            this.PaivinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            this.TunteinaLB.AutoSize = true;
            this.TunteinaLB.Location = new System.Drawing.Point(252, 70);
            this.TunteinaLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TunteinaLB.Name = "TunteinaLB";
            this.TunteinaLB.Size = new System.Drawing.Size(86, 25);
            this.TunteinaLB.TabIndex = 5;
            this.TunteinaLB.Text = "Tunteina";
            this.TunteinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            this.MinuutteinaLB.AutoSize = true;
            this.MinuutteinaLB.Location = new System.Drawing.Point(252, 119);
            this.MinuutteinaLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MinuutteinaLB.Name = "MinuutteinaLB";
            this.MinuutteinaLB.Size = new System.Drawing.Size(115, 25);
            this.MinuutteinaLB.TabIndex = 6;
            this.MinuutteinaLB.Text = "Minuutteina";
            this.MinuutteinaLB.Visible = false;
            // 
            // SekuntteinaLB
            // 
            this.SekuntteinaLB.AutoSize = true;
            this.SekuntteinaLB.Location = new System.Drawing.Point(252, 161);
            this.SekuntteinaLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SekuntteinaLB.Name = "SekuntteinaLB";
            this.SekuntteinaLB.Size = new System.Drawing.Size(111, 25);
            this.SekuntteinaLB.TabIndex = 7;
            this.SekuntteinaLB.Text = "Sekuntteina";
            this.SekuntteinaLB.Visible = false;
            // 
            // IkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 233);
            this.Controls.Add(this.SekuntteinaLB);
            this.Controls.Add(this.MinuutteinaLB);
            this.Controls.Add(this.TunteinaLB);
            this.Controls.Add(this.PaivinaLB);
            this.Controls.Add(this.KuukausinaLB);
            this.Controls.Add(this.VuosinaLB);
            this.Controls.Add(this.LaskeIkaBT);
            this.Controls.Add(this.SyntymaAikaDT);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "IkaForm";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button LaskeIkaBT;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label PaivinaLB;
        private Label TunteinaLB;
        private Label MinuutteinaLB;
        private Label SekuntteinaLB;
    }
}