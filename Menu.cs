using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPromedio1_TDV3D_Progra
{
    internal class Menu
    {
        //public List<Estructura>();
        public List<Enemigo> enemigos = new List<Enemigo>();
        public int dinero;
        public int fibonacciIndex;
        public int turnosSobrevividos;
        public int turnosConAlMenosUnEnemigoEnLaLista;
        public  void EjecutarMenu()
        {
            Console.WriteLine($"Turno {turnosSobrevividos}");
            Console.WriteLine("Seleccione una de las siguientes opciones");
            Console.WriteLine("1.Ver estructuras disponibles");
            Console.WriteLine("2.Crear nuevas estructuras");
            Console.WriteLine("3.Ver la lista de enemigos");
            Console.WriteLine("4.Pasar turno");

            string entradaOpcion= Console.ReadLine();

            if (int.TryParse(entradaOpcion, out int opcion) && (opcion<=4 && opcion>=1))
            {
                switch(opcion)
                {
                    case 1: // VerEstructuras();
                    case 2: // CrearEstructuras();
                    case 3:   VerEnemigos(); break;
                    //case 4:  PasarTurno(); 
                }
            }
        }

        public int MetodoFibonacci(int turnosConALMenosUnEnemigoEnLaLista)
        {
            int a1 = 0, a2 = 1, a3=0;

            for (int i = 0; i < turnosConALMenosUnEnemigoEnLaLista; i++)
            {
                a3 = a1 + a2;
                a1 = a2;
                a2 = a3;
            }
            return a3;
        }

        public void CrearEnemigos()
        {

        }

        public void VerificadorDeLista()
        {
            if(enemigos.Count == 0)
            {
                turnosConAlMenosUnEnemigoEnLaLista = 0;
            }
        }
        public void VerEnemigos()
        {
            int indice = 0;
            foreach ( Enemigo enemigo in enemigos)
            {
                Console.WriteLine($"{indice}. {enemigo.nombre}");
                indice++;
            }
        }

        public void TurnoDelEnemigo()
        {

        }
    }
}
