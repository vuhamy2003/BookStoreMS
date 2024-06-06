namespace BTL.Forms
{
    partial class timkiemnv
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
            this.btndong = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.datanv = new System.Windows.Forms.DataGridView();
            this.cbocv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.cbomacv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datanv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "TÌM KIẾM NHÂN VIÊN";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(522, 174);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 38;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(522, 126);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(75, 23);
            this.btntimlai.TabIndex = 37;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(522, 75);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 36;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // datanv
            // 
            this.datanv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanv.Location = new System.Drawing.Point(217, 52);
            this.datanv.Name = "datanv";
            this.datanv.Size = new System.Drawing.Size(298, 172);
            this.datanv.TabIndex = 39;
            // 
            // cbocv
            // 
            this.cbocv.AutoSize = true;
            this.cbocv.Location = new System.Drawing.Point(12, 142);
            this.cbocv.Name = "cbocv";
            this.cbocv.Size = new System.Drawing.Size(58, 13);
            this.cbocv.TabIndex = 41;
            this.cbocv.Text = "Công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên nhân viên: ";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(92, 93);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(119, 20);
            this.txttennv.TabIndex = 42;
            // 
            // cbomacv
            // 
            this.cbomacv.FormattingEnabled = true;
            this.cbomacv.Location = new System.Drawing.Point(90, 139);
            this.cbomacv.Name = "cbomacv";
            this.cbomacv.Size = new System.Drawing.Size(121, 21);
            this.cbomacv.TabIndex = 43;
            // 
            // timkiemnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 251);
            this.Controls.Add(this.cbomacv);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.cbocv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datanv);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.label1);
            this.Name = "timkiemnv";
            this.Text = "Tìm kiếm nhân viên";
            this.Load += new System.EventHandler(this.timkiemnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datanv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.DataGridView datanv;
        private System.Windows.Forms.Label cbocv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.ComboBox cbomacv;
    }
}