using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyMonitoringSystem
{
    public partial class MainMDIForm : Form
    {
        public MainMDIForm()
        {
            InitializeComponent();
        }

        private void MainMDIForm_Load(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.MdiParent = this;
            welcome.Dock = DockStyle.Fill;
            welcome.Show();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = treeView1.SelectedNode;

                if (node.Text == "Manage User")
                {
                    UserForm usersetup = new UserForm();
                    usersetup.MdiParent = this;
                    usersetup.Dock = DockStyle.Fill;
                    usersetup.Show();
                }

                if (node.Text == "Manage Inventory")
                {
                    InventoryForm inventory = new InventoryForm();
                    inventory.MdiParent = this;
                    inventory.Dock = DockStyle.Fill;
                    inventory.Show();
                }

                if (node.Text == "Employee Details")
                {
                    EmployeeForm employee = new EmployeeForm();
                    employee.MdiParent = this;
                    employee.Dock = DockStyle.Fill;
                    employee.Show();
                }

                if (node.Text == "Transaction")
                {
                    TransactionForm transac = new TransactionForm();
                    transac.MdiParent = this;
                    transac.Dock = DockStyle.Fill;
                    transac.Show();
                }
                if (node.Text == "Designation")
                {
                    DesignationForm desig = new DesignationForm();
                    desig.MdiParent = this;
                    desig.Dock = DockStyle.Fill;
                    desig.Show();
                }
                if (node.Text == "Generate Reports")
                {
                    ReportForm report = new ReportForm();
                    report.MdiParent = this;
                    report.Dock = DockStyle.Fill;
                    report.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                     
        }      
    }
}
