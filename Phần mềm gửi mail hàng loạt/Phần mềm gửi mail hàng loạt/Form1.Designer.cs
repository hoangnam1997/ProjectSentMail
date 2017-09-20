namespace Phần_mềm_gửi_mail_hàng_loạt
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
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbAttack = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnSent = new System.Windows.Forms.Button();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(23, 52);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To :";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(23, 87);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 125);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Tên đăng nhập :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(23, 198);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật khẩu :";
            // 
            // txbAttack
            // 
            this.txbAttack.Location = new System.Drawing.Point(117, 12);
            this.txbAttack.Name = "txbAttack";
            this.txbAttack.ReadOnly = true;
            this.txbAttack.Size = new System.Drawing.Size(305, 20);
            this.txbAttack.TabIndex = 1;
            this.txbAttack.TabStop = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(433, 12);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(83, 23);
            this.btnAttack.TabIndex = 5;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(117, 52);
            this.txbTo.Name = "txbTo";
            this.txbTo.ReadOnly = true;
            this.txbTo.Size = new System.Drawing.Size(306, 20);
            this.txbTo.TabIndex = 0;
            // 
            // txbSubject
            // 
            this.txbSubject.Location = new System.Drawing.Point(117, 84);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(306, 20);
            this.txbSubject.TabIndex = 1;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(116, 118);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(306, 20);
            this.txbId.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(116, 153);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(306, 20);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(116, 198);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(75, 23);
            this.btnSent.TabIndex = 6;
            this.btnSent.Text = "Sent";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(26, 227);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(490, 170);
            this.txbMessage.TabIndex = 4;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(430, 52);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(86, 23);
            this.btnDanhSach.TabIndex = 7;
            this.btnDanhSach.Text = "Mail List";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(26, 403);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(315, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "https://www.google.com/settings/u/1/security/lesssecureapps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(348, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "cho phép để sử dụng theo dường link";
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(23, 12);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(29, 13);
            this.lblfile.TabIndex = 10;
            this.lblfile.Text = "File :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 433);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.txbSubject);
            this.Controls.Add(this.txbTo);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.txbAttack);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbAttack;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfile;
    }
}

