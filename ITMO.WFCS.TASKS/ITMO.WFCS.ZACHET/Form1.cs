using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ITMO.WFCS.ZACHET
{
    public partial class ZachetForm : Form
    {
       
       
        public ZachetForm()
        {
            InitializeComponent();
        }

        public void MyMethod()
        {
            string connectionString = @"Server=(LocalDB)\MSSQLLocalDB; Integrated Security=true; AttachDbFileName=D:\Coding\ITMO\7_ADO_NET\Tasks\ITMO.WFCS.TASKS\ITMO.WFCS.ZACHET\school.mdf";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT PersonId, FirstName, LastName, HireDate FROM Person", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        ListViewItem newItem = listView1.Items.Add(reader["PersonId"].ToString());
                        newItem.SubItems.Add(reader["FirstName"].ToString());
                        newItem.SubItems.Add(reader["LastName"].ToString());
                        newItem.SubItems.Add(reader["HireDate"].ToString());
                    }
                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMethod();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export2File(listView1);
        }


        private void export2File(ListView lv)
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

    }
}
