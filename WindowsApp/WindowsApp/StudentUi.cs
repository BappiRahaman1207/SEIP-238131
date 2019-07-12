using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Models.Models;
using WindowsApp.BLL.BLL;

namespace WindowsApp
{
    public partial class StudentUi : Form
    {
        public StudentUi()
        {
            InitializeComponent();
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            StudentManager _studentManager = new StudentManager();
            Student student = new Student();
            student.ID = 100;
            student.Name = "Ali";
          MessageBox.Show( _studentManager.AddStudent(student));
        }
    }
}
