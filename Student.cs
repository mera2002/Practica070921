using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica070921
{
    class Student
    {
        public int idStudent { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }


        //Crear la coleccion de datos 
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{ idStudent= 1001, firstName= "Daniel", lastName="Hernandez", age=19, gender= "Masculino"},
                new Student{ idStudent= 1002, firstName= "Heriberto", lastName="Garcia", age=17, gender= "Masculino" },
                new Student{ idStudent= 1003, firstName= "Fernando", lastName="Rodriguez", age=17, gender= "Masculino" },
                new Student{ idStudent= 1004, firstName= "Nathaly", lastName="Silva", age=20, gender= "Femenino" },
                new Student{ idStudent= 1005, firstName= "Ana", lastName="Bonilla", age=15, gender= "Femenino" },
                new Student{ idStudent= 1006, firstName= "Roxana", lastName="Sorto", age=16, gender= "Femenino" },
                new Student{ idStudent= 1007, firstName= "Dylan", lastName="Araujo", age=21, gender= "Masculino" }
            };

            //Valor de retorno, sera la lista de estudiantes
            return students;
        }
    }

}