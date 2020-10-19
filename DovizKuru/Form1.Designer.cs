namespace DovizKuru
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTarih = new System.Windows.Forms.GroupBox();
            this.btn_EskiKur = new System.Windows.Forms.Button();
            this.textBox_gun = new System.Windows.Forms.TextBox();
            this.textBox_ay = new System.Windows.Forms.TextBox();
            this.textBox_yıl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_GuncelKur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxTarih.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "...";
            // 
            // gbxTarih
            // 
            this.gbxTarih.Controls.Add(this.label1);
            this.gbxTarih.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxTarih.Location = new System.Drawing.Point(590, 277);
            this.gbxTarih.Name = "gbxTarih";
            this.gbxTarih.Size = new System.Drawing.Size(121, 51);
            this.gbxTarih.TabIndex = 4;
            this.gbxTarih.TabStop = false;
            this.gbxTarih.Text = "Tarih";
            // 
            // btn_EskiKur
            // 
            this.btn_EskiKur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_EskiKur.Image = global::DovizKuru.Properties.Resources.ok;
            this.btn_EskiKur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EskiKur.Location = new System.Drawing.Point(162, 18);
            this.btn_EskiKur.Name = "btn_EskiKur";
            this.btn_EskiKur.Size = new System.Drawing.Size(139, 40);
            this.btn_EskiKur.TabIndex = 5;
            this.btn_EskiKur.Text = "Eski Kur Çek";
            this.btn_EskiKur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EskiKur.UseVisualStyleBackColor = true;
            this.btn_EskiKur.Click += new System.EventHandler(this.btn_EskiKur_Click);
            // 
            // textBox_gun
            // 
            this.textBox_gun.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_gun.Location = new System.Drawing.Point(19, 30);
            this.textBox_gun.Name = "textBox_gun";
            this.textBox_gun.Size = new System.Drawing.Size(23, 21);
            this.textBox_gun.TabIndex = 7;
            // 
            // textBox_ay
            // 
            this.textBox_ay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ay.Location = new System.Drawing.Point(66, 30);
            this.textBox_ay.Name = "textBox_ay";
            this.textBox_ay.Size = new System.Drawing.Size(23, 21);
            this.textBox_ay.TabIndex = 8;
            // 
            // textBox_yıl
            // 
            this.textBox_yıl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_yıl.Location = new System.Drawing.Point(113, 30);
            this.textBox_yıl.Name = "textBox_yıl";
            this.textBox_yıl.Size = new System.Drawing.Size(32, 21);
            this.textBox_yıl.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(93, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_gun);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_ay);
            this.groupBox1.Controls.Add(this.btn_EskiKur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_yıl);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 67);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Giriniz Gün/Ay/Yıl";
            // 
            // btn_GuncelKur
            // 
            this.btn_GuncelKur.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GuncelKur.Image = global::DovizKuru.Properties.Resources.ok;
            this.btn_GuncelKur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuncelKur.Location = new System.Drawing.Point(336, 277);
            this.btn_GuncelKur.Name = "btn_GuncelKur";
            this.btn_GuncelKur.Size = new System.Drawing.Size(221, 48);
            this.btn_GuncelKur.TabIndex = 14;
            this.btn_GuncelKur.Text = "Güncel Kur Çek";
            this.btn_GuncelKur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuncelKur.UseVisualStyleBackColor = true;
            this.btn_GuncelKur.Click += new System.EventHandler(this.btn_GuncelKur_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 249);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_GuncelKur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxTarih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KurBilgisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTarih.ResumeLayout(false);
            this.gbxTarih.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTarih;
        private System.Windows.Forms.Button btn_EskiKur;
        private System.Windows.Forms.TextBox textBox_gun;
        private System.Windows.Forms.TextBox textBox_ay;
        private System.Windows.Forms.TextBox textBox_yıl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GuncelKur;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

