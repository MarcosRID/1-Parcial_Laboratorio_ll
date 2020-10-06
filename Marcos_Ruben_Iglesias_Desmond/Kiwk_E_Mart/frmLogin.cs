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
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btm_Aceptar_Click(object sender, EventArgs e)
        {
            string usuario = txt_NameUsuairo.Text.ToString();
            string pass = txt_PassUsuario.Text.ToString();

            if (!String.IsNullOrEmpty(usuario) &&
                !String.IsNullOrEmpty(pass) &&
                !String.IsNullOrWhiteSpace(usuario) &&
                !String.IsNullOrWhiteSpace(pass))
            {

                if (Inventario.Validar_login(usuario, pass))
                {
                    this.DialogResult = DialogResult.OK;

                    int contador = 0;
                    foreach (KeyValuePair<string, string> item in Inventario.Lista_empleados_UP)
                    {
                        if (item.Key.Equals(usuario))
                        {
                            Inventario.Empleado_actual = (EEmpleado)contador; ;
                            break;
                        }
                        contador++;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o clave erronea...", "Login erroneo");
                }


            }
            else
            {
                MessageBox.Show("Falto llenar algun campo", "Error... Login");
            }
        }

        private void btm_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Usuario: Apu\nClave: pass123\n\n Usuario: Sanjay\nClave: pass123";
        }
    }
}
