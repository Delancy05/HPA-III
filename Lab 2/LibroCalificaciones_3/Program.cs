namespace LibroCalificaciones_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibroCalificaciones myLibro = new LibroCalificaciones("CS101 Programación en C#");
            LibroCalificaciones mylibro2 = new LibroCalificaciones("CS102 Estructuras de Datos");
            Console.WriteLine("El nombre del curso es: {0}", myLibro.NombreCurso);
            Console.WriteLine("El nombre del curso es: {0}", mylibro2.NombreCurso);

            Console.WriteLine("\nEscriba el nombre del curso:");
            string elNombreCurso = Console.ReadLine();
            myLibro.NombreCurso = elNombreCurso;
            Console.WriteLine("el nombre del curso es: {0}", myLibro.NombreCurso);
        }
    }
}
