
namespace lamdatagridview
{
    partial class KH_DV
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
            this.dataGridViewKH_DV = new System.Windows.Forms.DataGridView();
            this.comboBoxMaKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemDV = new System.Windows.Forms.Button();
            this.btnTatca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKH_DV
            // 
            this.dataGridViewKH_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH_DV.Location = new System.Drawing.Point(72, 152);
            this.dataGridViewKH_DV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKH_DV.Name = "dataGridViewKH_DV";
            this.dataGridViewKH_DV.RowHeadersWidth = 51;
            this.dataGridViewKH_DV.RowTemplate.Height = 24;
            this.dataGridViewKH_DV.Size = new System.Drawing.Size(451, 235);
            this.dataGridViewKH_DV.TabIndex = 0;
            // 
            // comboBoxMaKH
            // 
            this.comboBoxMaKH.FormattingEnabled = true;
            this.comboBoxMaKH.Items.AddRange(new object[] {
            "KH1",
            "KH2",
            "KH3",
            "KH4",
            "KH5"});
            this.comboBoxMaKH.Location = new System.Drawing.Point(182, 84);
            this.comboBoxMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMaKH.Name = "comboBoxMaKH";
            this.comboBoxMaKH.Size = new System.Drawing.Size(122, 21);
            this.comboBoxMaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn KH";
            // 
            // btnXemDV
            // 
            this.btnXemDV.Location = new System.Drawing.Point(342, 84);
            this.btnXemDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemDV.Name = "btnXemDV";
            this.btnXemDV.Size = new System.Drawing.Size(56, 25);
            this.btnXemDV.TabIndex = 3;
            this.btnXemDV.Text = "Xem";
            this.btnXemDV.UseVisualStyleBackColor = true;
            this.btnXemDV.Click += new System.EventHandler(this.btnXemDV_Click);
            // 
            // btnTatca
            // 
            this.btnTatca.Location = new System.Drawing.Point(80, 118);
            this.btnTatca.Margin = new System.Windows.Forms.Padding(2);
            this.btnTatca.Name = "btnTatca";
            this.btnTatca.Size = new System.Drawing.Size(56, 23);
            this.btnTatca.TabIndex = 4;
            this.btnTatca.Text = "Tất cả";
            this.btnTatca.UseVisualStyleBackColor = true;
            this.btnTatca.Click += new System.EventHandler(this.btnTatca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách khách hàng đặt dịch vụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Khởi tạo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KH_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTatca);
            this.Controls.Add(this.btnXemDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaKH);
            this.Controls.Add(this.dataGridViewKH_DV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KH_DV";
            this.Text = "KH_DV";
            this.Load += new System.EventHandler(this.KH_DV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH_DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKH_DV;
        private System.Windows.Forms.ComboBox comboBoxMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemDV;
        private System.Windows.Forms.Button btnTatca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}