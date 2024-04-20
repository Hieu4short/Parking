namespace HeThongBaiGiuXe
{
    partial class TheGuiXe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTrangThaiThe = new System.Windows.Forms.Label();
            this.labelTinhTrangThe = new System.Windows.Forms.Label();
            this.labelMaSoThe = new System.Windows.Forms.Label();
            this.txtTinhTrangThe = new System.Windows.Forms.TextBox();
            this.txtTrangThaiThe = new System.Windows.Forms.TextBox();
            this.txtMaSoThe = new System.Windows.Forms.TextBox();
            this.buttonThemThe = new System.Windows.Forms.Button();
            this.buttonXoaThe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 50);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTrangThaiThe);
            this.panel2.Controls.Add(this.labelTinhTrangThe);
            this.panel2.Controls.Add(this.labelMaSoThe);
            this.panel2.Controls.Add(this.txtTinhTrangThe);
            this.panel2.Controls.Add(this.txtTrangThaiThe);
            this.panel2.Controls.Add(this.txtMaSoThe);
            this.panel2.Location = new System.Drawing.Point(4, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 84);
            this.panel2.TabIndex = 1;
            // 
            // labelTrangThaiThe
            // 
            this.labelTrangThaiThe.AutoSize = true;
            this.labelTrangThaiThe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThaiThe.Location = new System.Drawing.Point(329, 12);
            this.labelTrangThaiThe.Name = "labelTrangThaiThe";
            this.labelTrangThaiThe.Size = new System.Drawing.Size(89, 17);
            this.labelTrangThaiThe.TabIndex = 6;
            this.labelTrangThaiThe.Text = "Trạng thái thẻ";
            // 
            // labelTinhTrangThe
            // 
            this.labelTinhTrangThe.AutoSize = true;
            this.labelTinhTrangThe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTinhTrangThe.Location = new System.Drawing.Point(578, 12);
            this.labelTinhTrangThe.Name = "labelTinhTrangThe";
            this.labelTinhTrangThe.Size = new System.Drawing.Size(90, 17);
            this.labelTinhTrangThe.TabIndex = 5;
            this.labelTinhTrangThe.Text = "Tình trạng thẻ";
            // 
            // labelMaSoThe
            // 
            this.labelMaSoThe.AutoSize = true;
            this.labelMaSoThe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSoThe.Location = new System.Drawing.Point(112, 12);
            this.labelMaSoThe.Name = "labelMaSoThe";
            this.labelMaSoThe.Size = new System.Drawing.Size(67, 17);
            this.labelMaSoThe.TabIndex = 3;
            this.labelMaSoThe.Text = "Mã số thẻ";
            // 
            // txtTinhTrangThe
            // 
            this.txtTinhTrangThe.Location = new System.Drawing.Point(567, 32);
            this.txtTinhTrangThe.Name = "txtTinhTrangThe";
            this.txtTinhTrangThe.Size = new System.Drawing.Size(114, 20);
            this.txtTinhTrangThe.TabIndex = 2;
            // 
            // txtTrangThaiThe
            // 
            this.txtTrangThaiThe.Location = new System.Drawing.Point(332, 32);
            this.txtTrangThaiThe.Name = "txtTrangThaiThe";
            this.txtTrangThaiThe.Size = new System.Drawing.Size(100, 20);
            this.txtTrangThaiThe.TabIndex = 1;
            // 
            // txtMaSoThe
            // 
            this.txtMaSoThe.Location = new System.Drawing.Point(94, 32);
            this.txtMaSoThe.Name = "txtMaSoThe";
            this.txtMaSoThe.Size = new System.Drawing.Size(100, 20);
            this.txtMaSoThe.TabIndex = 0;
            // 
            // buttonThemThe
            // 
            this.buttonThemThe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemThe.Location = new System.Drawing.Point(298, 402);
            this.buttonThemThe.Name = "buttonThemThe";
            this.buttonThemThe.Size = new System.Drawing.Size(110, 30);
            this.buttonThemThe.TabIndex = 2;
            this.buttonThemThe.Text = "Thêm thẻ";
            this.buttonThemThe.UseVisualStyleBackColor = true;
            this.buttonThemThe.Click += new System.EventHandler(this.buttonThemThe_Click);
            // 
            // buttonXoaThe
            // 
            this.buttonXoaThe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaThe.Location = new System.Drawing.Point(439, 402);
            this.buttonXoaThe.Name = "buttonXoaThe";
            this.buttonXoaThe.Size = new System.Drawing.Size(111, 30);
            this.buttonXoaThe.TabIndex = 3;
            this.buttonXoaThe.Text = "Xóa thẻ";
            this.buttonXoaThe.UseVisualStyleBackColor = true;
            this.buttonXoaThe.Click += new System.EventHandler(this.buttonXoaThe_Click);
            // 
            // TheGuiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonXoaThe);
            this.Controls.Add(this.buttonThemThe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "TheGuiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thẻ gửi xe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonThemThe;
        private System.Windows.Forms.Button buttonXoaThe;
        private System.Windows.Forms.TextBox txtTinhTrangThe;
        private System.Windows.Forms.TextBox txtTrangThaiThe;
        private System.Windows.Forms.TextBox txtMaSoThe;
        private System.Windows.Forms.Label labelTinhTrangThe;
        private System.Windows.Forms.Label labelMaSoThe;
        private System.Windows.Forms.Label labelTrangThaiThe;
    }
}