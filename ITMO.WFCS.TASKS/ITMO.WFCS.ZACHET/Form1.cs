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
using System.Data.Entity;

namespace ITMO.WFCS.ZACHET
{
    public partial class ZachetForm : Form
    {

        Logic L1 = new Logic();
        public ZachetForm()
        {
            InitializeComponent();
            var context = new SchoolEntities();
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

        private void List_Courses_button_Click(object sender, EventArgs e)
            {
            L1.Entity_Show_SmithCourses(ListCoursesGridView);
            }

        private void ChangeListCoursesButton_Click(object sender, EventArgs e)
            {
            L1.ChangeCoursesList(ListCoursesGridView);
            }

        private void List_All_Courses_button_Click(object sender, EventArgs e)
            {
            L1.Entity_Show_AllCourses(ListCoursesGridView);
            }

        private void Save_to_XML_button_Click(object sender, EventArgs e)
            {
            L1.Save_to_XML(ListCoursesGridView);
            }

        private void ReadUpdatedXMLButton_Click(object sender, EventArgs e)
            {
            L1.ReadUpdatedXML(ListCoursesGridView);
            }

        private void Add_Course_Button_Click(object sender, EventArgs e)
            {
            L1.AddCourse();
            }
        }
}
