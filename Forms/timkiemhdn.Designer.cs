namespace BTL.Forms
{
    partial class timkiemhdn
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
            this.cboncc = new System.Windows.Forms.ComboBox();
            this.cbonv = new System.Windows.Forms.ComboBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtshd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.datatkhd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datatkhd)).BeginInit();
            this.SuspendLayout();
            // 
            // cboncc
            // 
            this.cboncc.FormattingEnabled = true;
            this.cboncc.Location = new System.Drawing.Point(388, 42);
            this.cboncc.Name = "cboncc";
            this.cboncc.Size = new System.Drawing.Size(162, 21);
            this.cboncc.TabIndex = 73;
            // 
            // cbonv
            // 
            this.cbonv.FormattingEnabled = true;
            this.cbonv.Location = new System.Drawing.Point(135, 87);
            this.cbonv.Name = "cbonv";
            this.cbonv.Size = new System.Drawing.Size(162, 21);
            this.cbonv.TabIndex = 72;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(388, 64);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(162, 20);
            this.txttong.TabIndex = 71;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(230, 64);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(67, 20);
            this.txtnam.TabIndex = 70;
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(135, 64);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(48, 20);
            this.txtthang.TabIndex = 69;
            // 
            // txtshd
            // 
            this.txtshd.Location = new System.Drawing.Point(135, 43);
            this.txtshd.Name = "txtshd";
            this.txtshd.Size = new System.Drawing.Size(162, 20);
            this.txtshd.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Tổng tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "NCC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Số hóa đơn: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(52, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Kích đúp để hiển thị thông tin chi tiết.";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(406, 272);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 61;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(277, 272);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(75, 23);
            this.btntimlai.TabIndex = 60;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(140, 272);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 59;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // datatkhd
            // 
            this.datatkhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatkhd.Location = new System.Drawing.Point(55, 119);
            this.datatkhd.Name = "datatkhd";
            this.datatkhd.Size = new System.Drawing.Size(513, 135);
            this.datatkhd.TabIndex = 58;
            this.datatkhd.DoubleClick += new System.EventHandler(this.datatkhd_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN NHẬP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Năm:";
            // 
            // timkiemhdn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 302);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboncc);
            this.Controls.Add(this.cbonv);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.txtshd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.datatkhd);
            this.Controls.Add(this.label1);
            this.Name = "timkiemhdn";
            this.Text = "Tìm kiếm HDN";
            this.Load += new System.EventHandler(this.timkiemhdn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatkhd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboncc;
        private System.Windows.Forms.ComboBox cbonv;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtshd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.DataGridView datatkhd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}