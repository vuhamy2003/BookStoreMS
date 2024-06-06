namespace BTL.Forms
{
    partial class timkiemsach
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
            this.datasach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btntk = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.cbols = new System.Windows.Forms.ComboBox();
            this.cbonxb = new System.Windows.Forms.ComboBox();
            this.txttens = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datasach)).BeginInit();
            this.SuspendLayout();
            // 
            // datasach
            // 
            this.datasach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasach.Location = new System.Drawing.Point(198, 59);
            this.datasach.Name = "datasach";
            this.datasach.Size = new System.Drawing.Size(316, 179);
            this.datasach.TabIndex = 0;
            //this.datasach.DoubleClick += new System.EventHandler(this.datasach_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "TÌM KIẾM SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên sách: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Loại sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "NXB: ";
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(520, 83);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 33;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(520, 134);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(75, 23);
            this.btntimlai.TabIndex = 34;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(520, 182);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 35;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // cbols
            // 
            this.cbols.FormattingEnabled = true;
            this.cbols.Location = new System.Drawing.Point(71, 136);
            this.cbols.Name = "cbols";
            this.cbols.Size = new System.Drawing.Size(121, 21);
            this.cbols.TabIndex = 37;
            // 
            // cbonxb
            // 
            this.cbonxb.FormattingEnabled = true;
            this.cbonxb.Location = new System.Drawing.Point(71, 184);
            this.cbonxb.Name = "cbonxb";
            this.cbonxb.Size = new System.Drawing.Size(121, 21);
            this.cbonxb.TabIndex = 38;
            // 
            // txttens
            // 
            this.txttens.Location = new System.Drawing.Point(71, 93);
            this.txttens.Name = "txttens";
            this.txttens.Size = new System.Drawing.Size(121, 20);
            this.txttens.TabIndex = 39;
            // 
            // timkiemsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 258);
            this.Controls.Add(this.txttens);
            this.Controls.Add(this.cbonxb);
            this.Controls.Add(this.cbols);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datasach);
            this.Name = "timkiemsach";
            this.Text = "Tìm kiếm sách";
            this.Load += new System.EventHandler(this.timkiemsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datasach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.ComboBox cbols;
        private System.Windows.Forms.ComboBox cbonxb;
        private System.Windows.Forms.TextBox txttens;
    }
}