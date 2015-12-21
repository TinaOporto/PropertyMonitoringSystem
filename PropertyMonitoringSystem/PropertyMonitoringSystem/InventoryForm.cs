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
    public partial class InventoryForm : Form
    {

        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

        bool IsInserting = false;

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void btn_inadd_Click(object sender, EventArgs e)
        {
            this.ActiveControl = date_invent;
            IsInserting = true;
            btn_incancel.PerformClick();
        }
        private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into inventory_info(iid, item_date, category, item_name, item_description, item_serial, item_brand, quantity, unit, status ) value('" + txt_iid.Text + "','" + date_invent.Value.ToString("yyyy-MM-dd") + "','" + cmb_cat.Text + "', '" + txt_itemname.Text + "','" + txt_descrip.Text + "', '" + txt_serial.Text + "','" + cmb_brand.Text + "', '" + txt_quant.Text + "', '" + cmb_unit.Text + "', '" + cmb_stat.Text + "' )", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully!");
                connection.Close();
                LoadAllInventory();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAllInventory()
        {
            connection = new MySqlConnection(ConnectionString);
            inventory_grid.Rows.Clear();
            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("select * from inventory_info order by iid desc ", connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    inventory_grid.Rows.Add(dataReader["iid"] + "", dataReader["item_date"] + "", dataReader["category"] + "", dataReader["item_name"] + "", dataReader["item_description"] + "", dataReader["item_serial"] + "", dataReader["item_brand"] + "", dataReader["quantity"] + "", dataReader["unit"] + "", dataReader["status"]);
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
                MySqlCommand cmd = new MySqlCommand("update inventory_info set item_date = '" + date_invent.Value.ToString("yyyy-MM-dd") + "', category = '" + cmb_cat.Text + "', item_name = '" + txt_itemname.Text + "', item_description = '" + txt_descrip.Text + "', item_serial = '" + txt_serial.Text + "', item_brand = '" + cmb_brand.Text + "', quantity ='" + txt_quant.Text + "', unit = '" + cmb_unit.Text + "', status = '" + cmb_stat.Text + "'  where iid = '" + txt_iid.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfully!");
                connection.Close();
                LoadAllInventory();
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
                MySqlCommand cmd = new MySqlCommand("delete from employee_info where iid = '" + ID + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to delete this ?");
                connection.Close();
                MessageBox.Show("Deleted Sucesfully !");
                LoadAllInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_insave_Click(object sender, EventArgs e)
        {
            if (IsInserting == true)
            {
                Insert();
            }
            else
            {
                Update();
            }

            btn_incancel.PerformClick();
        }

        private void btn_incancel_Click(object sender, EventArgs e)
        {
            txt_iid.Text = "";
            date_invent.Text = "";
            cmb_cat.Text = "";
            txt_itemname.Text = "";
            txt_descrip.Text = "";
            txt_serial.Text = "";
            cmb_brand.Text = "";
            txt_quant.Text = "";
            cmb_unit.Text = "";
            cmb_stat.Text = "";
           
            btn_inadd.Enabled = true;
        }

        private void inventory_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                inventory_grid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadAllInventory();
            this.ActiveControl = date_invent;
            inventory_grid.ReadOnly = true;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_inadd.Enabled = false;
            this.ActiveControl = date_invent;
            IsInserting = false;
            foreach (DataGridViewRow row in this.inventory_grid.Rows)
            {
                if (row.Selected == true)
                {
                    txt_iid.Text = row.Cells[0].Value.ToString();
                    date_invent.Text = row.Cells[1].Value.ToString();
                    cmb_cat.Text = row.Cells[2].Value.ToString();
                    txt_itemname.Text = row.Cells[3].Value.ToString();
                    txt_descrip.Text = row.Cells[4].Value.ToString();
                    txt_serial.Text = row.Cells[5].Value.ToString();
                    cmb_brand.Text = row.Cells[6].Value.ToString();
                    txt_quant.Text = row.Cells[7].Value.ToString();
                    cmb_unit.Text = row.Cells[8].Value.ToString();
                    cmb_stat.Text = row.Cells[8].Value.ToString();
                    
                    break;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_inadd.Enabled = true;
            foreach (DataGridViewRow row in this.inventory_grid.Rows)
            {
                if (row.Selected == true)
                {
                    Delete(row.Cells[0].Value.ToString());
                    break;
                }
            }
        }
        
    }
}
