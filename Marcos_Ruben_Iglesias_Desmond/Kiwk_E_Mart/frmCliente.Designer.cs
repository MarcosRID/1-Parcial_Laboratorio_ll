namespace Kiwk_E_Mart
{
    partial class frmCliente
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
            this.dgv_Lista_cliente = new System.Windows.Forms.DataGridView();
            this.lb_Nuevo_cliente = new System.Windows.Forms.Label();
            this.txt_new_nombre = new System.Windows.Forms.TextBox();
            this.btm_Agregar = new System.Windows.Forms.Button();
            this.txt_new_apellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lista_cliente
            // 
            this.dgv_Lista_cliente.AllowUserToAddRows = false;
            this.dgv_Lista_cliente.AllowUserToDeleteRows = false;
            this.dgv_Lista_cliente.AllowUserToResizeColumns = false;
            this.dgv_Lista_cliente.AllowUserToResizeRows = false;
            this.dgv_Lista_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_cliente.Location = new System.Drawing.Point(2, 2);
            this.dgv_Lista_cliente.MultiSelect = false;
            this.dgv_Lista_cliente.Name = "dgv_Lista_cliente";
            this.dgv_Lista_cliente.ReadOnly = true;
            this.dgv_Lista_cliente.Size = new System.Drawing.Size(10, 10);
            this.dgv_Lista_cliente.TabIndex = 0;
            this.dgv_Lista_cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_cliente_CellDoubleClick);
            // 
            // lb_Nuevo_cliente
            // 
            this.lb_Nuevo_cliente.AutoSize = true;
            this.lb_Nuevo_cliente.Location = new System.Drawing.Point(570, 65);
            this.lb_Nuevo_cliente.Name = "lb_Nuevo_cliente";
            this.lb_Nuevo_cliente.Size = new System.Drawing.Size(73, 13);
            this.lb_Nuevo_cliente.TabIndex = 1;
            this.lb_Nuevo_cliente.Text = "Nuevo cliente";
            // 
            // txt_new_nombre
            // 
            this.txt_new_nombre.BackColor = System.Drawing.Color.Beige;
            this.txt_new_nombre.Location = new System.Drawing.Point(547, 98);
            this.txt_new_nombre.Name = "txt_new_nombre";
            this.txt_new_nombre.Size = new System.Drawing.Size(124, 20);
            this.txt_new_nombre.TabIndex = 2;
            // 
            // btm_Agregar
            // 
            this.btm_Agregar.BackColor = System.Drawing.Color.Beige;
            this.btm_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_Agregar.Location = new System.Drawing.Point(547, 191);
            this.btm_Agregar.Name = "btm_Agregar";
            this.btm_Agregar.Size = new System.Drawing.Size(124, 26);
            this.btm_Agregar.TabIndex = 3;
            this.btm_Agregar.Text = "Agregar";
            this.btm_Agregar.UseVisualStyleBackColor = false;
            this.btm_Agregar.Click += new System.EventHandler(this.btm_Agregar_Click);
            // 
            // txt_new_apellido
            // 
            this.txt_new_apellido.BackColor = System.Drawing.Color.Beige;
            this.txt_new_apellido.Location = new System.Drawing.Point(547, 138);
            this.txt_new_apellido.Name = "txt_new_apellido";
            this.txt_new_apellido.Size = new System.Drawing.Size(124, 20);
            this.txt_new_apellido.TabIndex = 4;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_new_apellido);
            this.Controls.Add(this.btm_Agregar);
            this.Controls.Add(this.txt_new_nombre);
            this.Controls.Add(this.lb_Nuevo_cliente);
            this.Controls.Add(this.dgv_Lista_cliente);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Lista_cliente;
        private System.Windows.Forms.Label lb_Nuevo_cliente;
        private System.Windows.Forms.TextBox txt_new_nombre;
        private System.Windows.Forms.Button btm_Agregar;
        private System.Windows.Forms.TextBox txt_new_apellido;
    }
}