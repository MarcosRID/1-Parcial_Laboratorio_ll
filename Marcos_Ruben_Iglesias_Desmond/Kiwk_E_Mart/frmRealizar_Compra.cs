using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwk_E_Mart
{
    public partial class frmRealizar_Compra : Form
    {
        #region ATRIBUTOS

        double precio_estimado;
        Cliente auxCliente;
        Producto auxProducto;
        ItemProducto auxItemProducto;
        List<Producto> auxLista_Productos_gondola;
        List<Producto> auxLista_Productos_carrito;
        List<int> lista_cantidad;//Guardo la cantidad inicial para los productos en el carrito
        bool flag_column = true;

        #endregion



        public frmRealizar_Compra()
        {
            lista_cantidad = new List<int>();
            auxLista_Productos_gondola = new List<Producto>();
            auxLista_Productos_carrito = new List<Producto>();
            InitializeComponent();
        }



        private void frmRealizar_Compra_Load(object sender, EventArgs e)
        {
            frmCliente auxFrmCliente = new frmCliente();

            // Al cancelar no entra al if
            if (auxFrmCliente.ShowDialog() != DialogResult.Cancel)
            {
                auxCliente = new Cliente();
                this.auxCliente = auxFrmCliente.AuxCliente;
                this.lb_NombreApellido.Text = auxCliente.ToString();

                auxLista_Productos_gondola = Inventario.Lista_productos_gondola();
                this.dgv_Gondola.DataSource = auxLista_Productos_gondola;
                this.dgv_Gondola.AllowUserToResizeRows = false;
                this.dgv_Gondola.Size = new Size(400, 20 + (20 * Inventario.Lista_productos_gondola().Count));
                this.dgv_Gondola.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//Bloquea el encabezado
                this.dgv_Gondola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Rellena el ancho de las filas
                this.dgv_Gondola.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dgv_Gondola.AllowUserToResizeColumns = false;

                this.dgv_Gondola.Columns.Remove("U_stock");
                this.dgv_Gondola.Columns.Remove("U_vendidas");
                this.dgv_Gondola.Columns.Remove("id");

                this.btn_Eliminar_item_carrito.Enabled = false;
                this.nud_cantidad.Enabled = false;
                this.btn_Comprar.Enabled = false;
            }

        }



        /// <summary>
        /// Administra la gondola del DataGridVew que interactua con el cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Gondola_DoubleClick(object sender, EventArgs e)
        {
            bool flag = false;
            //this.nud_cantidad.Value = 1;
            auxProducto = new Producto();
            auxItemProducto = new ItemProducto();


            auxProducto = (Producto)this.dgv_Gondola.CurrentRow.DataBoundItem;
            auxItemProducto.AuxProduto = auxProducto;
            auxItemProducto.Cantidad = 1;


            //Busco si se encuentra el producto en el carrito.
            foreach (Producto item in auxLista_Productos_carrito)
            {
                if (item != null && auxProducto != null && (item.Id == auxProducto))
                {
                    flag = true;
                    break;
                }
            }


            // De no estar estar el producto en el carrito , lo añado al carrito y al cliente.
            if (!flag)
            {
                auxLista_Productos_carrito.Add(auxProducto);
                auxCliente.Lista_Item_Productos.Add(auxItemProducto);


                if (flag_column)
                {
                    this.dgv_Carrito.Columns.Add("Columna_cantidad", "Cantidad");

                    flag_column = false;
                }

                /************************ SIMPLIFICAR *************************/
                foreach (ItemProducto item in auxCliente.Lista_Item_Productos)
                {
                    precio_estimado += (item.AuxProduto.Precio * item.Cantidad);
                }
                this.txt_Precio_estimado.Text = precio_estimado.ToString();
                precio_estimado = 0;
                /**************************************************************/

                this.dgv_Carrito.DataSource = null;
                this.dgv_Carrito.DataSource = auxLista_Productos_carrito;


                int indiceRow = this.dgv_Carrito.Rows.Count - 1;
                this.dgv_Carrito.Rows[indiceRow].Cells[0].Value = 1;
                lista_cantidad.Add((int)this.dgv_Carrito.Rows[indiceRow].Cells[0].Value);

                

                for (int i = 0; i < lista_cantidad.Count; i++)
                {
                    this.dgv_Carrito.Rows[i].Cells[0].Value = lista_cantidad[i];
                }

                this.dgv_Carrito.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//Bloquea el encabezado
                this.dgv_Carrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Rellena el ancho de las filas
                this.dgv_Carrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dgv_Carrito.AllowUserToResizeColumns = false;

                this.dgv_Carrito.Columns.Remove("U_stock");
                this.dgv_Carrito.Columns.Remove("U_vendidas");
                this.dgv_Carrito.Columns.Remove("id");


                this.btn_Eliminar_item_carrito.Enabled = true;
                this.nud_cantidad.Enabled = true;
                this.btn_Comprar.Enabled = true;
            }
            else
            {
                MessageBox.Show("El item ya se encuentra en el carrito");
            }
        }



        /// <summary>
        /// Agrega un producto al carrito de compras 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Carrito_Click(object sender, EventArgs e)
        {
            if (!((int)this.dgv_Carrito.Rows.Count == 0) && this.dgv_Carrito.DataSource != null)
            {
                int cantidad;
                int.TryParse(this.dgv_Carrito.CurrentRow.Cells[0].Value.ToString(), out cantidad);
                this.nud_cantidad.Value = cantidad;


            }
        }



        /// <summary>
        /// Encargado de actualizar el precio estimado, cantidad de cada producto y actualizar la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (this.dgv_Carrito.DataSource != null)
            {
                this.dgv_Carrito.CurrentRow.Cells[0].Value = this.nud_cantidad.Value;


                for (int i = 0; i < auxCliente.Lista_Item_Productos.Count; i++)
                {

                    if (auxCliente.Lista_Item_Productos[i].AuxProduto.Id == ((Producto)(this.dgv_Carrito.CurrentRow.DataBoundItem)).Id && auxCliente.Lista_Item_Productos[i].AuxProduto.U_stock >= this.nud_cantidad.Value)
                    {
                        auxCliente.Lista_Item_Productos[i].Cantidad = (int)this.nud_cantidad.Value;

                        //Actualizo la lista paralela de cantidad (paralela a los productos).
                        lista_cantidad[i] = int.Parse(this.dgv_Carrito.Rows[i].Cells[0].Value.ToString());

                        foreach (ItemProducto item in auxCliente.Lista_Item_Productos)
                        {
                            precio_estimado += (item.AuxProduto.Precio * item.Cantidad);
                        }
                        this.txt_Precio_estimado.Text = precio_estimado.ToString();
                        precio_estimado = 0;

                    }
                }
            }
        }


        /// <summary>
        /// Elimina un producto de el carrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_item_carrito_Click(object sender, EventArgs e)
        {

            int fila_actual = this.dgv_Carrito.CurrentRow.Index;
            auxProducto = (Producto)this.dgv_Carrito.CurrentRow.DataBoundItem;

            auxLista_Productos_carrito.Remove(auxProducto);
            auxCliente.Lista_Item_Productos.Remove(auxCliente.Lista_Item_Productos[fila_actual]);
            lista_cantidad.Remove(lista_cantidad[fila_actual]);
            
            this.dgv_Carrito.DataSource = null;
            this.dgv_Carrito.DataSource = auxLista_Productos_carrito;

            this.dgv_Carrito.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//Bloquea el encabezado
            this.dgv_Carrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Rellena el ancho de las filas
            this.dgv_Carrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Carrito.AllowUserToResizeColumns = false;
            this.dgv_Carrito.Columns.Remove("U_stock");
            this.dgv_Carrito.Columns.Remove("U_vendidas");
            this.dgv_Carrito.Columns.Remove("id");


            for (int i = 0; i < lista_cantidad.Count; i++)
            {
                this.dgv_Carrito.Rows[i].Cells[0].Value = lista_cantidad[i];
            }

            /************************ SIMPLIFICAR *************************/
            foreach (ItemProducto item in auxCliente.Lista_Item_Productos)
            {
                precio_estimado += (item.AuxProduto.Precio * item.Cantidad);
            }
            this.txt_Precio_estimado.Text = precio_estimado.ToString();
            precio_estimado = 0;
            /**************************************************************/

            if ((int)this.dgv_Carrito.Rows.Count == 0)
            {
                this.btn_Eliminar_item_carrito.Enabled = false;
                this.nud_cantidad.Enabled = false;
                this.btn_Comprar.Enabled = false;
            }
        }



        private void btn_Comprar_Click(object sender, EventArgs e)
        {
                            
            Inventario.Descontar_stock(auxCliente.Lista_Item_Productos);

            double total = Inventario.Calcular_monto(auxCliente.Lista_Item_Productos);

            if (auxCliente.Apellido.Equals("simpson"))
            {
                total -= (total * 0.13);
            }

            Factura nueva_fatctura = new Factura(auxCliente.Lista_Item_Productos,total,Inventario.Empleado_actual.ToString());

            foreach (Empleado item in Inventario.Lista_empleados)
            {
                if (item.Nombre.Equals(Inventario.Empleado_actual.ToString()))
                {
                    item.Lista_ventas.Add(nueva_fatctura);
                }
            }

            Inventario.Lista_facturas.Add(nueva_fatctura);

            MessageBox.Show("Se realizo con exito la compra", "Finalizar compra");
            this.DialogResult = DialogResult.OK;
        }
    }
}

