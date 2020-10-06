using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Kiwk_E_Mart
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region METODOS


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
   
            Inventario.Lista_empleados.Add(new Empleado("Apu", "Nahasapeemapetilon"));
            Inventario.Lista_empleados.Add(new Empleado("Sanjay", "Nahasapeemapetilon"));

            Inventario.Harcodear_lista_Empleados();

            frmLogin auxFrmLogin = new frmLogin();

            switch (auxFrmLogin.ShowDialog())
            {

                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    this.Close();
                    break;
            }



            // Id minimo
            Inventario.Ultimo_id = 1000;

            // harcodeo la lista cliente (cargo clientes)
            Inventario.Harcodear_lista_clientes();

            //Cargo el inventario.
            Inventario.Harcodear_lista();
            Inventario.Ultimo_id = Inventario.Lista_productos[Inventario.Lista_productos.Count - 1].Id;

            /* opciones para el combobox del form "Contro Stock" */
            Inventario.Titulos_filtrado.Add("Stock menos a 10");
            Inventario.Titulos_filtrado.Add("Todos");

            int aux = Inventario.Ultimo_id;


        }


        /// <summary>
        /// LLama a formulario Agregar_nuevo_producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarNuevoProcutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar_producto auxFrmAgregar_Producto = new frmAgregar_producto();

            auxFrmAgregar_Producto.ShowDialog();

        }

        /// <summary>
        /// LLama al formulario Realiza_nueva_compra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realizarNuevasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenovar_Stock auxFrmRenovar_Stock = new frmRenovar_Stock();

            auxFrmRenovar_Stock.ShowDialog();

        }

        private void controlDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControl_Stock auxFrmControl_Stock = new frmControl_Stock();


            auxFrmControl_Stock.Cb_Selec_lista.DataSource = Inventario.Titulos_filtrado;

            auxFrmControl_Stock.ShowDialog();

            auxFrmControl_Stock.Cb_Selec_lista.DataSource = null;
            auxFrmControl_Stock.Cb_Selec_lista.Items.Clear();

        }


        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRealizar_Compra auxFrmRealizar_Compra = new frmRealizar_Compra();

            auxFrmRealizar_Compra.ShowDialog();


        }



        #endregion

        private void ventasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados auxFrmEmpleados = new frmEmpleados();

            auxFrmEmpleados.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias Vuelva Prontosssss!!!!");
        }
    }
}

