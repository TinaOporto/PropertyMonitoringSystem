namespace PropertyMonitoringSystem
{
    partial class TransactionForm
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
            this.pic_receipts = new System.Windows.Forms.PictureBox();
            this.txt_warrant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.date_trans = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_supp = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cmb_itemname = new System.Windows.Forms.ComboBox();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_tid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transac_grid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_transac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_receipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transac_grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_transac
            // 
            this.groupBox_transac.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox_transac.Controls.Add(this.pic_receipts);
            this.groupBox_transac.Controls.Add(this.txt_warrant);
            this.groupBox_transac.Controls.Add(this.label2);
            this.groupBox_transac.Controls.Add(this.label1);
            this.groupBox_transac.Controls.Add(this.btn_cancel);
            this.groupBox_transac.Controls.Add(this.label9);
            this.groupBox_transac.Controls.Add(this.btn_save);
            this.groupBox_transac.Controls.Add(this.btn_add);
            this.groupBox_transac.Controls.Add(this.date_trans);
            this.groupBox_transac.Controls.Add(this.label14);
            this.groupBox_transac.Controls.Add(this.txt_supp);
            this.groupBox_transac.Controls.Add(this.txt_price);
            this.groupBox_transac.Controls.Add(this.cmb_itemname);
            this.groupBox_transac.Controls.Add(this.txt_quant);
            this.groupBox_transac.Controls.Add(this.txt_tid);
            this.groupBox_transac.Controls.Add(this.label12);
            this.groupBox_transac.Controls.Add(this.label10);
            this.groupBox_transac.Controls.Add(this.label8);
            this.groupBox_transac.Controls.Add(this.label7);
            this.groupBox_transac.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_transac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_transac.Location = new System.Drawing.Point(0, 0);
            this.groupBox_transac.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_transac.Name = "groupBox_transac";
            this.groupBox_transac.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_transac.Size = new System.Drawing.Size(954, 163);
            this.groupBox_transac.TabIndex = 5;
            this.groupBox_transac.TabStop = false;
            this.groupBox_transac.Text = "Transaction Details";
            // 
            // pic_receipts
            // 
            this.pic_receipts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_receipts.Image = global::PropertyMonitoringSystem.Properties.Resources.add_image_96px;
            this.pic_receipts.Location = new System.Drawing.Point(579, 62);
            this.pic_receipts.Name = "pic_receipts";
            this.pic_receipts.Size = new System.Drawing.Size(128, 94);
            this.pic_receipts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_receipts.TabIndex = 10;
            this.pic_receipts.TabStop = false;
            this.pic_receipts.DoubleClick += new System.EventHandler(this.pic_receipts_DoubleClick);
            // 
            // txt_warrant
            // 
            this.txt_warrant.Location = new System.Drawing.Point(579, 34);
            this.txt_warrant.Name = "txt_warrant";
            this.txt_warrant.Size = new System.Drawing.Size(128, 22);
            this.txt_warrant.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Receipts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Warranty";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Cyan;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::PropertyMonitoringSystem.Properties.Resources.cancel_24px;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(829, 110);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 37);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Cyan;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::PropertyMonitoringSystem.Properties.Resources.save_26px;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(829, 62);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 32);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Cyan;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::PropertyMonitoringSystem.Properties.Resources.add_property_24px;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(829, 17);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 34);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "      Add New";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // date_trans
            // 
            this.date_trans.CustomFormat = "dd-MM-yyyy";
            this.date_trans.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_trans.Location = new System.Drawing.Point(120, 65);
            this.date_trans.Margin = new System.Windows.Forms.Padding(4);
            this.date_trans.Name = "date_trans";
            this.date_trans.Size = new System.Drawing.Size(151, 22);
            this.date_trans.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 70);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Date";
            // 
            // txt_supp
            // 
            this.txt_supp.Location = new System.Drawing.Point(351, 110);
            this.txt_supp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supp.Name = "txt_supp";
            this.txt_supp.Size = new System.Drawing.Size(140, 22);
            this.txt_supp.TabIndex = 5;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(351, 67);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(140, 22);
            this.txt_price.TabIndex = 4;
            // 
            // cmb_itemname
            // 
            this.cmb_itemname.FormattingEnabled = true;
            this.cmb_itemname.Location = new System.Drawing.Point(112, 102);
            this.cmb_itemname.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_itemname.Name = "cmb_itemname";
            this.cmb_itemname.Size = new System.Drawing.Size(151, 24);
            this.cmb_itemname.TabIndex = 2;
            this.cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.cmb_itemname_SelectedIndexChanged);
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(351, 32);
            this.txt_quant.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.ReadOnly = true;
            this.txt_quant.Size = new System.Drawing.Size(142, 22);
            this.txt_quant.TabIndex = 3;
            // 
            // txt_tid
            // 
            this.txt_tid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_tid.Location = new System.Drawing.Point(120, 31);
            this.txt_tid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tid.Name = "txt_tid";
            this.txt_tid.ReadOnly = true;
            this.txt_tid.Size = new System.Drawing.Size(152, 22);
            this.txt_tid.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Item ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Supplier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Transaction ID";
            // 
            // transac_grid
            // 
            this.transac_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transac_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7,
            this.Column3});
            this.transac_grid.ContextMenuStrip = this.contextMenuStrip1;
            this.transac_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transac_grid.Location = new System.Drawing.Point(0, 163);
            this.transac_grid.Margin = new System.Windows.Forms.Padding(4);
            this.transac_grid.Name = "transac_grid";
            this.transac_grid.Size = new System.Drawing.Size(954, 479);
            this.transac_grid.TabIndex = 11;
            this.transac_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transac_grid_CellClick);
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
            // Column1
            // 
            this.Column1.HeaderText = "Transaction ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Supplier";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Warranty";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Receipts";
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item ID";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 642);
            this.Controls.Add(this.transac_grid);
            this.Controls.Add(this.groupBox_transac);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.groupBox_transac.ResumeLayout(false);
            this.groupBox_transac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_receipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transac_grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_transac;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker date_trans;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ComboBox cmb_itemname;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_tid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_supp;
        private System.Windows.Forms.DataGridView transac_grid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_receipts;
        private System.Windows.Forms.TextBox txt_warrant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}