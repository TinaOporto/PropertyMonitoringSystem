namespace PropertyMonitoringSystem
{
    partial class DesignationForm
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
            this.groupBox_transac = new System.Windows.Forms.GroupBox();
            this.cmb_itname = new System.Windows.Forms.ComboBox();
            this.cmb_emname = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.date_ret = new System.Windows.Forms.DateTimePicker();
            this.date_acq = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_did = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.desig_grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox_transac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desig_grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_transac
            // 
            this.groupBox_transac.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox_transac.Controls.Add(this.cmb_itname);
            this.groupBox_transac.Controls.Add(this.cmb_emname);
            this.groupBox_transac.Controls.Add(this.btn_cancel);
            this.groupBox_transac.Controls.Add(this.label9);
            this.groupBox_transac.Controls.Add(this.btn_save);
            this.groupBox_transac.Controls.Add(this.btn_add);
            this.groupBox_transac.Controls.Add(this.date_ret);
            this.groupBox_transac.Controls.Add(this.date_acq);
            this.groupBox_transac.Controls.Add(this.label14);
            this.groupBox_transac.Controls.Add(this.txt_did);
            this.groupBox_transac.Controls.Add(this.label12);
            this.groupBox_transac.Controls.Add(this.label10);
            this.groupBox_transac.Controls.Add(this.label7);
            this.groupBox_transac.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_transac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_transac.Location = new System.Drawing.Point(0, 0);
            this.groupBox_transac.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_transac.Name = "groupBox_transac";
            this.groupBox_transac.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_transac.Size = new System.Drawing.Size(957, 151);
            this.groupBox_transac.TabIndex = 7;
            this.groupBox_transac.TabStop = false;
            this.groupBox_transac.Text = "Designation Details";
            // 
            // cmb_itname
            // 
            this.cmb_itname.FormattingEnabled = true;
            this.cmb_itname.Location = new System.Drawing.Point(445, 75);
            this.cmb_itname.Name = "cmb_itname";
            this.cmb_itname.Size = new System.Drawing.Size(217, 24);
            this.cmb_itname.TabIndex = 4;
            // 
            // cmb_emname
            // 
            this.cmb_emname.FormattingEnabled = true;
            this.cmb_emname.Location = new System.Drawing.Point(445, 39);
            this.cmb_emname.Name = "cmb_emname";
            this.cmb_emname.Size = new System.Drawing.Size(217, 24);
            this.cmb_emname.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Cyan;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::PropertyMonitoringSystem.Properties.Resources.cancel_24px;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(821, 107);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(123, 39);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "  Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Item Name";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Cyan;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::PropertyMonitoringSystem.Properties.Resources.save_26px;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(821, 60);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(123, 39);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // date_ret
            // 
            this.date_ret.CustomFormat = "yyyy-MM-dd";
            this.date_ret.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_ret.Location = new System.Drawing.Point(134, 113);
            this.date_ret.Margin = new System.Windows.Forms.Padding(4);
            this.date_ret.Name = "date_ret";
            this.date_ret.Size = new System.Drawing.Size(163, 22);
            this.date_ret.TabIndex = 2;
            // 
            // date_acq
            // 
            this.date_acq.CustomFormat = "yyyy-MM-dd";
            this.date_acq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_acq.Location = new System.Drawing.Point(133, 73);
            this.date_acq.Margin = new System.Windows.Forms.Padding(4);
            this.date_acq.Name = "date_acq";
            this.date_acq.Size = new System.Drawing.Size(163, 22);
            this.date_acq.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Date Acquired";
            // 
            // txt_did
            // 
            this.txt_did.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_did.Location = new System.Drawing.Point(133, 39);
            this.txt_did.Margin = new System.Windows.Forms.Padding(4);
            this.txt_did.Name = "txt_did";
            this.txt_did.ReadOnly = true;
            this.txt_did.Size = new System.Drawing.Size(164, 22);
            this.txt_did.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Employee Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Date Returned";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Designation ID";
            // 
            // desig_grid
            // 
            this.desig_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.desig_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.desig_grid.ContextMenuStrip = this.contextMenuStrip1;
            this.desig_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desig_grid.Location = new System.Drawing.Point(0, 151);
            this.desig_grid.Name = "desig_grid";
            this.desig_grid.Size = new System.Drawing.Size(957, 474);
            this.desig_grid.TabIndex = 8;
            this.desig_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.desig_grid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Designation ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Acquired";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date Returned";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Employee ID";
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Item ID";
            this.Column5.Name = "Column5";
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
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Cyan;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::PropertyMonitoringSystem.Properties.Resources.add_user_24px;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(821, 14);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 39);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "    Add New";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // DesignationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 625);
            this.Controls.Add(this.desig_grid);
            this.Controls.Add(this.groupBox_transac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DesignationForm";
            this.Load += new System.EventHandler(this.DesignationForm_Load);
            this.groupBox_transac.ResumeLayout(false);
            this.groupBox_transac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desig_grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_transac;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker date_ret;
        private System.Windows.Forms.DateTimePicker date_acq;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_did;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView desig_grid;
        private System.Windows.Forms.ComboBox cmb_itname;
        private System.Windows.Forms.ComboBox cmb_emname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}