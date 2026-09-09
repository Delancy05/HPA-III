// Crea el objeto LibroCalificaciones e invoca a su método DeterminarPromedio.
public class PruebalibroCalificaciones
{
    public static void Main(string[] args)
    {
        // crea el objeto milibroCalificaciones y
        // pasa el nombre del curso al constructor
        LibroCalificaciones milibroCalificaciones = new LibroCalificaciones(
            "CS101 Introducción a la programación en C#");

        milibroCalificaciones.MostrarMensaje(); // muestra el mensaje de bienvenida
        milibroCalificaciones.DeterminaPromedioClase(); // encuentra el promedio de
        // calificaciones
    } // fin de Main
} // fin de la clase PruebalibroCalificaciones
