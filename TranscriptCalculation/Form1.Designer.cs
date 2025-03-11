namespace TranscriptCalculation
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
            groupBox1 = new GroupBox();
            lblSecilenDers = new Label();
            label2 = new Label();
            dgvDersler = new DataGridView();
            cmbFinal = new ComboBox();
            cmbAraSinav = new ComboBox();
            btnGNO = new Button();
            btnHarfNotu = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDersler);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblSecilenDers);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "NOT HESAPLAMA";
            // 
            // lblSecilenDers
            // 
            lblSecilenDers.BorderStyle = BorderStyle.FixedSingle;
            lblSecilenDers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSecilenDers.Location = new Point(7, 23);
            lblSecilenDers.Name = "lblSecilenDers";
            lblSecilenDers.Size = new Size(600, 39);
            lblSecilenDers.TabIndex = 0;
            lblSecilenDers.Text = "SEÇİLEN DERS:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(7, 344);
            label2.Name = "label2";
            label2.Size = new Size(600, 35);
            label2.TabIndex = 1;
            label2.Text = "GENEL NOT  ORTALAMASI:";
            // 
            // dgvDersler
            // 
            dgvDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDersler.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.GridColor = SystemColors.ButtonFace;
            dgvDersler.Location = new Point(7, 65);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.RowHeadersWidth = 51;
            dgvDersler.Size = new Size(601, 276);
            dgvDersler.TabIndex = 2;
            // 
            // cmbFinal
            // 
            cmbFinal.FormattingEnabled = true;
            cmbFinal.Location = new Point(634, 135);
            cmbFinal.Name = "cmbFinal";
            cmbFinal.Size = new Size(169, 28);
            cmbFinal.TabIndex = 1;
            // 
            // cmbAraSinav
            // 
            cmbAraSinav.FormattingEnabled = true;
            cmbAraSinav.Location = new Point(634, 57);
            cmbAraSinav.Name = "cmbAraSinav";
            cmbAraSinav.Size = new Size(169, 28);
            cmbAraSinav.TabIndex = 2;
            // 
            // btnGNO
            // 
            btnGNO.Location = new Point(634, 236);
            btnGNO.Name = "btnGNO";
            btnGNO.Size = new Size(142, 36);
            btnGNO.TabIndex = 3;
            btnGNO.Text = "Genel Ortalama";
            btnGNO.UseVisualStyleBackColor = true;
            // 
            // btnHarfNotu
            // 
            btnHarfNotu.Location = new Point(634, 181);
            btnHarfNotu.Name = "btnHarfNotu";
            btnHarfNotu.Size = new Size(142, 39);
            btnHarfNotu.TabIndex = 4;
            btnHarfNotu.Text = "Harf Notu";
            btnHarfNotu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(634, 25);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 5;
            label3.Text = "ARA SINAV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 112);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "FİNAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnHarfNotu);
            Controls.Add(btnGNO);
            Controls.Add(cmbAraSinav);
            Controls.Add(cmbFinal);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label lblSecilenDers;
        private DataGridView dgvDersler;
        private ComboBox cmbFinal;
        private ComboBox cmbAraSinav;
        private Button btnGNO;
        private Button btnHarfNotu;
        private Label label3;
        private Label label4;
    }
}
