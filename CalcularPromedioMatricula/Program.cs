using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPromedioMatricula
{
     class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno
            {


                Nombre = "Juan Pimentel",
                Matricula = "12345",
                Carrera = "desarrollo de software",
                Calificaciones = new List<int> { 85, 90, 78, 92 }

               
            };
            alumno.MostrarInformacion();
        }

     }
}
