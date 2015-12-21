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
    public partial class DesignationForm : Form
    {
        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

        bool IsInserting = false;
      
        public DesignationForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.ActiveControl = date_acq;
            IsInserting = true;
            btn_cancel.PerformClick();
        }
        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string[] splitinfoname = cmb_emname.Text.Split(new Char[] { '-' });
                string[] splitinfoitem = cmb_itname.Text.Split(new Char[] { '-' });
                MySqlCommand cmd = new MySqlCommand("insert into designation_info(date_acquired, date_returned, eid, iid ) value('" + date_acq.Value.ToString("yyyy-MM-dd") + "','" + date_ret.Value.ToString("yyyy-MM-dd") + "', '" + splitinfoname[0] + "', '" + splitinfoitem[0] + "' )", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully!");
                //connection.Close();
                LoadAllInfo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           private void LoadAllInfo()
             {
            connection = new MySqlConnection(ConnectionString);
            desig_grid.Rows.Clear();
            try
            {

                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from designation_info order by did desc", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    desig_grid.Rows.Add(dataReader["did"] + "", Convert.ToDateTime(dataReader["date_acquired"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(dataReader["date_returned"]).ToString("yyyy-MM-dd"), dataReader["eid"] + "", dataReader["iid"] + "");
                  
                }
               
                //connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
             private void LoadAllEmployee()
             {
                 connection = new MySqlConnection(ConnectionString);
                 desig_grid.Rows.Clear();
                 try
                 {

                     connection.Open();

                     MySqlCommand cmd = new MySqlCommand("select * from employee_info order by eid desc", connection);

                     MySqlDataReader dataReader = cmd.ExecuteReader();

                     while (dataReader.Read())
                     {
                         cmb_emname.Items.Add(dataReader["eid"] + "--" + dataReader["em_fname"] + " " + dataReader["em_lname"]+"");
                     }

                     //connection.Close();

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }
             private void LoadAllItem()
             {
                 connection = new MySqlConnection(ConnectionString);
                 desig_grid.Rows.Clear();
                 try
                 {

                     connection.Open();

                     MySqlCommand cmd = new MySqlCommand("select * from inventory_info order by iid desc", connection);

                     MySqlDataReader dataReader = cmd.ExecuteReader();

                     while (dataReader.Read())
                     {
                         cmb_itname.Items.Add(dataReader["iid"] + "--" + dataReader["item_name"] + "  " + dataReader["item_serial"]+"" );
                     }

                     //connection.Close();

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
                     string[] splitinfoname = cmb_emname.Text.Split(new Char[] { '-' });
                     string[] splitinfoitem = cmb_itname.Text.Split(new Char[] { '-' });
                     MySqlCommand cmd = new MySqlCommand("update designation_info set date_acquired = '" + date_acq.Value.ToString("yyyy-MM-dd") + "', date_returned ='" + date_ret.Value.ToString("yyyy-MM-dd") + "', eid = '" + splitinfoname[0] + "', iid ='" + splitinfoitem[0] + "' where did = '" + txt_did.Text + "'", connection);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Updated Succesfully!");
                     //connection.Close();
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
                     MySqlCommand cmd = new MySqlCommand("delete from designation_info where did = '" + ID + "'", connection);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Are you sure you want to delete this ?");
                     //connection.Close();
                     MessageBox.Show("Deleted Succesfully");
                     LoadAllEmployee();
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

             private void btn_cancel_Click(object sender, EventArgs e)
             {
                 txt_did.Text = "";
                 date_acq.Text = "";
                 date_ret.Text = "";
                 cmb_emname.Text = "";
                 cmb_itname.Text = "";
                 btn_add.Enabled = true;
             }

          

             private void updateToolStripMenuItem_Click(object sender, EventArgs e)
             {
                 btn_add.Enabled = false;
                 this.ActiveControl = date_acq;
                 IsInserting = false;
                 foreach (DataGridViewRow row in this.desig_grid.Rows)
                 {
                     if (row.Selected == true)
                     {
                         txt_did.Text = row.Cells[0].Value.ToString();
                         date_acq.Text = row.Cells[1].Value.ToString();
                         date_ret.Text = row.Cells[2].Value.ToString();
                         cmb_emname.Text = row.Cells[3].Value.ToString();
                         cmb_itname.Text = row.Cells[4].Value.ToString();
                         break;
                     }
                 }
             }

             private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
             {
                 
            btn_add.Enabled = true;
            foreach (DataGridViewRow row in this.desig_grid.Rows)
            {
                if (row.Selected == true)
                {
                    Delete(row.Cells[0].Value.ToString());
                    break;
                }
             }
        }


             private void desig_grid_CellClick(object sender, DataGridViewCellEventArgs e)
             {
                 if (e.RowIndex >= 0)
                 {
                     desig_grid.Rows[e.RowIndex].Selected = true;
                 }
             }

             private void DesignationForm_Load(object sender, EventArgs e)
             {
                 
                 LoadAllEmployee();
                 LoadAllItem();
                 LoadAllInfo();
                 this.ActiveControl = date_acq;
                 desig_grid.ReadOnly = true;
             }

           
        }
    }

