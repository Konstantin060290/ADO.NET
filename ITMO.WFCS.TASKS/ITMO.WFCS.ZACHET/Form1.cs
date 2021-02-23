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

        Logic L1 = new Logic();
        public ZachetForm()
        {
            InitializeComponent();
        }
        
        private void GetStudentsButton_Click(object sender, EventArgs e)
        {
            L1.DataReader_GetStudents(StudentsListView);
        }

        private void SaveUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L1.export2File(StudentsListView);
        }

        private void GetTeachersButton_Click(object sender, EventArgs e)
        {
            
            L1.DataSet_GetDepartments(DepartmentsDataGridView);

        }
        
        private void ChangeDepartmentsButton_Click(object sender, EventArgs e)
            {
            L1.DataSet_ChangeDepartments(DepartmentsDataGridView, L1.MyDataSet, L1.MyDataAdapter);
            }
        }
}
