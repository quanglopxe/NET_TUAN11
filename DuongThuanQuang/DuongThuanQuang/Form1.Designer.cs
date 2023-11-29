namespace DuongThuanQuang
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
            this.btn_Xem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.dtgv_SP = new System.Windows.Forms.DataGridView();
            this.btn_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(42, 187);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(81, 34);
            this.btn_Xem.TabIndex = 0;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(152, 187);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 34);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(375, 187);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(81, 34);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(491, 187);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(81, 34);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(152, 35);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(178, 25);
            this.txt_MaSP.TabIndex = 2;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(152, 85);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(178, 25);
            this.txt_TenSP.TabIndex = 2;
            // 
            // dtgv_SP
            // 
            this.dtgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_SP.Location = new System.Drawing.Point(42, 243);
            this.dtgv_SP.Name = "dtgv_SP";
            this.dtgv_SP.Size = new System.Drawing.Size(530, 268);
            this.dtgv_SP.TabIndex = 3;
            this.dtgv_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_SP_CellClick);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(459, 35);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(113, 35);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 541);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dtgv_SP);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xem);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.DataGridView dtgv_SP;
        private System.Windows.Forms.Button btn_Logout;
    }
}

