namespace HeThongBaiGiuXe
{
    partial class DonGia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXem = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.labelTenLoaiXe = new System.Windows.Forms.Label();
            this.labelMaLoaiXe = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenLoaiXe = new System.Windows.Forms.TextBox();
            this.txtMaLoaiXe = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXem);
            this.panel1.Controls.Add(this.dateTimePickerToDate);
            this.panel1.Controls.Add(this.dateTimePickerFromDate);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 37);
            this.panel1.TabIndex = 2;
            // 
            // buttonXem
            // 
            this.buttonXem.Location = new System.Drawing.Point(458, 3);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(97, 23);
            this.buttonXem.TabIndex = 2;
            this.buttonXem.Text = "Xem thống kê";
            this.buttonXem.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(231, 3);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerToDate.TabIndex = 1;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerFromDate.TabIndex = 0;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(338, 403);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(102, 35);
            this.buttonCapNhat.TabIndex = 3;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDonGia);
            this.panel2.Controls.Add(this.labelTenLoaiXe);
            this.panel2.Controls.Add(this.labelMaLoaiXe);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.txtTenLoaiXe);
            this.panel2.Controls.Add(this.txtMaLoaiXe);
            this.panel2.Location = new System.Drawing.Point(12, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 96);
            this.panel2.TabIndex = 4;
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Location = new System.Drawing.Point(616, 15);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(44, 13);
            this.labelDonGia.TabIndex = 5;
            this.labelDonGia.Text = "Đơn giá";
            // 
            // labelTenLoaiXe
            // 
            this.labelTenLoaiXe.AutoSize = true;
            this.labelTenLoaiXe.Location = new System.Drawing.Point(350, 15);
            this.labelTenLoaiXe.Name = "labelTenLoaiXe";
            this.labelTenLoaiXe.Size = new System.Drawing.Size(59, 13);
            this.labelTenLoaiXe.TabIndex = 4;
            this.labelTenLoaiXe.Text = "Tên loại xe";
            // 
            // labelMaLoaiXe
            // 
            this.labelMaLoaiXe.AutoSize = true;
            this.labelMaLoaiXe.Location = new System.Drawing.Point(85, 15);
            this.labelMaLoaiXe.Name = "labelMaLoaiXe";
            this.labelMaLoaiXe.Size = new System.Drawing.Size(55, 13);
            this.labelMaLoaiXe.TabIndex = 3;
            this.labelMaLoaiXe.Text = "Mã loại xe";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(587, 34);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtTenLoaiXe
            // 
            this.txtTenLoaiXe.Location = new System.Drawing.Point(328, 34);
            this.txtTenLoaiXe.Name = "txtTenLoaiXe";
            this.txtTenLoaiXe.Size = new System.Drawing.Size(100, 20);
            this.txtTenLoaiXe.TabIndex = 1;
            // 
            // txtMaLoaiXe
            // 
            this.txtMaLoaiXe.Location = new System.Drawing.Point(58, 34);
            this.txtMaLoaiXe.Name = "txtMaLoaiXe";
            this.txtMaLoaiXe.Size = new System.Drawing.Size(100, 20);
            this.txtMaLoaiXe.TabIndex = 0;
            // 
            // DonGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DonGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn giá";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMaLoaiXe;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenLoaiXe;
        private System.Windows.Forms.TextBox txtMaLoaiXe;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.Label labelTenLoaiXe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}