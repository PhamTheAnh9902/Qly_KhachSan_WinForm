
namespace lamdatagridview
{
    partial class DangKi
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
            this.tendn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mk = new System.Windows.Forms.TextBox();
            this.btnDK = new System.Windows.Forms.Button();
            this.btndn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng kí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // tendn
            // 
            this.tendn.Location = new System.Drawing.Point(202, 74);
            this.tendn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tendn.Name = "tendn";
            this.tendn.Size = new System.Drawing.Size(140, 20);
            this.tendn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu đăng nhập";
            // 
            // mk
            // 
            this.mk.Location = new System.Drawing.Point(202, 125);
            this.mk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(140, 20);
            this.mk.TabIndex = 4;
            // 
            // btnDK
            // 
            this.btnDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDK.Location = new System.Drawing.Point(69, 184);
            this.btnDK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(82, 34);
            this.btnDK.TabIndex = 5;
            this.btnDK.Text = "Đăng kí";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // btndn
            // 
            this.btndn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.Location = new System.Drawing.Point(171, 184);
            this.btndn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(115, 34);
            this.btndn.TabIndex = 6;
            this.btndn.Text = "Đăng nhập";
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 286);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tendn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DangKi";
            this.Text = "DangKi";
            this.Load += new System.EventHandler(this.DangKi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tendn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btndn;
    }
}