namespace BTL.Forms
{
    partial class baocaokhachhang
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
            this.txtnam = new System.Windows.Forms.TextBox();
            this.cbothang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.databc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databc)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(364, 68);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(86, 23);
            this.btndong.TabIndex = 20;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(272, 67);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(86, 23);
            this.btnhienthi.TabIndex = 19;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(364, 36);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(86, 23);
            this.btnin.TabIndex = 18;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(272, 36);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(86, 23);
            this.btntao.TabIndex = 17;
            this.btntao.Text = "Tạo báo cáo";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(85, 70);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(121, 20);
            this.txtnam.TabIndex = 16;
            this.txtnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnam_KeyPress);
            // 
            // cbothang
            // 
            this.cbothang.FormattingEnabled = true;
            this.cbothang.Location = new System.Drawing.Point(85, 38);
            this.cbothang.Name = "cbothang";
            this.cbothang.Size = new System.Drawing.Size(121, 21);
            this.cbothang.TabIndex = 15;
            this.cbothang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbothang_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Năm: ";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tháng:";
            // 
            // databc
            // 
            this.databc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databc.Location = new System.Drawing.Point(34, 96);
            this.databc.Name = "databc";
            this.databc.Size = new System.Drawing.Size(416, 168);
            this.databc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "BÁO CÁO KHÁCH MUA NHIỀU";
            // 
            // baocaokhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 275);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.cbothang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.databc);
            this.Controls.Add(this.label1);
            this.Name = "baocaokhachhang";
            this.Text = "Báo cáo khách hàng mua nhiều nhất";
            this.Load += new System.EventHandler(this.baocaokhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.ComboBox cbothang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView databc;
        private System.Windows.Forms.Label label1;
    }
}