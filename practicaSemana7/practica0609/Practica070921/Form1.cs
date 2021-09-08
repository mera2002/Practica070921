using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica070921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstName", "NOMBRE");
            dgData.Columns.Add("lastName", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("gender", "GENERO");

            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firstName, student.lastName,
                student.age, student.gender);

            }
        }

            //metodo para retornar la coleccion de datos

            private List<Student> selectAllData()
        {
            // crear la consulta 
            List<Student> result = (
                   from student in Student.GetStudents()
                   select new Student()
                   {
                       idStudent = student.idStudent,
                       firstName = student.firstName,
                       lastName = student.lastName,
                       age = student.age,
                       gender = student.gender
                   }

                   ).ToList();

            return result;

        }

    }
}

