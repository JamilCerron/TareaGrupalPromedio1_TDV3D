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

        //para clase Juego ;no esta creada . lo guardo aqui por mientras; -- enemigos apariciones 
        private int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            if (n == 0) { return a; }
            if (n == 1) { return b; }

            for (int k = 2; k <= n; k++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

    }
}
