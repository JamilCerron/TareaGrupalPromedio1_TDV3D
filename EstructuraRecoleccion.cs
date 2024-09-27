using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrupalPromedio1_TDV3D_Progra
{
    public  class EstructuraRecoleccion : Estructura
    {
        public int dineroPorTurno;
        public EstructuraRecoleccion(string nombre, int precio, int vida, int dineroPorTurno)
            : base(nombre, precio, vida)
        {
            this.dineroPorTurno = dineroPorTurno;
        }

        public override void AccionTurno()
        {
            Console.WriteLine($"{nombre} recolectó {dineroPorTurno} de dinero");
        }

    }
}
