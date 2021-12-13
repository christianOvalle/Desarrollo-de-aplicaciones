using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConArreglos
{
    class Alumno
    {

       public string nombre;
       public string matricula;
       public float nota;


        public Alumno() {

            this.nombre = "";
            this.matricula = "";
            this.nota = 0;
        
        }

        public Alumno(string nombre, string matricula, float nota) {

            this.nombre = nombre;
            this.matricula = matricula;
            this.nota = nota;
        
        }
    }


    
}
