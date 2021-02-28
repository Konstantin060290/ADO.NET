using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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
        
        SchoolEntities context;
        public void Entity_Show_SmithCourses(DataGridView yourDataGridView)
            {
            context = new SchoolEntities();
                     var courses = from c in context.OnsiteCourse
                                   where c.Location == "121 Smith"
                                   select c;
            context.OnsiteCourse.Load();
            yourDataGridView.DataSource = courses.ToList();
            yourDataGridView.Columns[4].Visible = false;
            }
        public void Entity_Show_AllCourses(DataGridView yourDataGridView)
            {
            context = new SchoolEntities();
            context.OnsiteCourse.Load();
            yourDataGridView.DataSource = context.OnsiteCourse.Local.ToBindingList();
            yourDataGridView.Columns[4].Visible = false;
            }

        public void ChangeCoursesList(DataGridView yourDataGridView)
            {
            context.SaveChanges();
            MessageBox.Show("Данные успешно сохранены");
            }
        public void AddCourse()
            {
            Course C1 = new Course();
            C1.CourseID = 5001;
            C1.Title = "Programming";
            C1.Credits = 4;
            C1.DepartmentID = 1;
            OnsiteCourse OC1 = new OnsiteCourse();
            OC1.CourseID = C1.CourseID;
            OC1.Location = "Saint-Petersburg";
            OC1.Days = Convert.ToString(10);
            OC1.Time = DateTime.Now;
           
            context.OnsiteCourse.Add(OC1);
            context.Course.Add(C1);
            context.SaveChanges();
            }
        
        
        string basePath = Environment.CurrentDirectory;
        string relativePath = @"./output.xml";

        public void Save_to_XML(DataGridView yourDataGridView)
            {
            DataTable dt = new DataTable();
            dt.TableName = "Courses";

            for (int i = 0; i < yourDataGridView.Columns.Count; i++)
                {
                //if (dataGridView1.Columns[i].Visible) // Add's only Visible columns (if you need it)
                //{
                string headerText = yourDataGridView.Columns[i].HeaderText;
                headerText = Regex.Replace(headerText, "[-/, ]", "_");

                DataColumn column = new DataColumn(headerText);
                dt.Columns.Add(column);
                //}
                }

            foreach (DataGridViewRow DataGVRow in yourDataGridView.Rows)
                {
                DataRow dataRow = dt.NewRow();
                // Add's only the columns that you want
                dataRow["CourseID"] = DataGVRow.Cells["CourseID"].Value;
                dataRow["Location"] = DataGVRow.Cells["Location"].Value;
                dataRow["Days"] = DataGVRow.Cells["Days"].Value;
                dataRow["Time"] = DataGVRow.Cells["Time"].Value;

                dt.Rows.Add(dataRow); //dt.Columns.Add();
                }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            //Finally the save part:

            XmlTextWriter xmlSave = new XmlTextWriter(relativePath, Encoding.UTF8);
            xmlSave.Formatting = Formatting.Indented;
            ds.DataSetName = "Courses";
            ds.WriteXml(xmlSave);
            xmlSave.Close();
            MessageBox.Show("XML файл сохранен в рабочую папку \\Project directory\\Debug");
            }
            public void ReadUpdatedXML(DataGridView yourDataGridView)
            {

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(relativePath);
            yourDataGridView.DataSource = dataSet.Tables[0];

            }
        
        }        
      
}
