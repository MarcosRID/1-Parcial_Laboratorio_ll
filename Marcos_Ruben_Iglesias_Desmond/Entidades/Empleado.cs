using Kiwk_E_Mart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EEmpleado
    {
        Apu,
        Sanjay
    }

    public class Empleado : Persona
    {

        double salario;
        public List<Factura> lista_ventas;


        public List<Factura> Lista_ventas
        {
            get { return lista_ventas; }
            set
            {
                if (value != null)
                {
                    lista_ventas = value;
                }
            }
        }



        public Empleado(string auxNobre, string auxApellido) : base(auxNobre, auxApellido)
        {
            lista_ventas = new List<Factura>();
        }
    }
}
