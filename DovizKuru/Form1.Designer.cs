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
            this.gbxTarih = new System.Windows.Forms.GroupBox();
            this.btn_EskiKur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_GuncelKur = new System.Windows.Forms.Button();
            this.dgwVeriler = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblAy = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxTarih.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTarih
            // 
            this.gbxTarih.Controls.Add(this.lblYil);
            this.gbxTarih.Controls.Add(this.label5);
            this.gbxTarih.Controls.Add(this.lblAy);
            this.gbxTarih.Controls.Add(this.lblGun);
            this.gbxTarih.Controls.Add(this.label4);
            this.gbxTarih.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxTarih.Location = new System.Drawing.Point(695, 324);
            this.gbxTarih.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTarih.Name = "gbxTarih";
            this.gbxTarih.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTarih.Size = new System.Drawing.Size(169, 63);
            this.gbxTarih.TabIndex = 4;
            this.gbxTarih.TabStop = false;
            this.gbxTarih.Text = "Tarih";
            // 
            // btn_EskiKur
            // 
            this.btn_EskiKur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EskiKur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_EskiKur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_EskiKur.Image = global::DovizKuru.Properties.Resources.ok;
            this.btn_EskiKur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EskiKur.Location = new System.Drawing.Point(172, 21);
            this.btn_EskiKur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EskiKur.Name = "btn_EskiKur";
            this.btn_EskiKur.Size = new System.Drawing.Size(192, 49);
            this.btn_EskiKur.TabIndex = 5;
            this.btn_EskiKur.Text = "Eski Kur Çek";
            this.btn_EskiKur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EskiKur.UseVisualStyleBackColor = true;
            this.btn_EskiKur.Click += new System.EventHandler(this.btn_EskiKur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(96, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_EskiKur);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 317);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(389, 80);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Seçiniz";
            // 
            // btn_GuncelKur
            // 
            this.btn_GuncelKur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuncelKur.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GuncelKur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_GuncelKur.Image = global::DovizKuru.Properties.Resources.ok;
            this.btn_GuncelKur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuncelKur.Location = new System.Drawing.Point(408, 328);
            this.btn_GuncelKur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuncelKur.Name = "btn_GuncelKur";
            this.btn_GuncelKur.Size = new System.Drawing.Size(279, 59);
            this.btn_GuncelKur.TabIndex = 14;
            this.btn_GuncelKur.Text = "Güncel Kur Çek";
            this.btn_GuncelKur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuncelKur.UseVisualStyleBackColor = true;
            this.btn_GuncelKur.Click += new System.EventHandler(this.btn_GuncelKur_Click);
            // 
            // dgwVeriler
            // 
            this.dgwVeriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVeriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwVeriler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwVeriler.Location = new System.Drawing.Point(5, 5);
            this.dgwVeriler.Margin = new System.Windows.Forms.Padding(4);
            this.dgwVeriler.Name = "dgwVeriler";
            this.dgwVeriler.Size = new System.Drawing.Size(1005, 306);
            this.dgwVeriler.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 31);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 10, 28, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 30);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2020, 10, 25, 23, 59, 59, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGun.Location = new System.Drawing.Point(18, 27);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(25, 23);
            this.lblGun.TabIndex = 17;
            this.lblGun.Text = "...";
            // 
            // lblAy
            // 
            this.lblAy.AutoSize = true;
            this.lblAy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAy.Location = new System.Drawing.Point(67, 27);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(25, 23);
            this.lblAy.TabIndex = 18;
            this.lblAy.Text = "...";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYil.Location = new System.Drawing.Point(120, 27);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(25, 23);
            this.lblYil.TabIndex = 19;
            this.lblYil.Text = "...";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(889, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxTarih);
            this.Controls.Add(this.dgwVeriler);
            this.Controls.Add(this.btn_GuncelKur);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Döviz/Kur ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTarih.ResumeLayout(false);
            this.gbxTarih.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVeriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxTarih;
        private System.Windows.Forms.Button btn_EskiKur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GuncelKur;
        private System.Windows.Forms.DataGridView dgwVeriler;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Button button1;
    }
}

