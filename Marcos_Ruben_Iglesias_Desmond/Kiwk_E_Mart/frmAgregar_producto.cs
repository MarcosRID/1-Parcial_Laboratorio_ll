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
    public partial class frmAgregar_producto : Form
    {

        public frmAgregar_producto()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Confirma la salida del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAgregar_producto_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.txt_Nombre.Text != String.Empty ||
                this.txt_Cantidad.Text != String.Empty ||
                this.txt_Precio.Text != String.Empty)
            {
                if (MessageBox.Show("Aun hay datos ingresados sin guardar.\n ¿Desea salir?  ", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


        /// <summary>
        /// Agrega un nuevo producto a la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            string auxNombre = this.txt_Nombre.Text.ToString();
            string auxPrecio_S = this.txt_Precio.Text.ToString();
            string auxCantidad_S = this.txt_Cantidad.Text.ToString();

            double auxPrecio;
            int auxCantidad;

            if (!String.IsNullOrEmpty(auxNombre) &&
                !String.IsNullOrEmpty(auxCantidad_S) &&
                !String.IsNullOrEmpty(auxPrecio_S) &&
                !String.IsNullOrWhiteSpace(auxNombre) &&
                !String.IsNullOrWhiteSpace(auxCantidad_S) &&
                !String.IsNullOrWhiteSpace(auxPrecio_S))
            {
                if (Validaciones.only_Chars_and_Space(auxNombre) &&
                    int.TryParse(auxCantidad_S, out auxCantidad) &&
                    double.TryParse(auxPrecio_S, out auxPrecio))
                {
                    Inventario.Ultimo_id++;
                    Inventario.Lista_productos.Add(new Producto(Inventario.Ultimo_id, auxNombre, auxPrecio, auxCantidad));


                    this.txt_Nombre.Text = String.Empty;
                    this.txt_Precio.Text = String.Empty;
                    this.txt_Cantidad.Text = String.Empty;

                    this.lb_Mensaje.Text = "Operacion exitosa!!!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ¿Seguro desea cancelar la operacio?  ", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
