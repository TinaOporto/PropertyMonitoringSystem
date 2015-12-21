namespace PropertyMonitoringSystem
{
    partial class LoginForm
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
            this.group_login = new System.Windows.Forms.GroupBox();
            this.checkBox_sp = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pword = new System.Windows.Forms.TextBox();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_login
            // 
            this.group_login.BackColor = System.Drawing.Color.PaleTurquoise;
            this.group_login.Controls.Add(this.checkBox_sp);
            this.group_login.Controls.Add(this.btn_cancel);
            this.group_login.Controls.Add(this.btn_login);
            this.group_login.Controls.Add(this.txt_pword);
            this.group_login.Controls.Add(this.txt_uname);
            this.group_login.Controls.Add(this.label2);
            this.group_login.Controls.Add(this.label1);
            this.group_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_login.Location = new System.Drawing.Point(14, 12);
            this.group_login.Name = "group_login";
            this.group_login.Size = new System.Drawing.Size(403, 222);
            this.group_login.TabIndex = 1;
            this.group_login.TabStop = false;
            this.group_login.Text = "Please Login";
            // 
            // checkBox_sp
            // 
            this.checkBox_sp.AutoSize = true;
            this.checkBox_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sp.Location = new System.Drawing.Point(168, 121);
            this.checkBox_sp.Name = "checkBox_sp";
            this.checkBox_sp.Size = new System.Drawing.Size(123, 20);
            this.checkBox_sp.TabIndex = 4;
            this.checkBox_sp.Text = "Show Password";
            this.checkBox_sp.UseVisualStyleBackColor = true;
            this.checkBox_sp.CheckedChanged += new System.EventHandler(this.checkBox_sp_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Cyan;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::PropertyMonitoringSystem.Properties.Resources.cancel_32px1;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(220, 163);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 45);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "    Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Cyan;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Image = global::PropertyMonitoringSystem.Properties.Resources.checked_2_32px3;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(80, 163);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(124, 45);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "    Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pword
            // 
            this.txt_pword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pword.Location = new System.Drawing.Point(168, 89);
            this.txt_pword.Name = "txt_pword";
            this.txt_pword.Size = new System.Drawing.Size(198, 26);
            this.txt_pword.TabIndex = 1;
            this.txt_pword.UseSystemPasswordChar = true;
            // 
            // txt_uname
            // 
            this.txt_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uname.Location = new System.Drawing.Point(168, 40);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(198, 26);
            this.txt_uname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(429, 251);
            this.Controls.Add(this.group_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.group_login.ResumeLayout(false);
            this.group_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_pword;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_sp;
    }
}

