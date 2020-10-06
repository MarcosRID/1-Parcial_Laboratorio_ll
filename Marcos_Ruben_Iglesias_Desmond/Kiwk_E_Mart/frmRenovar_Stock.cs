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
    public partial class frmRenovar_Stock : Form
    {
        Producto auxProduco;
        int indice;


        public frmRenovar_Stock()
        {
            auxProduco = new Producto();
            InitializeComponent();
        }



        private void frmRenovar_Stock_Load(object sender, EventArgs e)
        {
            auxProduco = null;

            this.dgv_Lista_productos.DataSource = Inventario.Lista_productos;
            this.dgv_Lista_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Rellena el ancho de las filas
        }


        /// <summary>
        /// Selecciono y guardo el producto y su indice de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Lista_productos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgv_Lista_productos.CurrentRow.Index;

            auxProduco = Inventario.Lista_productos[indice];

            this.lb_ProductoSelec.Text = auxProduco.Nombre;
        }


        /// <summary>
        /// Aceptar se agrega la cantidad establecida al producto seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int auxCantidad;

            if (auxProduco != null)
            {

                if (int.TryParse(this.txt_Cantidad.Text.ToString(), out auxCantidad) &&
                    auxCantidad > 0)
                {
                    Inventario.Lista_productos[indice].U_stock += auxCantidad;


                    this.dgv_Lista_productos.DataSource = null;
                    this.dgv_Lista_productos.DataSource = Inventario.Lista_productos;


                    MessageBox.Show($"Stock actual de {auxProduco.Nombre} es {auxProduco.U_stock} ", "Incremento Exitosa", MessageBoxButtons.OK);
                }
                else
                {
                    this.lb_Advertencia.Text = "Advetencia: La cantidad debe ser mayor a cero...";
                }

            }
            else
            {
                this.lb_Advertencia.Text = "Advetencia: No hay un producto seleccionado.";
            }
        }

        /// <summary>
        /// Verifica si desea cerrar la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

        /// <summary>
        ///  Verifica si desea cerrar la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRenovar_Stock_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

     
    }
}
