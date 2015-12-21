namespace PropertyMonitoringSystem
{
    partial class ReportForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(896, 614);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // date_from
            // 
            this.date_from.CustomFormat = "yyyy-MM-dd";
            this.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_from.Location = new System.Drawing.Point(519, 50);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(99, 22);
            this.date_from.TabIndex = 3;
            // 
            // date_to
            // 
            this.date_to.CustomFormat = "yyyy-MM-dd";
            this.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_to.Location = new System.Drawing.Point(661, 50);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(99, 22);
            this.date_to.TabIndex = 3;
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
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
            "-- Select Category --"});
            this.cmb_search.Location = new System.Drawing.Point(212, 52);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(143, 24);
            this.cmb_search.TabIndex = 4;
            this.cmb_search.Text = " -- Select Category --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Cyan;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::PropertyMonitoringSystem.Properties.Resources.Search_24;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(361, 52);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "   Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(896, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.date_to);
            this.Controls.Add(this.date_from);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;




    }
}