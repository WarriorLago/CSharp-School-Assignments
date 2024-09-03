using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace _21计科2班_马菁含_32021010069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sql_btn_Click(object sender, EventArgs e)
        {
                string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};",
                    serveIP.Text, Database.Text, UserName.Text, Password.Text);
                
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string sql = string.Format("SELECT * FROM {0} ", TableName.Text);
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string row = "";
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row += reader.GetValue(i).ToString() + "\t";
                            }
                        MessageBox.Show(row);
                    }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发送了意外，错误原因："+ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
