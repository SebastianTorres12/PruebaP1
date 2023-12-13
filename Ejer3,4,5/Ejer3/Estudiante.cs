using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    internal class Estudiante
    {
        //Atributos
        private string nombre;
        private int edad;
        private float calificacion;

        // Get y Set de atributos
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public float Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        //Constructor de la clase
        public Estudiante(string _nombre, int _edad, float _calificacion)
        {
            Nombre = _nombre;
            Edad = _edad;
            Calificacion = _calificacion;
        }

        //Métodos
        public void imprimirDatos() {
            Console.WriteLine("Nombre: " + Nombre + "\nEdad: " + Edad + "\nCalificación: " + Calificacion);
        }
    }
}
