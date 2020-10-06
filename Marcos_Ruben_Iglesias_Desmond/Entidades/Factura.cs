using Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwk_E_Mart
{
    public class Factura
    {
        #region ATRIBUTOS
        List<ItemProducto> lista_ItemProductos_comprados;
        double total_abonado;
        string employee;
        #endregion


        #region PROPIEDADES


        public List<ItemProducto> Lista_ItemProductos_comprados
        {
            get { return lista_ItemProductos_comprados; }
            set
            {
                if (value != null)
                {
                    lista_ItemProductos_comprados = value;
                }
            }
        }

        public double Total_abonado
        {
            get { return total_abonado; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    total_abonado = value;
                }
            }
        }

        public string Employee
        {
            get { return employee; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {

                    employee = value;
                }
            }
        }


        #endregion


        #region CONSTRUCTORES
        private Factura()
        {
            this.lista_ItemProductos_comprados = new List<ItemProducto>();
        }

        public Factura(List<ItemProducto> auxLista, double auxTotal_abonado, string auxEmployee) : this()
        {
            this.lista_ItemProductos_comprados = auxLista;
            this.total_abonado = auxTotal_abonado;
            this.employee = auxEmployee;
        }
        #endregion


    }
}
