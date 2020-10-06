using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemProducto 
    {

        Producto auxProduto;
        int cantidad;


        #region PROPIEDADES

        public Producto AuxProduto
        {
            get { return auxProduto; }
            set
            {
                if (value != null)
                {
                    auxProduto = value;
                }
            }
        }


        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (Validaciones.only_numer(value.ToString()) )
                {
                    cantidad = value;
                }
            }
        }



        #endregion


        #region CONSTRUCTORES

        public ItemProducto()
        {

        }

        public ItemProducto(Producto auxProducto , int auxCantidad)
        {
            this.auxProduto = auxProducto;
            this.cantidad = auxCantidad;
        }

        #endregion


        #region IMPLICIT_EXPLICIT

        public static implicit operator ItemProducto(Producto auxProducto)
        {
            ItemProducto auxItem = new ItemProducto();
            auxItem.auxProduto = auxProducto;
            auxItem.cantidad = 0;

            return auxItem;
        }
        #endregion

    }
}
