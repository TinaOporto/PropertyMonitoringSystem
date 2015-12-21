namespace PropertyMonitoringSystem
{
    partial class UserForm
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
            this.panel_user = new System.Windows.Forms.Panel();
            this.user_grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_user = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtacct = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtpword = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_user
            // 
            this.panel_user.Controls.Add(this.user_grid);
            this.panel_user.Controls.Add(this.groupBox_user);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(1000, 626);
            this.panel_user.TabIndex = 3;
            // 
            // user_grid
            // 
            this.user_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.user_grid.ContextMenuStrip = this.contextMenuStrip1;
            this.user_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_grid.Location = new System.Drawing.Point(0, 153);
            this.user_grid.Name = "user_grid";
            this.user_grid.Size = new System.Drawing.Size(1000, 473);
            this.user_grid.TabIndex = 1;
            this.user_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_grid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Firstname";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lastname";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Account Type";
            this.Column6.Name = "Column6";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 54);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox_user
            // 
            this.groupBox_user.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox_user.Controls.Add(this.btn_cancel);
            this.groupBox_user.Controls.Add(this.btn_save);
            this.groupBox_user.Controls.Add(this.btn_add);
            this.groupBox_user.Controls.Add(this.txtacct);
            this.groupBox_user.Controls.Add(this.txtlname);
            this.groupBox_user.Controls.Add(this.txtfname);
            this.groupBox_user.Controls.Add(this.txtpword);
            this.groupBox_user.Controls.Add(this.txtuname);
            this.groupBox_user.Controls.Add(this.txtuid);
            this.groupBox_user.Controls.Add(this.label6);
            this.groupBox_user.Controls.Add(this.label5);
            this.groupBox_user.Controls.Add(this.label4);
            this.groupBox_user.Controls.Add(this.label3);
            this.groupBox_user.Controls.Add(this.label2);
            this.groupBox_user.Controls.Add(this.label1);
            this.groupBox_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_user.Location = new System.Drawing.Point(0, 0);
            this.groupBox_user.Name = "groupBox_user";
            this.groupBox_user.Size = new System.Drawing.Size(1000, 153);
            this.groupBox_user.TabIndex = 0;
            this.groupBox_user.TabStop = false;
            this.groupBox_user.Text = "User Details";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Cyan;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::PropertyMonitoringSystem.Properties.Resources.cancel_24px;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(861, 105);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(127, 42);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Cyan;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::PropertyMonitoringSystem.Properties.Resources.save_26px;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(861, 61);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(127, 38);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Cyan;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::PropertyMonitoringSystem.Properties.Resources.add_user_24px;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(861, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 42);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "   Add New";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtacct
            // 
            this.txtacct.Location = new System.Drawing.Point(496, 105);
            this.txtacct.Name = "txtacct";
            this.txtacct.Size = new System.Drawing.Size(194, 22);
            this.txtacct.TabIndex = 5;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(496, 69);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(194, 22);
            this.txtlname.TabIndex = 4;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(496, 33);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(194, 22);
            this.txtfname.TabIndex = 3;
            // 
            // txtpword
            // 
            this.txtpword.Location = new System.Drawing.Point(176, 108);
            this.txtpword.Name = "txtpword";
            this.txtpword.Size = new System.Drawing.Size(179, 22);
            this.txtpword.TabIndex = 2;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(176, 72);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(179, 22);
            this.txtuname.TabIndex = 1;
            // 
            // txtuid
            // 
            this.txtuid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtuid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtuid.Location = new System.Drawing.Point(176, 36);
            this.txtuid.Name = "txtuid";
            this.txtuid.ReadOnly = true;
            this.txtuid.Size = new System.Drawing.Size(179, 22);
            this.txtuid.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(88, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(88, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(88, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 626);
            this.Controls.Add(this.panel_user);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_user.ResumeLayout(false);
            this.groupBox_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.DataGridView user_grid;
        private System.Windows.Forms.GroupBox groupBox_user;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtacct;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtpword;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}