namespace PropertyMonitoringSystem
{
    partial class MainMDIForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Manage User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Manage Inventory");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Employee Details");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Transaction");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Designation");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Generate Reports");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Inventory System", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDIForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightBlue;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 6;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 100);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node_user";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "Manage User";
            treeNode2.Name = "Node_inventory";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Manage Inventory";
            treeNode3.Name = "Node_employee";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Employee Details";
            treeNode4.Name = "Node_trans";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Transaction";
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Designation";
            treeNode6.Name = "Node_reports";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Text = "Generate Reports";
            treeNode7.Name = "Node0";
            treeNode7.SelectedImageKey = "filled_box_32px.png";
            treeNode7.Text = "Inventory System";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(233, 545);
            this.treeView1.TabIndex = 1;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user_folder_96px.png");
            this.imageList1.Images.SetKeyName(1, "product_32px.png");
            this.imageList1.Images.SetKeyName(2, "businesspeople2.png");
            this.imageList1.Images.SetKeyName(3, "card-512.png");
            this.imageList1.Images.SetKeyName(4, "images (2).png");
            this.imageList1.Images.SetKeyName(5, "task_report_hot.png");
            this.imageList1.Images.SetKeyName(6, "filled_box_32px.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BackgroundImage = global::PropertyMonitoringSystem.Properties.Resources.new_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 100);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PropertyMonitoringSystem.Properties.Resources._new;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1212, 645);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainMDIForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMDIForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}