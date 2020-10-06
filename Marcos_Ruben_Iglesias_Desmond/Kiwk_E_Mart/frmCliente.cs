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
    public partial class frmCliente : Form
    {

        Cliente auxCliente;
        int indice;

        public frmCliente()
        {
            InitializeComponent();
        }

        #region PROPIEDADES


        public Cliente AuxCliente
        {
            get { return auxCliente; }
            //set { auxCliente = value; }
        }
        public int Indice
        {
            get { return indice; }
            //set { indice = value; }
        }


        #endregion

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.dgv_Lista_cliente.DataSource = Inventario.Lista_clientes;
            this.dgv_Lista_cliente.AllowUserToResizeColumns = false;
            this.dgv_Lista_cliente.AllowUserToResizeRows = false;
            this.dgv_Lista_cliente.Size = new Size(400, (20 * Inventario.Lista_clientes.Count));
            this.dgv_Lista_cliente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//Bloquea el encabezado
            this.dgv_Lista_cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Rellena el ancho de las filas
            this.dgv_Lista_cliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Lista_cliente.Columns.Remove("Dni");
        }


        private void btm_Agregar_Click(object sender, EventArgs e)
        {
            string auxNombre = this.txt_new_nombre.Text.ToString();
            string auxApellido = this.txt_new_apellido.Text.ToString();
            Cliente auxCliente = new Cliente(auxNombre, auxApellido);

            if (!String.IsNullOrEmpty(auxNombre) &&
                !String.IsNullOrEmpty(auxApellido))
            {
                if ((Inventario.Lista_clientes != auxCliente))
                {
                    Inventario.Lista_clientes.Add(auxCliente);
                    this.dgv_Lista_cliente.DataSource = null;
                    this.dgv_Lista_cliente.DataSource = Inventario.Lista_clientes;
                    this.dgv_Lista_cliente.Columns.Remove("Dni");
                }
                else
                {
                    MessageBox.Show($"El cliente {auxNombre} {auxApellido} ya se encuentra dado de alta", "Usuario existente", MessageBoxButtons.OK);
                }
            }
        }

        private void dgv_Lista_cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indice = this.dgv_Lista_cliente.CurrentRow.Index;
            this.auxCliente = new Cliente();
            this.auxCliente = Inventario.Lista_clientes[indice];

            if (MessageBox.Show($"¿Desea realizar una compra con {auxCliente.Nombre} {auxCliente.Apellido}?", "Confirmar Cliente", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
