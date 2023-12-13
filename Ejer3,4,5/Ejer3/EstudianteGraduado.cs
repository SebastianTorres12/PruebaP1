using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    internal class EstudianteGraduado : Estudiante
    {
        //Atributos
        private string titulo;

        // Get y Set de atributos
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        //Constructor de la clase
        
        public EstudianteGraduado(string _nombre, int _edad, float _calificacion, string _titulo)
        : base(_nombre,_edad,_calificacion)
        {
            Titulo = _titulo;
        }

        public new void imprimirDatos()
        {
            base.imprimirDatos();
            Console.WriteLine("Título: " + Titulo);
        }

    }
}
