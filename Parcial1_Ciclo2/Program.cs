using System;
using System.Collections;

namespace Parcial
{
    class Program
    {

        static void Main(string[] args)
        {
            int finProceso;
            do
            {
                int numberStudents;
                ArrayList registro = new ArrayList();
                string nombre;
                int edad;
                double nota1;
                double nota2;
                double parcial;
                double promedio;

                int contador = 0;

                Console.WriteLine("Cuantos estudiantes desea evaluar: ");
                numberStudents = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                while (contador < numberStudents)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del primer laboratorio: ");
                    nota1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del segundo laboratorio: ");
                    nota2 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del parcial: ");
                    parcial = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    promedio = (nota1 * .3) + (nota2 * .3) + (parcial * .4);

                    Console.WriteLine("Su promedio es: {0}", promedio);
                    Console.WriteLine("");
                    if (promedio >= 6)
                    {
                        Console.WriteLine("                              ==== Aprobado ====");
                        Console.WriteLine("");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("                              ==== Reprobado ====");
                        Console.WriteLine("");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("");
                    }




                    Students students = new Students() { Nombre = nombre, Edad = edad, Nota1 = nota1, Nota2 = nota2, Parcial = parcial, Promedio = promedio };
                    registro.Add(students);

                    contador++;
                }



                foreach (Students st in registro)
                {
                    Console.WriteLine(st.getData());
                }
                Console.WriteLine("");
                Console.WriteLine("====== Si desea ejecutar de nuevo coloque 0 ======");
                finProceso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

            } while (finProceso == 0);
            Console.WriteLine("Gracias por ejecutar");
        }



    }




    public class Students
    {

        private string nombre;
        private int edad;
        private double notaLab1;
        private double notaLab2;
        private double parcial;
        private double promedio;

        public string Nombre
        {

            get => nombre;
            set => nombre = value;

        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public double Nota1
        {
            get => notaLab1;
            set => notaLab1 = value;
        }

        public double Nota2
        {
            get => notaLab2;
            set => notaLab2 = value;
        }

        public double Parcial
        {
            get => parcial;
            set => parcial = value;
        }

        public double Promedio
        {
            get => promedio;
            set => promedio = value;
        }

        public string getData()
        {
            return "-Nombre: " + nombre + "  -Edad: " + edad + "  -Nota Laboratorio 1: " + notaLab1 + "  -Nota Laboratorio 2: " + notaLab2 + "  -Parcial: " + Parcial + "  -Promedio: " + Promedio;
        }

    }

}