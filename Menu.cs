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
        public int dinero=100;
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
                        case 1:  VerEstructuras(); break;
                        case 2: CrearEstructuras(); break;
                        case 3: VerEnemigos(); break;
                            //case 4:  PasarTurno(); 
                    }
                    TurnoDelEnemigo();
                }

                else MensajeDeOpcionInvalida();
            }
        }

        public void CrearEstructuras()
        {
            Console.WriteLine("\n--- Crear Estructura ---");
            Console.WriteLine("1. Estructura de Recolección (Costo: 50, Vida: 10)");
            Console.WriteLine("2. Estructura de Mantenimiento (Costo: 60, Vida: 15)");
            Console.WriteLine("3. Estructura de Defensa (Costo: 80, Vida: 20, Daño: 5)");
            Console.Write("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1 && dinero >= 20)
            {
                estructuras.Add(new EstructuraRecoleccion("Recolección", 20, 10, 10));
                dinero -= 20;
                Console.WriteLine("Estructura de recolección creada.");
            }
            //else if (opcion == 2 && dinero >= 30)
            //{
            //    estructuras.Add(new EstructuraMantenimiento("Mantenimiento", 30, 15, 5));
            //    dinero -= 30;
            //    Console.WriteLine("Estructura de mantenimiento creada.");
            //}
            //else if (opcion == 3 && dinero >= 50)
            //{
            //    estructuras.Add(new EstructuraDefensa("Defensa", 50, 20, 5));
            //    dinero -= 50;
            //    Console.WriteLine("Estructura de defensa creada.");
            //}
            else
            {
                Console.WriteLine("No tienes suficiente dinero.");
            }

        }

        //Ver las estructuras actuales
        public void VerEstructuras()
        {
            Console.WriteLine("--- Estructuras ---");
            foreach (var estructura in estructuras)
            {
                Console.WriteLine($"{estructura.nombre} - Vida {estructura.vida}");
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
            if(enemigos.Count == 0 && turnosSobrevividos!=0)
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
            //VerificadorDeLista();
            CrearEnemigos();
            turnosConAlMenosUnEnemigoEnLaLista++;
            
            foreach(Enemigo enemigo in enemigos)
            {
                AtacarEstructura(enemigo);
            }          
            
        }
        public void AtacarEnemigos()
        {
           foreach (Enemigo enemigos in enemigos)
           {

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

        void MensajeDeOpcionInvalida()
        {
            Console.WriteLine("Opcion invalida, vuelva a marcar");
        }
    }
}

