namespace BTL.Forms
{
    partial class danhmucnv
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
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.datanv = new System.Windows.Forms.DataGridView();
            this.cbocv = new System.Windows.Forms.ComboBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datanv)).BeginInit();
            this.SuspendLayout();
            // 
            // mskdt
            // 
            this.mskdt.Location = new System.Drawing.Point(379, 42);
            this.mskdt.Margin = new System.Windows.Forms.Padding(2);
            this.mskdt.Mask = "(999) 000-0000";
            this.mskdt.Name = "mskdt";
            this.mskdt.Size = new System.Drawing.Size(180, 20);
            this.mskdt.TabIndex = 36;
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(379, 79);
            this.txtdc.Margin = new System.Windows.Forms.Padding(2);
            this.txtdc.Multiline = true;
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(180, 55);
            this.txtdc.TabIndex = 34;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(97, 79);
            this.txttennv.Margin = new System.Windows.Forms.Padding(2);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(158, 20);
            this.txttennv.TabIndex = 33;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(97, 43);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(2);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(158, 20);
            this.txtmanv.TabIndex = 32;
            // 
            // datanv
            // 
            this.datanv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanv.Location = new System.Drawing.Point(9, 147);
            this.datanv.Margin = new System.Windows.Forms.Padding(2);
            this.datanv.Name = "datanv";
            this.datanv.RowHeadersWidth = 51;
            this.datanv.RowTemplate.Height = 24;
            this.datanv.Size = new System.Drawing.Size(549, 163);
            this.datanv.TabIndex = 31;
            this.datanv.Click += new System.EventHandler(this.datanv_Click);
            // 
            // cbocv
            // 
            this.cbocv.FormattingEnabled = true;
            this.cbocv.Location = new System.Drawing.Point(97, 114);
            this.cbocv.Margin = new System.Windows.Forms.Padding(2);
            this.cbocv.Name = "cbocv";
            this.cbocv.Size = new System.Drawing.Size(158, 21);
            this.cbocv.TabIndex = 35;
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndong.Location = new System.Drawing.Point(487, 326);
            this.btndong.Margin = new System.Windows.Forms.Padding(2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(71, 31);
            this.btndong.TabIndex = 30;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(391, 326);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(71, 31);
            this.btnhuy.TabIndex = 29;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(296, 326);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(71, 31);
            this.btnxoa.TabIndex = 28;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(201, 326);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(71, 31);
            this.btnsua.TabIndex = 27;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(104, 326);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(71, 31);
            this.btnluu.TabIndex = 26;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(9, 326);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(71, 31);
            this.btnthem.TabIndex = 25;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "DANH MỤC NHÂN VIÊN ";
            // 
            // danhmucnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 366);
            this.Controls.Add(this.mskdt);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.datanv);
            this.Controls.Add(this.cbocv);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "danhmucnv";
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.danhmucnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datanv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.DataGridView datanv;
        private System.Windows.Forms.ComboBox cbocv;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}