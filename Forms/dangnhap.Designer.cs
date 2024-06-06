namespace BTL.Forms
{
    partial class dangnhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndn = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.lbltb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // btndn
            // 
            this.btndn.Location = new System.Drawing.Point(202, 125);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(75, 23);
            this.btndn.TabIndex = 3;
            this.btndn.Text = "Đăng nhập";
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(283, 125);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(103, 54);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(217, 20);
            this.txttk.TabIndex = 5;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(103, 80);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(217, 20);
            this.txtmk.TabIndex = 6;
            // 
            // lbltb
            // 
            this.lbltb.AutoSize = true;
            this.lbltb.Location = new System.Drawing.Point(39, 113);
            this.lbltb.Name = "lbltb";
            this.lbltb.Size = new System.Drawing.Size(0, 13);
            this.lbltb.TabIndex = 7;
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources.MY_HUYỀN_MY_BOOKS;
            this.ClientSize = new System.Drawing.Size(370, 160);
            this.Controls.Add(this.lbltb);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label lbltb;
    }
}