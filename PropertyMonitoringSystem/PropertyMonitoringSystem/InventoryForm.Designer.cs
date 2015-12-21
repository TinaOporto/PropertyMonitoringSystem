namespace PropertyMonitoringSystem
{
    partial class InventoryForm
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
            this.panel_inventory = new System.Windows.Forms.Panel();
            this.inventory_grid = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_inventory = new System.Windows.Forms.GroupBox();
            this.cmb_unit = new System.Windows.Forms.ComboBox();
            this.btn_incancel = new System.Windows.Forms.Button();
            this.btn_insave = new System.Windows.Forms.Button();
            this.btn_inadd = new System.Windows.Forms.Button();
            this.date_invent = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.cmb_stat = new System.Windows.Forms.ComboBox();
            this.cmb_brand = new System.Windows.Forms.ComboBox();
            this.cmb_cat = new System.Windows.Forms.ComboBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_iid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_inventory
            // 
            this.panel_inventory.Controls.Add(this.inventory_grid);
            this.panel_inventory.Controls.Add(this.groupBox_inventory);
            this.panel_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_inventory.Location = new System.Drawing.Point(0, 0);
            this.panel_inventory.Name = "panel_inventory";
            this.panel_inventory.Size = new System.Drawing.Size(1048, 626);
            this.panel_inventory.TabIndex = 4;
            // 
            // inventory_grid
            // 
            this.inventory_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column9,
            this.Column8,
            this.Column10,
            this.Column1,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column2,
            this.Column14});
            this.inventory_grid.ContextMenuStrip = this.contextMenuStrip1;
            this.inventory_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory_grid.GridColor = System.Drawing.Color.LightBlue;
            this.inventory_grid.Location = new System.Drawing.Point(0, 162);
            this.inventory_grid.Name = "inventory_grid";
            this.inventory_grid.Size = new System.Drawing.Size(1048, 464);
            this.inventory_grid.TabIndex = 12;
            this.inventory_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_grid_CellClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Item ID";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Category";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Item Name";
            this.Column10.Name = "Column10";
            this.Column10.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Description";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Serial";
            this.Column11.Name = "Column11";
            this.Column11.Width = 120;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Brand";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Quantity";
            this.Column13.Name = "Column13";
            this.Column13.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column14.HeaderText = "Status";
            this.Column14.Name = "Column14";
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
            // groupBox_inventory
            // 
            this.groupBox_inventory.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox_inventory.Controls.Add(this.cmb_unit);
            this.groupBox_inventory.Controls.Add(this.btn_incancel);
            this.groupBox_inventory.Controls.Add(this.btn_insave);
            this.groupBox_inventory.Controls.Add(this.btn_inadd);
            this.groupBox_inventory.Controls.Add(this.date_invent);
            this.groupBox_inventory.Controls.Add(this.label14);
            this.groupBox_inventory.Controls.Add(this.txt_quant);
            this.groupBox_inventory.Controls.Add(this.txt_serial);
            this.groupBox_inventory.Controls.Add(this.cmb_stat);
            this.groupBox_inventory.Controls.Add(this.cmb_brand);
            this.groupBox_inventory.Controls.Add(this.cmb_cat);
            this.groupBox_inventory.Controls.Add(this.txt_descrip);
            this.groupBox_inventory.Controls.Add(this.txt_itemname);
            this.groupBox_inventory.Controls.Add(this.txt_iid);
            this.groupBox_inventory.Controls.Add(this.label13);
            this.groupBox_inventory.Controls.Add(this.label12);
            this.groupBox_inventory.Controls.Add(this.label11);
            this.groupBox_inventory.Controls.Add(this.label1);
            this.groupBox_inventory.Controls.Add(this.label10);
            this.groupBox_inventory.Controls.Add(this.label9);
            this.groupBox_inventory.Controls.Add(this.label8);
            this.groupBox_inventory.Controls.Add(this.label7);
            this.groupBox_inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_inventory.Location = new System.Drawing.Point(0, 0);
            this.groupBox_inventory.Name = "groupBox_inventory";
            this.groupBox_inventory.Size = new System.Drawing.Size(1048, 162);
            this.groupBox_inventory.TabIndex = 4;
            this.groupBox_inventory.TabStop = false;
            this.groupBox_inventory.Text = "Inventory Details";
            // 
            // cmb_unit
            // 
            this.cmb_unit.FormattingEnabled = true;
            this.cmb_unit.Items.AddRange(new object[] {
            "pc/s",
            "m",
            "set",
            "roll"});
            this.cmb_unit.Location = new System.Drawing.Point(755, 81);
            this.cmb_unit.Name = "cmb_unit";
            this.cmb_unit.Size = new System.Drawing.Size(64, 24);
            this.cmb_unit.TabIndex = 12;
            // 
            // btn_incancel
            // 
            this.btn_incancel.BackColor = System.Drawing.Color.Cyan;
            this.btn_incancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_incancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incancel.Image = global::PropertyMonitoringSystem.Properties.Resources.cancel_24px;
            this.btn_incancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_incancel.Location = new System.Drawing.Point(900, 111);
            this.btn_incancel.Name = "btn_incancel";
            this.btn_incancel.Size = new System.Drawing.Size(127, 45);
            this.btn_incancel.TabIndex = 11;
            this.btn_incancel.Text = "Cancel";
            this.btn_incancel.UseVisualStyleBackColor = false;
            this.btn_incancel.Click += new System.EventHandler(this.btn_incancel_Click);
            // 
            // btn_insave
            // 
            this.btn_insave.BackColor = System.Drawing.Color.Cyan;
            this.btn_insave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insave.Image = global::PropertyMonitoringSystem.Properties.Resources.save_26px;
            this.btn_insave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insave.Location = new System.Drawing.Point(900, 64);
            this.btn_insave.Name = "btn_insave";
            this.btn_insave.Size = new System.Drawing.Size(127, 41);
            this.btn_insave.TabIndex = 10;
            this.btn_insave.Text = "Save";
            this.btn_insave.UseVisualStyleBackColor = false;
            this.btn_insave.Click += new System.EventHandler(this.btn_insave_Click);
            // 
            // btn_inadd
            // 
            this.btn_inadd.BackColor = System.Drawing.Color.Cyan;
            this.btn_inadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inadd.Image = global::PropertyMonitoringSystem.Properties.Resources.add_property_24px;
            this.btn_inadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inadd.Location = new System.Drawing.Point(900, 14);
            this.btn_inadd.Name = "btn_inadd";
            this.btn_inadd.Size = new System.Drawing.Size(127, 44);
            this.btn_inadd.TabIndex = 9;
            this.btn_inadd.Text = "     Add New";
            this.btn_inadd.UseVisualStyleBackColor = false;
            this.btn_inadd.Click += new System.EventHandler(this.btn_inadd_Click);
            // 
            // date_invent
            // 
            this.date_invent.CustomFormat = "dd-MM-yyyy";
            this.date_invent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_invent.Location = new System.Drawing.Point(87, 83);
            this.date_invent.Name = "date_invent";
            this.date_invent.Size = new System.Drawing.Size(159, 22);
            this.date_invent.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Date";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(615, 81);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(133, 22);
            this.txt_quant.TabIndex = 7;
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(383, 114);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(152, 22);
            this.txt_serial.TabIndex = 5;
            // 
            // cmb_stat
            // 
            this.cmb_stat.FormattingEnabled = true;
            this.cmb_stat.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "  -- Select Status --"});
            this.cmb_stat.Location = new System.Drawing.Point(615, 116);
            this.cmb_stat.Name = "cmb_stat";
            this.cmb_stat.Size = new System.Drawing.Size(133, 24);
            this.cmb_stat.TabIndex = 8;
            this.cmb_stat.Text = "  -- Select Status --";
            // 
            // cmb_brand
            // 
            this.cmb_brand.FormattingEnabled = true;
            this.cmb_brand.Items.AddRange(new object[] {
            "Acer",
            "Canon",
            "Dell",
            "Samsung",
            "SKIL",
            " -- Select Brand --"});
            this.cmb_brand.Location = new System.Drawing.Point(615, 48);
            this.cmb_brand.Name = "cmb_brand";
            this.cmb_brand.Size = new System.Drawing.Size(134, 24);
            this.cmb_brand.TabIndex = 6;
            this.cmb_brand.Text = " -- Select Brand --";
            // 
            // cmb_cat
            // 
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Items.AddRange(new object[] {
            "Battery",
            "Cable Wire",
            "CD Installer",
            "Computer Cords",
            "Computer Device",
            "Extension Wire",
            "Gadget",
            "Ink",
            "Memory",
            "Power Adaptor",
            "Telephone Wire",
            "Tools",
            " -- Select Category --"});
            this.cmb_cat.Location = new System.Drawing.Point(88, 114);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(158, 24);
            this.cmb_cat.TabIndex = 2;
            this.cmb_cat.Text = " -- Select Category --";
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(382, 83);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(153, 22);
            this.txt_descrip.TabIndex = 4;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(382, 50);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(153, 22);
            this.txt_itemname.TabIndex = 3;
            // 
            // txt_iid
            // 
            this.txt_iid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_iid.Location = new System.Drawing.Point(87, 50);
            this.txt_iid.Name = "txt_iid";
            this.txt_iid.ReadOnly = true;
            this.txt_iid.Size = new System.Drawing.Size(159, 22);
            this.txt_iid.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(553, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = " Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " Item Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Serial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = " Item Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1048, 626);
            this.Controls.Add(this.panel_inventory);
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel_inventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_inventory.ResumeLayout(false);
            this.groupBox_inventory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_inventory;
        private System.Windows.Forms.GroupBox groupBox_inventory;
        private System.Windows.Forms.Button btn_incancel;
        private System.Windows.Forms.Button btn_insave;
        private System.Windows.Forms.Button btn_inadd;
        private System.Windows.Forms.DateTimePicker date_invent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.ComboBox cmb_stat;
        private System.Windows.Forms.ComboBox cmb_brand;
        private System.Windows.Forms.ComboBox cmb_cat;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.TextBox txt_iid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView inventory_grid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.ComboBox cmb_unit;
    }
}