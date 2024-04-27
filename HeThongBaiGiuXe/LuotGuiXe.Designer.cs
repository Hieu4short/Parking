namespace HeThongBaiGiuXe
{
    partial class LuotGuiXe
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
            this.buttonXuatBen = new System.Windows.Forms.Button();
            this.labelNhapBen = new System.Windows.Forms.Label();
            this.labelChoXeXuatBen = new System.Windows.Forms.Label();
            this.buttonNhapBen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonXuatBen
            // 
            this.buttonXuatBen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXuatBen.Location = new System.Drawing.Point(627, 415);
            this.buttonXuatBen.Name = "buttonXuatBen";
            this.buttonXuatBen.Size = new System.Drawing.Size(75, 23);
            this.buttonXuatBen.TabIndex = 8;
            this.buttonXuatBen.Text = "Xuất bến";
            this.buttonXuatBen.UseVisualStyleBackColor = true;
            this.buttonXuatBen.Click += new System.EventHandler(this.buttonXuatBen_Click);
            // 
            // labelNhapBen
            // 
            this.labelNhapBen.AutoSize = true;
            this.labelNhapBen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapBen.Location = new System.Drawing.Point(109, 397);
            this.labelNhapBen.Name = "labelNhapBen";
            this.labelNhapBen.Size = new System.Drawing.Size(96, 15);
            this.labelNhapBen.TabIndex = 5;
            this.labelNhapBen.Text = "Cho xe nhập bến";
            // 
            // labelChoXeXuatBen
            // 
            this.labelChoXeXuatBen.AutoSize = true;
            this.labelChoXeXuatBen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoXeXuatBen.Location = new System.Drawing.Point(620, 397);
            this.labelChoXeXuatBen.Name = "labelChoXeXuatBen";
            this.labelChoXeXuatBen.Size = new System.Drawing.Size(91, 15);
            this.labelChoXeXuatBen.TabIndex = 6;
            this.labelChoXeXuatBen.Text = "Cho xe xuất bến";
            // 
            // buttonNhapBen
            // 
            this.buttonNhapBen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhapBen.Location = new System.Drawing.Point(121, 415);
            this.buttonNhapBen.Name = "buttonNhapBen";
            this.buttonNhapBen.Size = new System.Drawing.Size(75, 23);
            this.buttonNhapBen.TabIndex = 3;
            this.buttonNhapBen.Text = "Nhập bến";
            this.buttonNhapBen.UseVisualStyleBackColor = true;
            this.buttonNhapBen.Click += new System.EventHandler(this.buttonNhapBen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 382);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 204);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(779, 156);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // LuotGuiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChoXeXuatBen);
            this.Controls.Add(this.labelNhapBen);
            this.Controls.Add(this.buttonXuatBen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonNhapBen);
            this.Name = "LuotGuiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lượt gửi xe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonNhapBen;
        private System.Windows.Forms.Label labelNhapBen;
        private System.Windows.Forms.Label labelChoXeXuatBen;
        private System.Windows.Forms.Button buttonXuatBen;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}