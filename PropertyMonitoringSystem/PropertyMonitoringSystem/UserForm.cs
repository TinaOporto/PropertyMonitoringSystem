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
    public partial class UserForm : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

        bool IsInserting = false;

        public UserForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txtuname;
            IsInserting = true;
            btn_cancel.PerformClick();
        }
        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into users(uid, uname, pword, fname, lname, acct_type ) value('"+ txtuid.Text +"', '" + txtuname.Text + "', '" + txtpword.Text + "', '" + txtfname.Text + "', '" + txtlname.Text + "','" + txtacct.Text + "' )", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully!");
                connection.Close();
                LoadAllUsers();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadAllUsers()
        {
            connection = new MySqlConnection(ConnectionString);
            user_grid.Rows.Clear();
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from users order by uid desc ", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    user_grid.Rows.Add(dataReader["uid"] + "", dataReader["uname"] + "", dataReader["pword"] + "", dataReader["fname"] + "", dataReader["lname"] + "", dataReader["acct_type"]);
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
            this.ActiveControl = txtuname;
            user_grid.ReadOnly = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txtuid.Text = "";
            txtuname.Text = "";
            txtpword.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtacct.Text = "";
            btn_add.Enabled = true;
        }

        private void user_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                user_grid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void Update()
        {
            connection = new MySqlConnection(ConnectionString);

            try
            {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("update users set uname = '" + txtuname.Text + "', pword = '" + txtpword.Text + "',  fname = '" + txtfname.Text + "', lname = '" + txtlname.Text + "', acct_type = '" + txtacct.Text + "' where uid = '" + txtuid.Text + "'", connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Succesfully!");
            connection.Close();
            LoadAllUsers();
            }
        catch (Exception ex)
         {
        MessageBox.Show(ex.Message);
         }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            this.ActiveControl = txtuname;
            IsInserting = false;
            foreach (DataGridViewRow row in this.user_grid.Rows)
            {
                if (row.Selected == true)
                {
                    txtuid.Text = row.Cells[0].Value.ToString();
                    txtuname.Text = row.Cells[1].Value.ToString();
                    txtpword.Text = row.Cells[2].Value.ToString();  
                    txtfname.Text = row.Cells[3].Value.ToString();
                    txtlname.Text = row.Cells[4].Value.ToString();
                    txtacct.Text = row.Cells[5].Value.ToString();
                    break;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            foreach (DataGridViewRow row in this.user_grid.Rows)
            {
                if (row.Selected == true)
                {
                    Delete(row.Cells[0].Value.ToString());
                    break;
                }
            }
        }

      private void Delete(string ID)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("delete from users where uid = '" + ID + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to delete this ?");
                connection.Close();
                MessageBox.Show("Deleted Sucesfully !");
                LoadAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
