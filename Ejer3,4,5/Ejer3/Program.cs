using Ejer3;

class Program
{
    static void Main()
    {
        Estudiante estudiante1 = new Estudiante("Juan", 20, 8.5f);
        
        //Imprimir atributos
        Console.WriteLine("Estudiante 1");
        Console.WriteLine("Nombre: "+estudiante1.Nombre);
        Console.WriteLine("Edad: " + estudiante1.Edad);
        Console.WriteLine("Calificación: " + estudiante1.Calificacion);


        Estudiante estudiante2 = new Estudiante("María", 22, 9.2f);
        //Imprimir datos con método
        Console.WriteLine("\nEstudiante 2");
        estudiante2.imprimirDatos();

        EstudianteGraduado estudiante3 = new EstudianteGraduado("Luis", 24, 8.3f, "Administracion");
        Console.WriteLine("\nEstudiante 3");
        estudiante3.imprimirDatos();
    }
}
