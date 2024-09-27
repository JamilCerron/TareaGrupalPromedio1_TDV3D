using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPromedio1_TDV3D_Progra
{
    public class Estructura
    {
        public string nombre;
        public int precio;
        public int vida;

        public Estructura(string nombre, int precio, int vida)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.vida = vida;
        }

        public virtual  void AccionTurno() { }

        public bool EstaDestruidad()
        {
            return vida <= 0;
        }

        
    }
}
