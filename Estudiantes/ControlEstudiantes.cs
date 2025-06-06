using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    public class ControlEstudiantes
    {
        string[,]? estudiantes { get; }

        public ControlEstudiantes()
        {
            try
            {
                Console.Write("Ingrese la cantidad de estudiantes a registrar: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                estudiantes = new string[cantidad + 1, 7];

                estudiantes[0, 0] = "Matricula";
                estudiantes[0, 1] = "Nombre";
                estudiantes[0, 2] = "Apellido";
                estudiantes[0, 3] = "Teléfono";
                estudiantes[0, 4] = "Correo";
                estudiantes[0, 5] = "Carrera";
                estudiantes[0, 6] = "Grado";

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error");
            }
        }

        public void Agrgar_Estudiantes()
        {
            try
            {
                for (int i = 1; i < estudiantes.GetLength(0); i++)
                {
                    Console.WriteLine(" \n");
                    for (int j = 0; j < estudiantes.GetLength(1); j++)
                    {
                        Console.Write("Inserte " + estudiantes[0, j] + ": ");
                        estudiantes[i, j] = Console.ReadLine();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void Modificar_Estudiante()
        {
            try
            {

                Console.Write("Matricula de estudiante a modificar: ");
                string matricula = Console.ReadLine();

                Console.Write("Inserte Campo a actualizar: ");
                string campo = Console.ReadLine();


                Console.Write("Inserte la nueva informacion: ");
                string informacion = Console.ReadLine();

                for (int i = 1; i < estudiantes.GetLength(0); i++)
                {
                    if (estudiantes[i, 0] == matricula)
                    {
                        for (int j = 0; j < estudiantes.GetLength(1); j++)
                        {
                            if (estudiantes[0, j] == campo)
                            {
                                estudiantes[i, j] = informacion;
                                Console.WriteLine("Actualizacion realizada con extio");
                                Buscar_Estudiante(matricula);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }



        }

        public void Eliminar_Estudiante()
        {
            bool eliminado = false;

            try
            {

                Console.Write("Matricula de estudiante a eliminar: ");
                string matricula = Console.ReadLine();

                for (int i = 1; i < estudiantes.GetLength(0); i++)
                {
                    if (estudiantes[i, 0] == matricula)
                    {
                        for (int j = 0; j < estudiantes.GetLength(1); j++)
                        {
                            estudiantes[i, j] = "";
                        }

                        eliminado = true;
                    }

                    if (eliminado)
                    {
                        Console.WriteLine("Se elimino con exito");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Buscar_Estudiante()
        {
            try
            {

                Console.Write("Matricula o nombre del estudiante: ");
                string nombre_matricula = Console.ReadLine();


                for (int i = 1; i < estudiantes.GetLength(0); i++)
                {
                    if (estudiantes[i, 0] == nombre_matricula || estudiantes[i, 1] == nombre_matricula)
                    {
                        for (int j = 0; j < estudiantes.GetLength(1); j++)
                        {
                            Console.Write(" || " + estudiantes[i, j] + " ");
                        }

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Buscar_Estudiante(string nombre_matricula)
        {
            try
            {

                for (int i = 1; i < estudiantes.GetLength(0); i++)
                {
                    if (estudiantes[i, 0] == nombre_matricula || estudiantes[i, 1] == nombre_matricula)
                    {
                        for (int j = 0; j < estudiantes.GetLength(1); j++)
                        {
                            Console.Write(" || " + estudiantes[i, j] + " \n");
                        }

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
