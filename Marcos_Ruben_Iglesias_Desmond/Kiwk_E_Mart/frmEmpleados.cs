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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.cb_Lista_Empleados.DataSource = Enum.GetValues(typeof(EEmpleado)) ;
        }

        private void dgv_Lista_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_Lista_Empleados_SelectedValueChanged(object sender, EventArgs e)
        {


            this.dgv_Lista_Empleados.DataSource = Inventario.Lista_empleados[this.cb_Lista_Empleados.SelectedIndex].Lista_ventas;
            this.dgv_Lista_Empleados.AllowUserToResizeColumns = false;
            this.dgv_Lista_Empleados.AllowUserToResizeRows = false;
            this.dgv_Lista_Empleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//Bloquea el encabezado
            this.dgv_Lista_Empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Rellena el ancho de las filas
            this.dgv_Lista_Empleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
