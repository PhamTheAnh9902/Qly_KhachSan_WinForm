
namespace lamdatagridview
{
    partial class DichVuKS
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
            this.tblPhong = new System.Windows.Forms.DataGridView();
            this.tblDichvu = new System.Windows.Forms.DataGridView();
            this.btnThemP = new System.Windows.Forms.Button();
            this.btnSuaP = new System.Windows.Forms.Button();
            this.btnXoaP = new System.Windows.Forms.Button();
            this.MaPhong = new System.Windows.Forms.TextBox();
            this.loaiPhong = new System.Windows.Forms.TextBox();
            this.giaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MaDV = new System.Windows.Forms.TextBox();
            this.tenDV = new System.Windows.Forms.TextBox();
            this.giaDV = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPhong
            // 
            this.tblPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPhong.Location = new System.Drawing.Point(380, 64);
            this.tblPhong.Margin = new System.Windows.Forms.Padding(2);
            this.tblPhong.Name = "tblPhong";
            this.tblPhong.RowHeadersWidth = 51;
            this.tblPhong.RowTemplate.Height = 24;
            this.tblPhong.Size = new System.Drawing.Size(334, 150);
            this.tblPhong.TabIndex = 0;
            this.tblPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // tblDichvu
            // 
            this.tblDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDichvu.Location = new System.Drawing.Point(380, 317);
            this.tblDichvu.Margin = new System.Windows.Forms.Padding(2);
            this.tblDichvu.Name = "tblDichvu";
            this.tblDichvu.RowHeadersWidth = 51;
            this.tblDichvu.RowTemplate.Height = 24;
            this.tblDichvu.Size = new System.Drawing.Size(334, 138);
            this.tblDichvu.TabIndex = 1;
            this.tblDichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickDV);
            // 
            // btnThemP
            // 
            this.btnThemP.Location = new System.Drawing.Point(61, 188);
            this.btnThemP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemP.Name = "btnThemP";
            this.btnThemP.Size = new System.Drawing.Size(56, 25);
            this.btnThemP.TabIndex = 2;
            this.btnThemP.Text = "Thêm";
            this.btnThemP.UseVisualStyleBackColor = true;
            this.btnThemP.Click += new System.EventHandler(this.btnThemP_Click);
            // 
            // btnSuaP
            // 
            this.btnSuaP.Location = new System.Drawing.Point(158, 188);
            this.btnSuaP.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaP.Name = "btnSuaP";
            this.btnSuaP.Size = new System.Drawing.Size(56, 25);
            this.btnSuaP.TabIndex = 3;
            this.btnSuaP.Text = "Sửa";
            this.btnSuaP.UseVisualStyleBackColor = true;
            this.btnSuaP.Click += new System.EventHandler(this.btnSuaP_Click);
            // 
            // btnXoaP
            // 
            this.btnXoaP.Location = new System.Drawing.Point(248, 188);
            this.btnXoaP.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaP.Name = "btnXoaP";
            this.btnXoaP.Size = new System.Drawing.Size(56, 25);
            this.btnXoaP.TabIndex = 4;
            this.btnXoaP.Text = "Xóa";
            this.btnXoaP.UseVisualStyleBackColor = true;
            this.btnXoaP.Click += new System.EventHandler(this.btnXoaP_Click);
            // 
            // MaPhong
            // 
            this.MaPhong.Location = new System.Drawing.Point(166, 64);
            this.MaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Size = new System.Drawing.Size(116, 20);
            this.MaPhong.TabIndex = 5;
            // 
            // loaiPhong
            // 
            this.loaiPhong.Location = new System.Drawing.Point(166, 108);
            this.loaiPhong.Margin = new System.Windows.Forms.Padding(2);
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.Size = new System.Drawing.Size(116, 20);
            this.loaiPhong.TabIndex = 6;
            // 
            // giaPhong
            // 
            this.giaPhong.Location = new System.Drawing.Point(166, 148);
            this.giaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Size = new System.Drawing.Size(116, 20);
            this.giaPhong.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Danh Sách Phòng Và Dịch Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phòng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dịch Vụ Khác :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã DV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tên DV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 397);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Giá DV";
            // 
            // MaDV
            // 
            this.MaDV.Location = new System.Drawing.Point(158, 317);
            this.MaDV.Margin = new System.Windows.Forms.Padding(2);
            this.MaDV.Name = "MaDV";
            this.MaDV.Size = new System.Drawing.Size(130, 20);
            this.MaDV.TabIndex = 17;
            // 
            // tenDV
            // 
            this.tenDV.Location = new System.Drawing.Point(158, 356);
            this.tenDV.Margin = new System.Windows.Forms.Padding(2);
            this.tenDV.Name = "tenDV";
            this.tenDV.Size = new System.Drawing.Size(130, 20);
            this.tenDV.TabIndex = 18;
            // 
            // giaDV
            // 
            this.giaDV.Location = new System.Drawing.Point(158, 397);
            this.giaDV.Margin = new System.Windows.Forms.Padding(2);
            this.giaDV.Name = "giaDV";
            this.giaDV.Size = new System.Drawing.Size(130, 20);
            this.giaDV.TabIndex = 19;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(61, 436);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(56, 27);
            this.btnThemDV.TabIndex = 20;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Location = new System.Drawing.Point(158, 436);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(56, 27);
            this.btnSuaDV.TabIndex = 21;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Location = new System.Drawing.Point(248, 436);
            this.btnXoaDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(56, 27);
            this.btnXoaDV.TabIndex = 22;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // DichVuKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 497);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.giaDV);
            this.Controls.Add(this.tenDV);
            this.Controls.Add(this.MaDV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giaPhong);
            this.Controls.Add(this.loaiPhong);
            this.Controls.Add(this.MaPhong);
            this.Controls.Add(this.btnXoaP);
            this.Controls.Add(this.btnSuaP);
            this.Controls.Add(this.btnThemP);
            this.Controls.Add(this.tblDichvu);
            this.Controls.Add(this.tblPhong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DichVuKS";
            this.Text = "DichVuKS";
            this.Load += new System.EventHandler(this.DichVuKS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPhong;
        private System.Windows.Forms.DataGridView tblDichvu;
        private System.Windows.Forms.Button btnThemP;
        private System.Windows.Forms.Button btnSuaP;
        private System.Windows.Forms.Button btnXoaP;
        private System.Windows.Forms.TextBox MaPhong;
        private System.Windows.Forms.TextBox loaiPhong;
        private System.Windows.Forms.TextBox giaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MaDV;
        private System.Windows.Forms.TextBox tenDV;
        private System.Windows.Forms.TextBox giaDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDV;
    }
}