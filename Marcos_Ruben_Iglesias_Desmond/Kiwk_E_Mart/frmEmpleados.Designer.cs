namespace Kiwk_E_Mart
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Lista_Empleados = new System.Windows.Forms.ComboBox();
            this.lb_Empleado = new System.Windows.Forms.Label();
            this.dgv_Lista_Empleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Lista_Empleados
            // 
            this.cb_Lista_Empleados.BackColor = System.Drawing.Color.Beige;
            this.cb_Lista_Empleados.FormattingEnabled = true;
            this.cb_Lista_Empleados.Location = new System.Drawing.Point(318, 26);
            this.cb_Lista_Empleados.Name = "cb_Lista_Empleados";
            this.cb_Lista_Empleados.Size = new System.Drawing.Size(121, 21);
            this.cb_Lista_Empleados.TabIndex = 1;
            this.cb_Lista_Empleados.SelectedValueChanged += new System.EventHandler(this.cb_Lista_Empleados_SelectedValueChanged);
            // 
            // lb_Empleado
            // 
            this.lb_Empleado.AutoSize = true;
            this.lb_Empleado.Location = new System.Drawing.Point(181, 34);
            this.lb_Empleado.Name = "lb_Empleado";
            this.lb_Empleado.Size = new System.Drawing.Size(112, 13);
            this.lb_Empleado.TabIndex = 2;
            this.lb_Empleado.Text = "Seleccionar empleado";
            // 
            // dgv_Lista_Empleados
            // 
            this.dgv_Lista_Empleados.BackgroundColor = System.Drawing.Color.Beige;
            this.dgv_Lista_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_Empleados.Location = new System.Drawing.Point(107, 67);
            this.dgv_Lista_Empleados.Name = "dgv_Lista_Empleados";
            this.dgv_Lista_Empleados.Size = new System.Drawing.Size(427, 271);
            this.dgv_Lista_Empleados.TabIndex = 3;
            this.dgv_Lista_Empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_Empleados_CellContentClick);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(702, 363);
            this.Controls.Add(this.dgv_Lista_Empleados);
            this.Controls.Add(this.lb_Empleado);
            this.Controls.Add(this.cb_Lista_Empleados);
            this.Name = "frmEmpleados";
            this.RightToLeftLayout = true;
            this.Text = "Informe Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Lista_Empleados;
        private System.Windows.Forms.Label lb_Empleado;
        private System.Windows.Forms.DataGridView dgv_Lista_Empleados;
    }
}