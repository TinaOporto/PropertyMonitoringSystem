using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReportForm : Form
    {
       // private MySqlConnection connection;
       // String ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

        public ReportForm()
        {
            InitializeComponent();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            ReportDocument myReport = new ReportDocument();
            DataSet myData = new DataSet();
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            conn.ConnectionString = "Server=192.168.0.24;Database=inventory_items;Uid=tina;Pwd=!ojt2015;";

            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "inventory_info";
                dt.TableName = "transaction";

                //cmd.CommandText = "SELECT price FROM transaction WHERE price>(SELECT AVG(Price) FROM transaction)";
                //cmd.CommandText = "select iid, item_name, item_description, quantity, from inventory_info where category = '" + cmb_search.Text + " '";         
                cmd.CommandText = "Select inventory_info.iid, inventory_info.item_name, inventory_info.item_description, inventory_info.quantity, transaction.price  from inventory_info,  transaction where inventory_info.category =  '" + cmb_search.Text + " '  and transaction.iid=inventory_info.iid";
                cmd.Connection = conn;

                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(dt);

                myData.Tables.Add(dt);

                string reportPath = @"C:\Users\OJT\Desktop\MainProject\PropertyMonitoringSystem\PropertyMonitoringSystem\CrystalReport1.rpt";
                myReport.Load(reportPath);
                myReport.SetDataSource(myData);
                crystalReportViewer1.ReportSource = myReport;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Report could not be created",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
       
    }
}
