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
    public partial class frmControl_Stock : Form
    {
        public frmControl_Stock()
        {
            InitializeComponent();
        }

        
        private void frmControl_Stock_Load(object sender, EventArgs e)
        {
           

        }

        private void cb_Selec_lista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indice = this.cb_Selec_lista.SelectedIndex;

            switch (indice)
            {
                case 0:
                    this.dgv_Listar_Filtrada.DataSource = Inventario.Listar_productos_Escasos(10);
                    this.dgv_Listar_Filtrada.AllowUserToResizeColumns = false;
                    this.dgv_Listar_Filtrada.AllowUserToResizeRows = false;
                    this.dgv_Listar_Filtrada.Size = new Size(400,20+ (20 * Inventario.Listar_productos_Escasos(10).Count));
                    this.dgv_Listar_Filtrada.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//Bloquea el encabezado
                    this.dgv_Listar_Filtrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Rellena el ancho de las filas
                    this.dgv_Listar_Filtrada.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    break;
                case 1:
                    this.dgv_Listar_Filtrada.DataSource = Inventario.Lista_productos;
                    this.dgv_Listar_Filtrada.AllowUserToResizeColumns = false;
                    this.dgv_Listar_Filtrada.AllowUserToResizeRows = false;
                    this.dgv_Listar_Filtrada.Size = new Size(400, (20 * Inventario.Lista_productos.Count));
                    this.dgv_Listar_Filtrada.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//Bloquea el encabezado
                    this.dgv_Listar_Filtrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Rellena el ancho de las filas
                    this.dgv_Listar_Filtrada.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    break;
            }


        }

      
    }
}
