namespace BTL.Forms
{
    partial class danhmucncc
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
            this.mskdt = new System.Windows.Forms.MaskedTextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.datancc = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datancc)).BeginInit();
            this.SuspendLayout();
            // 
            // mskdt
            // 
            this.mskdt.Location = new System.Drawing.Point(341, 51);
            this.mskdt.Margin = new System.Windows.Forms.Padding(2);
            this.mskdt.Mask = "(999) 000-0000";
            this.mskdt.Name = "mskdt";
            this.mskdt.Size = new System.Drawing.Size(187, 20);
            this.mskdt.TabIndex = 32;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(341, 87);
            this.txtdc.Margin = new System.Windows.Forms.Padding(2);
            this.txtdc.Multiline = true;
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(187, 52);
            this.txtdc.TabIndex = 31;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(77, 87);
            this.txttenncc.Margin = new System.Windows.Forms.Padding(2);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(144, 20);
            this.txttenncc.TabIndex = 30;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(77, 51);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(2);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(144, 20);
            this.txtmancc.TabIndex = 29;
            // 
            // datancc
            // 
            this.datancc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datancc.Location = new System.Drawing.Point(11, 143);
            this.datancc.Margin = new System.Windows.Forms.Padding(2);
            this.datancc.Name = "datancc";
            this.datancc.RowHeadersWidth = 51;
            this.datancc.RowTemplate.Height = 24;
            this.datancc.Size = new System.Drawing.Size(517, 160);
            this.datancc.TabIndex = 28;
            this.datancc.Click += new System.EventHandler(this.datancc_Click);
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(459, 318);
            this.btndong.Margin = new System.Windows.Forms.Padding(2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(68, 28);
            this.btndong.TabIndex = 27;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(370, 318);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(68, 28);
            this.btnhuy.TabIndex = 26;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(280, 318);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(68, 28);
            this.btnxoa.TabIndex = 25;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(191, 318);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(68, 28);
            this.btnsua.TabIndex = 24;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(100, 318);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(68, 28);
            this.btnluu.TabIndex = 23;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(11, 318);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(68, 28);
            this.btnthem.TabIndex = 22;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên NCC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã NCC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "DANH MỤC NHÀ CUNG CẤP ";
            // 
            // danhmucncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 356);
            this.Controls.Add(this.mskdt);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.datancc);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "danhmucncc";
            this.Text = "Danh mục NCC";
            this.Load += new System.EventHandler(this.danhmucncc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datancc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.DataGridView datancc;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}