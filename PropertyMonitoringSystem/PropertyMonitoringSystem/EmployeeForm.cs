using MySql.Data.MySqlClient;
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
    public partial class EmployeeForm : Form
    {

        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

        bool IsInserting = false;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txt_fname;
            IsInserting = true;
            btn_cancel.PerformClick();
        }
        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into employee_info(eid, em_fname, em_lname, company_id ) value('" + txt_eid.Text + "', '" + txt_fname.Text + "', '" + txt_lname.Text + "','" + txt_compid.Text + "' )", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully!");
                connection.Close();

                LoadAllEmployee();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadAllEmployee();
            this.ActiveControl = txt_fname;
            employee_grid.ReadOnly = true;
        }
        private void LoadAllEmployee()
        {
            connection = new MySqlConnection(ConnectionString);
            employee_grid.Rows.Clear();
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from employee_info order by eid desc ", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    employee_grid.Rows.Add(dataReader["eid"] + "", dataReader["em_fname"] + "",  dataReader["em_lname"] + "", dataReader["company_id"]);
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Update()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update employee_info set em_fname = '" + txt_fname.Text + "', em_lname = '" + txt_lname.Text + "', company_id = '" + txt_compid.Text + "' where eid = '" + txt_eid.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfully!");
                connection.Close();
                LoadAllEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Delete(string ID)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("delete from employee_info where eid = '" + ID + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to delete this ?");
                connection.Close();
                MessageBox.Show("Deleted Sucesfully !");
                LoadAllEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            btn_add.Enabled = false;
            this.ActiveControl = txt_fname;
            IsInserting = false;
            foreach (DataGridViewRow row in this.employee_grid.Rows)
            {
                if (row.Selected == true)
                {
                    txt_eid.Text = row.Cells[0].Value.ToString(); 
                    txt_fname.Text = row.Cells[1].Value.ToString();
                    txt_lname.Text = row.Cells[2].Value.ToString();
                    txt_compid.Text = row.Cells[3].Value.ToString();
                    break;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            foreach (DataGridViewRow row in this.employee_grid.Rows)
            {
                if (row.Selected == true)
                {
                    Delete(row.Cells[0].Value.ToString());
                    break;
                }
            }
        }

        private void employee_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employee_grid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (IsInserting == true)
            {
                Insert();
            }
            else
            {
                Update();
            }

            btn_cancel.PerformClick();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_eid.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_compid.Text = "";
            btn_add.Enabled = true;
        }
        
    }
}
