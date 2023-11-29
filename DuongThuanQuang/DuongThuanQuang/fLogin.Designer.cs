namespace DuongThuanQuang
{
    partial class fLogin
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.rbtn_Remember = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(178, 57);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(175, 25);
            this.txt_UserName.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(109, 194);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(101, 32);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(178, 111);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(175, 25);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(238, 194);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(104, 32);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // rbtn_Remember
            // 
            this.rbtn_Remember.AutoSize = true;
            this.rbtn_Remember.Location = new System.Drawing.Point(234, 156);
            this.rbtn_Remember.Name = "rbtn_Remember";
            this.rbtn_Remember.Size = new System.Drawing.Size(119, 22);
            this.rbtn_Remember.TabIndex = 3;
            this.rbtn_Remember.TabStop = true;
            this.rbtn_Remember.Text = "Nhớ mật khẩu";
            this.rbtn_Remember.UseVisualStyleBackColor = true;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 392);
            this.Controls.Add(this.rbtn_Remember);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fLogin";
            this.Text = "fLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.RadioButton rbtn_Remember;
    }
}