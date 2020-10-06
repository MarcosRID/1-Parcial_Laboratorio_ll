using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Entidades
{
    public class Producto
    {
        string nombre;
        double precio;
        int u_stock;
        int u_vendidas;
        int id;

        #region PROPIEDADES

        public string Nombre
        {
            get { return nombre; }
            //set {  nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    precio = value;
                }
            }
        }


        public int U_stock
        {
            get { return u_stock; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    u_stock = value;
                }
            }
        }

        public int U_vendidas
        {
            get { return u_vendidas; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    u_vendidas = value;
                }
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    id = value;
                }
            }
        }



        #endregion


        #region CONSTRUCTORES

        public Producto()
        {
            this.u_vendidas = 0;
        }

        public Producto(string auxNombre, double auxPrecio, int auxU_Stock) : this()
        {
            this.nombre = auxNombre;
            this.precio = auxPrecio;
            this.u_stock = auxU_Stock;
        }

        public Producto(string auxNombre, double auxPrecio, int auxU_Stock, int auxU_vendidas) : this(auxNombre, auxPrecio, auxU_Stock)
        {
            this.u_vendidas = auxU_vendidas;
        }

        public Producto(string auxNombre, double auxPrecio, int auxU_Stock, int auxU_vendidas, int auxId) : this(auxNombre, auxPrecio, auxU_Stock, auxU_vendidas)
        {
            this.id = auxId;
        }

        public Producto(int auxId, string auxNombre, double auxPrecio, int auxU_Stock) : this(auxNombre, auxPrecio, auxU_Stock)
        {
            this.id = auxId;
        }

        public Producto(int auxId, string auxNombre, double auxPrecio, int auxU_Stock, int auxU_vendidas) : this(auxNombre, auxPrecio, auxU_Stock, auxU_vendidas)
        {
            this.id = auxId;
        }

        #endregion


        #region METODOS

        /// <summary>
        /// Agrega un producto a la lista estatica del inventario.
        /// </summary>
        /// <param name="auxProducto"></param>
        public void Agregar_producto(Producto auxProducto)
        {
            Inventario.Lista_productos.Add(auxProducto);
        }
        #endregion

        #region SOBRECARGA_OPERADORES




        public static bool operator ==(int auxCodgo, Producto producto_2)
        {
            return auxCodgo == producto_2.id ? true : false;
        }

        public static bool operator !=(int auxCodgo, Producto producto_2)
        {
            return !(auxCodgo == producto_2);
        }




        public static bool operator ==(Producto auxProducto,ItemProducto auxItemProducto)
        {

            if (auxItemProducto != null && auxProducto != null)
            {
                return auxItemProducto.AuxProduto.id == auxProducto.id ? true : false;
            }

            return false;
        }

        public static bool operator !=(Producto auxProducto,ItemProducto auxItemProducto)
        {
            return !(auxProducto == auxItemProducto  );
        }




        #endregion



        #region IMPLICIT_EXPLICIT

        public static implicit operator Producto(ItemProducto auxItemProducto)
        {
            return auxItemProducto.AuxProduto;
        }

        /// <summary>
        /// calcua el precio de la cantidad N de un mismo producto
        /// </summary>
        /// <returns></returns>
        public double Cacular_precio_productos(Producto auxProducto, int auxCantidad)
        {
            return auxCantidad * auxProducto.precio;
        }
        #endregion

    }
}
