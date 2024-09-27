using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPromedio1_TDV3D_Progra
{
    internal class Enemigo
    {
        public string nombre="DemoledorDeEstructuras";
        public int vida=100;
        public int danio=50;

        Enemigo(string nombre, int vida, int danio)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.danio = danio;
        }

        public void EstaVivo()
        {

        }
        
    }
}
