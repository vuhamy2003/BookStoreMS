namespace BTL.Forms
{
    partial class timkiemhdb
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
            this.label1 = new System.Windows.Forms.Label();
            this.datatkhd = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtshd = new System.Windows.Forms.TextBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.cbonv = new System.Windows.Forms.ComboBox();
            this.cbokh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datatkhd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            // 
            // datatkhd
            // 
            this.datatkhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatkhd.Location = new System.Drawing.Point(62, 120);
            this.datatkhd.Name = "datatkhd";
            this.datatkhd.Size = new System.Drawing.Size(513, 135);
            this.datatkhd.TabIndex = 32;
            this.datatkhd.DoubleClick += new System.EventHandler(this.datatkhd_DoubleClick);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(413, 273);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 41;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(284, 273);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(75, 23);
            this.btntimlai.TabIndex = 40;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(147, 273);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 39;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(59, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Kích đúp để hiển thị thông tin chi tiết.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số hóa đơn: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tháng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Năm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Khách hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tổng tiền:";
            // 
            // txtshd
            // 
            this.txtshd.Location = new System.Drawing.Point(142, 44);
            this.txtshd.Name = "txtshd";
            this.txtshd.Size = new System.Drawing.Size(162, 20);
            this.txtshd.TabIndex = 49;
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(142, 65);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(48, 20);
            this.txtthang.TabIndex = 50;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(237, 65);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(67, 20);
            this.txtnam.TabIndex = 51;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(395, 65);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(162, 20);
            this.txttong.TabIndex = 54;
            // 
            // cbonv
            // 
            this.cbonv.FormattingEnabled = true;
            this.cbonv.Location = new System.Drawing.Point(142, 88);
            this.cbonv.Name = "cbonv";
            this.cbonv.Size = new System.Drawing.Size(162, 21);
            this.cbonv.TabIndex = 55;
            // 
            // cbokh
            // 
            this.cbokh.FormattingEnabled = true;
            this.cbokh.Location = new System.Drawing.Point(395, 43);
            this.cbokh.Name = "cbokh";
            this.cbokh.Size = new System.Drawing.Size(162, 21);
            this.cbokh.TabIndex = 56;
            // 
            // timkiemhdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 304);
            this.Controls.Add(this.cbokh);
            this.Controls.Add(this.cbonv);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.txtshd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.datatkhd);
            this.Controls.Add(this.label1);
            this.Name = "timkiemhdb";
            this.Text = "Tìm kiếm HDB";
            this.Load += new System.EventHandler(this.timkiemhdb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatkhd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datatkhd;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtshd;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.ComboBox cbonv;
        private System.Windows.Forms.ComboBox cbokh;
    }
}