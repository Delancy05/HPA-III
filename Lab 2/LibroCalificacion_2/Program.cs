using System;
namespace LibroCalificacion_2
{
    public class LibroPruebaCalificacion 
    {
        static void Main(string[] args)
        {
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();
            Console.WriteLine("Por favor  ingrese el nombre del curso: ");

            string nombreDelCurso = Console.ReadLine();
            Console.WriteLine();

            MyLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}
