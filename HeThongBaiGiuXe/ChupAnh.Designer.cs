namespace HeThongBaiGiuXe
{
    partial class ChupAnh
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMoCamera = new System.Windows.Forms.Button();
            this.buttonDungLai = new System.Windows.Forms.Button();
            this.comboBoxVideoSource = new System.Windows.Forms.ComboBox();
            this.buttonLuuHinhAnh = new System.Windows.Forms.Button();
            this.labelLoaiXe = new System.Windows.Forms.Label();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.labelDinhDanhXe = new System.Windows.Forms.Label();
            this.cbIDTheGuiXe = new System.Windows.Forms.ComboBox();
            this.labelIDTheGuiXe = new System.Windows.Forms.Label();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.labelThoiGianNhanXe = new System.Windows.Forms.Label();
            this.labelThoiGianTraXe = new System.Windows.Forms.Label();
            this.txtDinhDanhXe = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtThoiGianNhanXe = new System.Windows.Forms.TextBox();
            this.txtThoiGianTraXe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(246, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMoCamera
            // 
            this.buttonMoCamera.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoCamera.Location = new System.Drawing.Point(153, 402);
            this.buttonMoCamera.Name = "buttonMoCamera";
            this.buttonMoCamera.Size = new System.Drawing.Size(92, 24);
            this.buttonMoCamera.TabIndex = 1;
            this.buttonMoCamera.Text = "Mở camera";
            this.buttonMoCamera.UseVisualStyleBackColor = true;
            this.buttonMoCamera.Click += new System.EventHandler(this.buttonChupBienSo_Click);
            // 
            // buttonDungLai
            // 
            this.buttonDungLai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDungLai.Location = new System.Drawing.Point(261, 402);
            this.buttonDungLai.Name = "buttonDungLai";
            this.buttonDungLai.Size = new System.Drawing.Size(92, 24);
            this.buttonDungLai.TabIndex = 2;
            this.buttonDungLai.Text = "Chụp ảnh";
            this.buttonDungLai.UseVisualStyleBackColor = true;
            this.buttonDungLai.Click += new System.EventHandler(this.buttonDongY_Click);
            // 
            // comboBoxVideoSource
            // 
            this.comboBoxVideoSource.FormattingEnabled = true;
            this.comboBoxVideoSource.Location = new System.Drawing.Point(15, 402);
            this.comboBoxVideoSource.Name = "comboBoxVideoSource";
            this.comboBoxVideoSource.Size = new System.Drawing.Size(115, 21);
            this.comboBoxVideoSource.TabIndex = 3;
            // 
            // buttonLuuHinhAnh
            // 
            this.buttonLuuHinhAnh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuuHinhAnh.Location = new System.Drawing.Point(680, 403);
            this.buttonLuuHinhAnh.Name = "buttonLuuHinhAnh";
            this.buttonLuuHinhAnh.Size = new System.Drawing.Size(95, 23);
            this.buttonLuuHinhAnh.TabIndex = 4;
            this.buttonLuuHinhAnh.Text = "Nhận xe";
            this.buttonLuuHinhAnh.UseVisualStyleBackColor = true;
            this.buttonLuuHinhAnh.Click += new System.EventHandler(this.buttonLuuHinhAnh_Click);
            // 
            // labelLoaiXe
            // 
            this.labelLoaiXe.AutoSize = true;
            this.labelLoaiXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiXe.Location = new System.Drawing.Point(57, 40);
            this.labelLoaiXe.Name = "labelLoaiXe";
            this.labelLoaiXe.Size = new System.Drawing.Size(44, 15);
            this.labelLoaiXe.TabIndex = 5;
            this.labelLoaiXe.Text = "Loại xe";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Xe máy",
            "Xe đạp"});
            this.cbLoaiXe.Location = new System.Drawing.Point(129, 38);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(93, 21);
            this.cbLoaiXe.TabIndex = 6;
            // 
            // labelDinhDanhXe
            // 
            this.labelDinhDanhXe.AutoSize = true;
            this.labelDinhDanhXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDinhDanhXe.Location = new System.Drawing.Point(24, 81);
            this.labelDinhDanhXe.Name = "labelDinhDanhXe";
            this.labelDinhDanhXe.Size = new System.Drawing.Size(77, 15);
            this.labelDinhDanhXe.TabIndex = 7;
            this.labelDinhDanhXe.Text = "Định danh xe";
            // 
            // cbIDTheGuiXe
            // 
            this.cbIDTheGuiXe.FormattingEnabled = true;
            this.cbIDTheGuiXe.Location = new System.Drawing.Point(129, 130);
            this.cbIDTheGuiXe.Name = "cbIDTheGuiXe";
            this.cbIDTheGuiXe.Size = new System.Drawing.Size(93, 21);
            this.cbIDTheGuiXe.TabIndex = 15;
            // 
            // labelIDTheGuiXe
            // 
            this.labelIDTheGuiXe.AutoSize = true;
            this.labelIDTheGuiXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDTheGuiXe.Location = new System.Drawing.Point(27, 132);
            this.labelIDTheGuiXe.Name = "labelIDTheGuiXe";
            this.labelIDTheGuiXe.Size = new System.Drawing.Size(74, 15);
            this.labelIDTheGuiXe.TabIndex = 16;
            this.labelIDTheGuiXe.Text = "ID thẻ gửi xe";
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThai.Location = new System.Drawing.Point(39, 182);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(60, 20);
            this.labelTrangThai.TabIndex = 17;
            this.labelTrangThai.Text = "Trạng thái";
            this.labelTrangThai.UseCompatibleTextRendering = true;
            this.labelTrangThai.Visible = false;
            // 
            // labelThoiGianNhanXe
            // 
            this.labelThoiGianNhanXe.AutoSize = true;
            this.labelThoiGianNhanXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoiGianNhanXe.Location = new System.Drawing.Point(-1, 226);
            this.labelThoiGianNhanXe.Name = "labelThoiGianNhanXe";
            this.labelThoiGianNhanXe.Size = new System.Drawing.Size(102, 15);
            this.labelThoiGianNhanXe.TabIndex = 18;
            this.labelThoiGianNhanXe.Text = "Thời gian nhận xe";
            this.labelThoiGianNhanXe.Visible = false;
            this.labelThoiGianNhanXe.Click += new System.EventHandler(this.labelThoiGianNhanXe_Click);
            // 
            // labelThoiGianTraXe
            // 
            this.labelThoiGianTraXe.AutoSize = true;
            this.labelThoiGianTraXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoiGianTraXe.Location = new System.Drawing.Point(12, 271);
            this.labelThoiGianTraXe.Name = "labelThoiGianTraXe";
            this.labelThoiGianTraXe.Size = new System.Drawing.Size(89, 15);
            this.labelThoiGianTraXe.TabIndex = 19;
            this.labelThoiGianTraXe.Text = "Thời gian trả xe";
            this.labelThoiGianTraXe.Visible = false;
            // 
            // txtDinhDanhXe
            // 
            this.txtDinhDanhXe.Location = new System.Drawing.Point(129, 79);
            this.txtDinhDanhXe.Name = "txtDinhDanhXe";
            this.txtDinhDanhXe.Size = new System.Drawing.Size(93, 20);
            this.txtDinhDanhXe.TabIndex = 20;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(129, 180);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(93, 20);
            this.txtTrangThai.TabIndex = 21;
            this.txtTrangThai.Visible = false;
            // 
            // txtThoiGianNhanXe
            // 
            this.txtThoiGianNhanXe.Location = new System.Drawing.Point(129, 224);
            this.txtThoiGianNhanXe.Name = "txtThoiGianNhanXe";
            this.txtThoiGianNhanXe.Size = new System.Drawing.Size(93, 20);
            this.txtThoiGianNhanXe.TabIndex = 22;
            this.txtThoiGianNhanXe.Visible = false;
            // 
            // txtThoiGianTraXe
            // 
            this.txtThoiGianTraXe.Location = new System.Drawing.Point(129, 266);
            this.txtThoiGianTraXe.Name = "txtThoiGianTraXe";
            this.txtThoiGianTraXe.Size = new System.Drawing.Size(93, 20);
            this.txtThoiGianTraXe.TabIndex = 23;
            this.txtThoiGianTraXe.Visible = false;
            // 
            // ChupAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtThoiGianTraXe);
            this.Controls.Add(this.txtThoiGianNhanXe);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtDinhDanhXe);
            this.Controls.Add(this.labelThoiGianTraXe);
            this.Controls.Add(this.labelThoiGianNhanXe);
            this.Controls.Add(this.labelTrangThai);
            this.Controls.Add(this.labelIDTheGuiXe);
            this.Controls.Add(this.cbIDTheGuiXe);
            this.Controls.Add(this.labelDinhDanhXe);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.labelLoaiXe);
            this.Controls.Add(this.buttonLuuHinhAnh);
            this.Controls.Add(this.comboBoxVideoSource);
            this.Controls.Add(this.buttonDungLai);
            this.Controls.Add(this.buttonMoCamera);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChupAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chụp Ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMoCamera;
        private System.Windows.Forms.Button buttonDungLai;
        private System.Windows.Forms.ComboBox comboBoxVideoSource;
        private System.Windows.Forms.Button buttonLuuHinhAnh;
        private System.Windows.Forms.Label labelLoaiXe;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.Label labelDinhDanhXe;
        private System.Windows.Forms.ComboBox cbIDTheGuiXe;
        private System.Windows.Forms.Label labelIDTheGuiXe;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.Label labelThoiGianNhanXe;
        private System.Windows.Forms.Label labelThoiGianTraXe;
        private System.Windows.Forms.TextBox txtDinhDanhXe;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtThoiGianNhanXe;
        private System.Windows.Forms.TextBox txtThoiGianTraXe;
    }
}