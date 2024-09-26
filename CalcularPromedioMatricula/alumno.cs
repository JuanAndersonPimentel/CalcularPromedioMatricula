using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPromedioMatricula
{
     class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public List<int> Calificaciones { get; set; }

        public double CalcularPromedio()
        {
            try
            {
                int suma = 0;
                foreach (int calificacion in Calificaciones)
                {
                    suma += calificacion;
                }
                return (double)suma / Calificaciones.Count;

            }
            catch (Exception)
            {

                Console.WriteLine("ocurrio un error al calcular el promedio:");
                return 0;

            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Promedio:{CalcularPromedio()} ");
        }



     }
}
