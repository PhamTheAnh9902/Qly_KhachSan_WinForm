
namespace lamdatagridview
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maNV = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.soDT = new System.Windows.Forms.TextBox();
            this.hsl = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bnTK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txthsl = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma
            // 
            this.ma.AutoSize = true;
            this.ma.Location = new System.Drawing.Point(39, 13);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(40, 13);
            this.ma.TabIndex = 1;
            this.ma.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // maNV
            // 
            this.maNV.Location = new System.Drawing.Point(95, 12);
            this.maNV.Name = "maNV";
            this.maNV.Size = new System.Drawing.Size(188, 20);
            this.maNV.TabIndex = 5;
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(365, 12);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(138, 20);
            this.hoten.TabIndex = 7;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(365, 64);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(138, 20);
            this.diachi.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm NV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số ĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "HSL";
            // 
            // soDT
            // 
            this.soDT.Location = new System.Drawing.Point(617, 17);
            this.soDT.Name = "soDT";
            this.soDT.Size = new System.Drawing.Size(144, 20);
            this.soDT.TabIndex = 12;
            this.soDT.Validating += new System.ComponentModel.CancelEventHandler(this.soDT_Validating);
            // 
            // hsl
            // 
            this.hsl.Location = new System.Drawing.Point(977, 38);
            this.hsl.Name = "hsl";
            this.hsl.Size = new System.Drawing.Size(144, 20);
            this.hsl.TabIndex = 13;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(242, 129);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(379, 128);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(515, 128);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 24);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Report";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(636, 127);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 17;
            this.btnRestart.Text = "Làm mới";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(95, 65);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(188, 20);
            this.ngaysinh.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tìm kiếm nhân viên theo độ tuổi ";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Items.AddRange(new object[] {
            "NV1",
            "NV2",
            "NV3",
            "NV4",
            "NV5"});
            this.cbMaNV.Location = new System.Drawing.Point(717, 414);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(164, 21);
            this.cbMaNV.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(60, 507);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(651, 91);
            this.dataGridView2.TabIndex = 21;
            // 
            // bnTK
            // 
            this.bnTK.Location = new System.Drawing.Point(428, 453);
            this.bnTK.Name = "bnTK";
            this.bnTK.Size = new System.Drawing.Size(75, 32);
            this.bnTK.TabIndex = 22;
            this.bnTK.Text = "Tìm kiếm";
            this.bnTK.UseVisualStyleBackColor = true;
            this.bnTK.Click += new System.EventHandler(this.bnTK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Danh sách nhân viên";
            // 
            // txthsl
            // 
            this.txthsl.Location = new System.Drawing.Point(617, 65);
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(144, 20);
            this.txthsl.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 458);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(950, 619);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txthsl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bnTK);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.hsl);
            this.Controls.Add(this.soDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.maNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maNV;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox diachi;
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soDT;
        private System.Windows.Forms.TextBox hsl;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bnTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthsl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

