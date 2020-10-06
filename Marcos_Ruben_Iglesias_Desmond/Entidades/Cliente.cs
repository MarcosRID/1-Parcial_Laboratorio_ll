using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region ATRIIBUTOS

        List<ItemProducto> lista_Item_Productos;
        List<Producto> lista_Productos;
        List<int> canitdad;
        public bool flag;

        #endregion


        #region PROPIEDADES


        public List<ItemProducto> Lista_Item_Productos
        {
            get { return lista_Item_Productos; }
            set
            {
                if (value != null)
                {
                    flag = true;
                    lista_Item_Productos = value; // Solo tiene efecto esta linea
                    //this.Copiar_only_product(lista_Item_Productos); // Nunca se ejecuta
                }
            }
        }

        public List<Producto> Producto
        {
            get { return lista_Productos; }
        }

        public List<int> Canitdad
        {
            get { return canitdad; }
        }



        #endregion


        #region SETTERS

        public void SetCantidad(int indice, int auxCantidad)
        {
            if (indice > -1 && indice < lista_Item_Productos.Capacity && auxCantidad > -1)
            {
                this.lista_Item_Productos[indice].Cantidad = auxCantidad;
                this.Copiar_only_product();
            }
        }

        #endregion


        #region CONTRUCTORES

        public Cliente()
        {

        }

        public Cliente(string auxNombre, string auxApellido) : base(auxNombre, auxApellido)
        {
            lista_Productos = new List<Producto>();
            lista_Item_Productos = new List<ItemProducto>();
            canitdad = new List<int>();
        }

        #endregion


        #region METODOS



        /// <summary>
        /// Agrega un producto a al lista, actualizando. y a sus variantes.
        /// </summary>
        /// <param name="auxProducto"></param>
        public void Agregar_producto(Producto auxProducto)
        {
            if (auxProducto != null)
            {
                this.lista_Item_Productos.Add(auxProducto);
                this.Copiar_only_product();
            }
        } 
        
        public void Agregar_producto(ItemProducto auxItem)
        {
            if (auxItem != null)
            {
                this.lista_Item_Productos.Add(auxItem);
                this.Copiar_only_product();
            }
        }


        /// <summary>
        /// Actualiza una lista paralela de los productos actuales y su candidad
        /// </summary>
        /// <param name="auxItemProducto"></param>
        private void Copiar_only_product()
        {
            lista_Productos = null;
            canitdad = null;

            foreach (ItemProducto item in lista_Item_Productos)
            {
                if (item != null)
                {
                    canitdad.Add(item.Cantidad);
                    lista_Productos.Add(item.AuxProduto);
                }
            }
        }
        #endregion


        #region SOBRECARGA_OPERADORES

        public static bool operator ==(List<Cliente> auxLista, Cliente auxCliente)
        {
            bool okey = false;

            foreach (Cliente item in auxLista)
            {
                if (item.Nombre.ToString().Equals(auxCliente.Nombre) &&
                    item.Apellido.ToString().Equals(auxCliente.Apellido))
                {
                    okey = true;
                }
            }

            return okey;
        }

        public static bool operator !=(List<Cliente> auxLista, Cliente auxCliente)
        {
            return !(auxLista == auxCliente);
        }

        #endregion


        #region OVERRIDES

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine(this.apellido);

            return sb.ToString();
        }

        #endregion
    }
}
