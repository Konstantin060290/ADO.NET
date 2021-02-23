using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WFCS.ZACHET
{
    public class Logic
        {
        
        public DataSet MyDataSet { get; set; }
        public SqlDataAdapter MyDataAdapter { get; set; }

        static string connectionString = @"Server=(LocalDB)\MSSQLLocalDB; Integrated Security=true; AttachDbFileName=D:\Coding\ITMO\7_ADO_NET\Tasks\ITMO.WFCS.TASKS\ITMO.WFCS.ZACHET\school.mdf";
        static string sql = "SELECT * FROM Department";
      
        public void DataReader_GetStudents(ListView yourlistView)
            {
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
                {
                try
                    {
                    SqlCommand command = new SqlCommand("SELECT PersonId, FirstName, LastName, HireDate FROM Person", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        {

                        ListViewItem newItem = yourlistView.Items.Add(reader["PersonId"].ToString());
                        newItem.SubItems.Add(reader["FirstName"].ToString());
                        newItem.SubItems.Add(reader["LastName"].ToString());
                        newItem.SubItems.Add(reader["HireDate"].ToString());
                        }
                    connection.Dispose();
                    connection.Close();
                    
                    }
                catch (SqlException ex)
                    {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        public void export2File(ListView lv)
            {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
                {
                filename = sfd.FileName.ToString();
                if (filename != "")
                    {
                    using (StreamWriter sw = new StreamWriter(filename))
                        {
                        StringBuilder sb;

                        if (lv.Items.Count > 0)
                            {
                            // the actual data
                            foreach (ListViewItem lvi in lv.Items)
                                {
                                sb = new StringBuilder();

                                foreach (ListViewItem.ListViewSubItem listViewSubItem in lvi.SubItems)
                                    {
                                    sb.Append(string.Format("{0}\t\t", listViewSubItem.Text));
                                    }
                                sw.WriteLine(sb.ToString());
                                }
                            sw.WriteLine();
                            }
                        }
                    }
                }
            }

        public void DataSet_GetDepartments(DataGridView yourDataGridView)
            {
            SqlConnection connection = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            using (connection)
                {
                try
                    {
                    connection.Open();
                    adapter.Fill(ds);
                    yourDataGridView.DataSource = ds.Tables[0];
                    adapter.Dispose();
                    connection.Close();
                    }
                catch (SqlException ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }
            MyDataSet = ds;
            MyDataAdapter = adapter;
            }

        
        public void DataSet_ChangeDepartments(DataGridView yourDataGridView, DataSet ds, SqlDataAdapter adapter)
            {
             SqlConnection connection = new SqlConnection(connectionString);
             SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);
            using (connection)
                {
                try
                    {
                    SqlCommand command1 = new SqlCommand(sql, connection);
                    adapter.SelectCommand = command1;
                    adapter.Update(ds);
                    }
                
                catch (SqlException ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }

            }
        }
  

}
