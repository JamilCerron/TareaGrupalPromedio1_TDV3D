using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPromedio1_TDV3D_Progra
{
    internal class Menu
    {
        public List<Estructura> estructuras=new List<Estructura>();
        public List<Enemigo> enemigos = new List<Enemigo>();
        public int dinero;
        public int turnosConAlMenosUnEnemigoEnLaLista;
        public int turnosSobrevividos=1;
        bool continuarMenu=true;
        public  void EjecutarMenu()
        {
            while (continuarMenu)
            {
                
                Console.WriteLine($"Turno {turnosSobrevividos}");
                Console.WriteLine("Seleccione una de las siguientes opciones");
                Console.WriteLine("1.Ver estructuras disponibles");
                Console.WriteLine("2.Crear nuevas estructuras");
                Console.WriteLine("3.Ver la lista de enemigos");
                Console.WriteLine("4.Pasar turno");

                string entradaOpcion = Console.ReadLine();

                if (int.TryParse(entradaOpcion, out int opcion) && (opcion <= 4 && opcion >= 1))
                {
                    switch (opcion)
                    {
                        case 1: // VerEstructuras();
                        case 2: // CrearEstructuras();
                        case 3: VerEnemigos(); break;
                            //case 4:  PasarTurno(); 
                    }
                    TurnoDelEnemigo();
                }
            }
        }
            

        public int MetodoFibonacci(int turnosConALMenosUnEnemigoEnLaLista)
        {
            int a1 = 0, a2 = 1, a3=0;

            if (turnosConAlMenosUnEnemigoEnLaLista == 0) { return 0; }

            else if (turnosConAlMenosUnEnemigoEnLaLista == 1) { return 1; }

            else
            {
                for (int i = 0; i < turnosConALMenosUnEnemigoEnLaLista-1; i++)
                {
                    a3 = a1 + a2;
                    a1 = a2;
                    a2 = a3;
                }
                return a3;
            }       
        }

        public void CrearEnemigos()
        {
            Console.WriteLine("La lista de enemigos es la siguiente:");

            if(turnosConAlMenosUnEnemigoEnLaLista== 0)
            { 
                    Console.WriteLine("No hay enemigos actualmente");
            }

            else
            {
                for (int i = 0; i < MetodoFibonacci(turnosConAlMenosUnEnemigoEnLaLista); i++)
                {
                    Enemigo nuevoEnemigo = new Enemigo("DemoledorDeEstructuras", 100, 50);
                    Console.Write($"{i + 1}.{nuevoEnemigo.nombre} "); Console.WriteLine($"Vida= {nuevoEnemigo.vida}");
                }
            }

            
            
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
                Console.Write($"{indice}. {enemigo.nombre}");
                indice++;
            }
        }

        public void TurnoDelEnemigo()
        {
            CrearEnemigos();
            turnosConAlMenosUnEnemigoEnLaLista++;
            
            foreach(Enemigo enemigo in enemigos)
            {
                AtacarEstructura(enemigo);
            }

           
            
        }

        private void AtacarEstructura(Enemigo enemigo)
        {
            //Estructura objetivo = null;

           
            //objetivo = estructuras.OfType<EstructuraDefensa>().FirstOrDefault();

            //if (objetivo == null) 
            //{
            //    objetivo = estructuras.OfType<EstructuraMantenimiento>().FirstOrDefault();
            //}
            //if (objetivo == null) 
            //{
            //    objetivo = estructuras.OfType<EstructuraRecoleccion>().FirstOrDefault();
            //}

           
            //if (objetivo != null)
            //{
            //    objetivo.RecibirAtaque(enemigo.daño); 
            //}
            //else
            //{
            //    Console.WriteLine("No hay estructuras para atacar.");
            //}
        }
    }
}

