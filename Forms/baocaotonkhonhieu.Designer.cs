namespace BTL.Forms
{
    partial class baocaotonkhonhieu
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
            this.btndong = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btntao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.databc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.databc)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(361, 71);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 23);
            this.btndong.TabIndex = 20;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(269, 70);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(86, 23);
            this.btnhienthi.TabIndex = 19;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(361, 39);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(86, 23);
            this.btnin.TabIndex = 18;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(269, 39);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(86, 23);
            this.btntao.TabIndex = 17;
            this.btntao.Text = "Tạo báo cáo";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng tồn tối đa:";
            // 
            // databc
            // 
            this.databc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databc.Location = new System.Drawing.Point(31, 99);
            this.databc.Name = "databc";
            this.databc.Size = new System.Drawing.Size(416, 168);
            this.databc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "BÁO CÁO SÁCH VƯỢT MỨC TỒN KHO TỐI ĐA";
            // 
            // txtnhieu
            // 
            this.txtnhieu.Location = new System.Drawing.Point(137, 53);
            this.txtnhieu.Name = "txtnhieu";
            this.txtnhieu.Size = new System.Drawing.Size(121, 20);
            this.txtnhieu.TabIndex = 21;
            this.txtnhieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhieu_KeyPress);
            // 
            // baocaotonkhonhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 280);
            this.Controls.Add(this.txtnhieu);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.databc);
            this.Controls.Add(this.label1);
            this.Name = "baocaotonkhonhieu";
            this.Text = "Báo cáo sách vượt mức tồn kho tối đa";
            this.Load += new System.EventHandler(this.baocaotonkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView databc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhieu;
    }
}