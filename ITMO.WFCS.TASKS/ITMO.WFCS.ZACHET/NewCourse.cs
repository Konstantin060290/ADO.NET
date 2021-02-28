using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WFCS.ZACHET
    {
    public partial class NewCourse : Form
        {

        Course C1 = new Course();
        OnsiteCourse OC1 = new OnsiteCourse();
        SchoolEntities context;
     
        public NewCourse()
            {
            InitializeComponent();
            }
        
        private void CourseIDTextBox_TextChanged(object sender, EventArgs e)
            {
            C1.CourseID=Convert.ToInt32(CourseIDTextBox.Text);
            OC1.CourseID = C1.CourseID;
            }

        private void CourseTitleTextBox_TextChanged(object sender, EventArgs e)
            {
            C1.Title = CourseTitleTextBox.Text;
            }

        private void CreditsUpDown_SelectedItemChanged(object sender, EventArgs e)
            {
            C1.Credits = CreditsUpDown.SelectedIndex;
            }

        private void DepartmentUpDown_SelectedItemChanged(object sender, EventArgs e)
            {
            C1.DepartmentID = DepartmentUpDown.SelectedIndex;
            }

        private void LoctextBox_TextChanged(object sender, EventArgs e)
            {
            OC1.Location = LoctextBox.Text;
            }

        private void DaystextBox_TextChanged(object sender, EventArgs e)
            {
            OC1.Days = DaystextBox.Text;
            }

        private void TimetextBox_TextChanged(object sender, EventArgs e)
            {
            OC1.Time = Convert.ToDateTime(TimetextBox.Text);
            }

        private void AddToDBButton_Click(object sender, EventArgs e)
            {
            try
                {
                context = new SchoolEntities();
                context.OnsiteCourse.Add(OC1);
                context.Course.Add(C1);
                context.SaveChanges();
                MessageBox.Show("Курс успешно добавлен!");
                
                }
            catch (SqlException ex)
                {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

  

    }
