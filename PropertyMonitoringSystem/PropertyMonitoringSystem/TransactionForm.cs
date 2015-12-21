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
    public partial class TransactionForm : Form
    {

        private MySqlConnection connection;
        String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

        bool IsInserting = false;

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             
             this.ActiveControl = date_trans;
             IsInserting = true;
             btn_cancel.PerformClick();
        }

       private void Insert()
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                string res = pic_receipts.ImageLocation.ToString().Replace(@"\", "|");
                connection.Open();
                string[] splitinfoname = cmb_itemname.Text.Split(new Char[] { '-' });
                MySqlCommand cmd = new MySqlCommand("insert into transaction(trans_date, quantity, price, supplier, warranty, receipts, iid ) value('" + date_trans.Value.ToString("yyyy-MM-dd") + "', '" + txt_quant.Text + "','" + txt_price.Text + "', '" + txt_supp.Text + "', '" + txt_warrant.Text + "', '" + res + "',  '" + splitinfoname[0] + "' )", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully!");
                //connection.Close();
                LoadAllTransaction();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       private void LoadAllTransaction()
       {
           connection = new MySqlConnection(ConnectionString);
           transac_grid.Rows.Clear();
           try
           {
               connection.Open();

               MySqlCommand cmd = new MySqlCommand("select * from transaction order by tid desc ", connection);

               MySqlDataReader dataReader = cmd.ExecuteReader();

               while (dataReader.Read())
               {
                   transac_grid.Rows.Add(dataReader["tid"] + "", dataReader["trans_date"] + "", dataReader["quantity"] + "", dataReader["price"] + "", dataReader["supplier"] + "", dataReader["warranty"] + "", dataReader["receipts"] + "", dataReader["iid"] + "");
               }

               //connection.Close();

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }

       private void LoadAllItems()
       {
           connection = new MySqlConnection(ConnectionString);
           transac_grid.Rows.Clear();
           try
           {

               connection.Open();

               MySqlCommand cmd = new MySqlCommand("Select * from inventory_info order by iid desc", connection);

               MySqlDataReader dataReader = cmd.ExecuteReader();

               while (dataReader.Read())
               {
                   cmb_itemname.Items.Add(dataReader["iid"] + "--" + dataReader["item_name"] );
               }

               //connection.Close();

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
       private void Update()
       {
           connection = new MySqlConnection(ConnectionString);

           try
           {
               string res = pic_receipts.ImageLocation.ToString().Replace(@"\", "|");
               connection.Open();
               string[] splitinfoname = cmb_itemname.Text.Split(new Char[] { '-' });
               MySqlCommand cmd = new MySqlCommand("update transaction set trans_date = '" + date_trans.Value.ToString("yyyy-MM-dd") + "', quantity = '" + txt_quant.Text + "', price = '" + txt_price.Text + "', supplier = '" + txt_supp.Text + "', warranty ='" + txt_warrant.Text + "', receipts ='" + res + "', iid = '" + splitinfoname[0] + "' where tid = '" + txt_tid.Text + "' ", connection);
               cmd.ExecuteNonQuery();
               MessageBox.Show("Updated Succesfully!");
               //connection.Close();
               LoadAllTransaction();
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
               MySqlCommand cmd = new MySqlCommand("delete from transaction where tid = '" + ID + "'", connection);
               cmd.ExecuteNonQuery();
               MessageBox.Show("Are you sure you want to delete this ?");
              // connection.Close();
               MessageBox.Show("Deleted Succesfully !");
               LoadAllTransaction();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }

       private void updateToolStripMenuItem_Click(object sender, EventArgs e)
       {
           btn_add.Enabled = false;
           this.ActiveControl = date_trans;
           IsInserting = false;
           foreach (DataGridViewRow row in this.transac_grid.Rows)
           {
               if (row.Selected == true)
               {
                   txt_tid.Text = row.Cells[0].Value.ToString();
                   date_trans.Text = row.Cells[1].Value.ToString();                              
                   txt_quant.Text = row.Cells[2].Value.ToString();
                   txt_price.Text = row.Cells[3].Value.ToString();
                   txt_supp.Text = row.Cells[4].Value.ToString();
                   txt_warrant.Text = row.Cells[5].Value.ToString();
                   pic_receipts.ImageLocation = row.Cells[6].Value.ToString().Replace("|", @"\"); ;
                   cmb_itemname.Text = row.Cells[7].Value.ToString();
                   break;
               }
           }
       }

       private void btn_cancel_Click(object sender, EventArgs e)
       {
           txt_tid.Text = "";
           date_trans.Text = "";
           txt_quant.Text= "";
           txt_price.Text = "";
           txt_supp.Text = "";
           txt_warrant.Text = "";
           pic_receipts.ImageLocation = "";
           cmb_itemname.Text = "";
           btn_add.Enabled = true;
       }

       private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
       {
           btn_add.Enabled = true;
           foreach (DataGridViewRow row in this.transac_grid.Rows)
           {
               if (row.Selected == true)
               {
                   Delete(row.Cells[0].Value.ToString());
                   break;
               }
           }
       }


        private void TransactionForm_Load(object sender, EventArgs e)
        {
            LoadAllTransaction();
            LoadAllItems();
            this.ActiveControl = date_trans;
            transac_grid.ReadOnly = true;
        }

     

        private void pic_receipts_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openfile1 = new OpenFileDialog();
            if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = openfile1.FileName;

                if (filepath != string.Empty)
                {
                    pic_receipts.ImageLocation = filepath;
                }
            }
        }

        private void cmb_itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select iid, quantity from inventory_info where iid = '" + cmb_itemname.Text + "'", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    txt_quant.Text = dataReader["quantity"] + "";
                }
                //connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void transac_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                transac_grid.Rows[e.RowIndex].Selected = true;
            }
        }

       
    }
}
