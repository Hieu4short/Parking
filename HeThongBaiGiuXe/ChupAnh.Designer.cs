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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 281);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMoCamera
            // 
            this.buttonMoCamera.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoCamera.Location = new System.Drawing.Point(59, 369);
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
            this.buttonDungLai.Location = new System.Drawing.Point(357, 369);
            this.buttonDungLai.Name = "buttonDungLai";
            this.buttonDungLai.Size = new System.Drawing.Size(92, 24);
            this.buttonDungLai.TabIndex = 2;
            this.buttonDungLai.Text = "Dừng lại";
            this.buttonDungLai.UseVisualStyleBackColor = true;
            this.buttonDungLai.Click += new System.EventHandler(this.buttonDongY_Click);
            // 
            // comboBoxVideoSource
            // 
            this.comboBoxVideoSource.FormattingEnabled = true;
            this.comboBoxVideoSource.Location = new System.Drawing.Point(47, 342);
            this.comboBoxVideoSource.Name = "comboBoxVideoSource";
            this.comboBoxVideoSource.Size = new System.Drawing.Size(115, 21);
            this.comboBoxVideoSource.TabIndex = 3;
            // 
            // buttonLuuHinhAnh
            // 
            this.buttonLuuHinhAnh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuuHinhAnh.Location = new System.Drawing.Point(616, 369);
            this.buttonLuuHinhAnh.Name = "buttonLuuHinhAnh";
            this.buttonLuuHinhAnh.Size = new System.Drawing.Size(95, 23);
            this.buttonLuuHinhAnh.TabIndex = 4;
            this.buttonLuuHinhAnh.Text = "Lưu hình ảnh";
            this.buttonLuuHinhAnh.UseVisualStyleBackColor = true;
            this.buttonLuuHinhAnh.Click += new System.EventHandler(this.buttonLuuHinhAnh_Click);
            // 
            // ChupAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMoCamera;
        private System.Windows.Forms.Button buttonDungLai;
        private System.Windows.Forms.ComboBox comboBoxVideoSource;
        private System.Windows.Forms.Button buttonLuuHinhAnh;
    }
}