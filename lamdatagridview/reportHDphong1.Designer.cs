
namespace lamdatagridview
{
    partial class reportHDphong1
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
            this.comboxMaKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loc = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxMaKH
            // 
            this.comboxMaKH.FormattingEnabled = true;
            this.comboxMaKH.Items.AddRange(new object[] {
            "KH1",
            "KH2",
            "KH3",
            "KH4"});
            this.comboxMaKH.Location = new System.Drawing.Point(157, 57);
            this.comboxMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboxMaKH.Name = "comboxMaKH";
            this.comboxMaKH.Size = new System.Drawing.Size(153, 21);
            this.comboxMaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khách hàng";
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(341, 57);
            this.btn_loc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(63, 21);
            this.btn_loc.TabIndex = 4;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(442, 58);
            this.btn_in.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(91, 21);
            this.btn_in.TabIndex = 5;
            this.btn_in.Text = "In báo cáo";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 171);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hóa đơn phòng";
            // 
            // reportHDphong1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxMaKH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "reportHDphong1";
            this.Load += new System.EventHandler(this.reportHDphong1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboxMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}