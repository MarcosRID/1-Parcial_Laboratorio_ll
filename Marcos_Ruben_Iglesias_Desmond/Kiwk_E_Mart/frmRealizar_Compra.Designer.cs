namespace Kiwk_E_Mart
{
    partial class frmRealizar_Compra
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
            this.dgv_Gondola = new System.Windows.Forms.DataGridView();
            this.dgv_Carrito = new System.Windows.Forms.DataGridView();
            this.lb_Selec_productos = new System.Windows.Forms.Label();
            this.lc_carrito = new System.Windows.Forms.Label();
            this.lb_Cliente = new System.Windows.Forms.Label();
            this.lb_NombreApellido = new System.Windows.Forms.Label();
            this.txt_Precio_estimado = new System.Windows.Forms.TextBox();
            this.lb_Precio_estimado = new System.Windows.Forms.Label();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_Eliminar_item_carrito = new System.Windows.Forms.Button();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.lb_Contador_cantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gondola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Gondola
            // 
            this.dgv_Gondola.AllowUserToDeleteRows = false;
            this.dgv_Gondola.BackgroundColor = System.Drawing.Color.Beige;
            this.dgv_Gondola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Gondola.Location = new System.Drawing.Point(15, 46);
            this.dgv_Gondola.MaximumSize = new System.Drawing.Size(302, 344);
            this.dgv_Gondola.MultiSelect = false;
            this.dgv_Gondola.Name = "dgv_Gondola";
            this.dgv_Gondola.ReadOnly = true;
            this.dgv_Gondola.Size = new System.Drawing.Size(302, 344);
            this.dgv_Gondola.TabIndex = 0;
            this.dgv_Gondola.DoubleClick += new System.EventHandler(this.dgv_Gondola_DoubleClick);
            // 
            // dgv_Carrito
            // 
            this.dgv_Carrito.AllowUserToDeleteRows = false;
            this.dgv_Carrito.BackgroundColor = System.Drawing.Color.Beige;
            this.dgv_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Carrito.Location = new System.Drawing.Point(553, 46);
            this.dgv_Carrito.MaximumSize = new System.Drawing.Size(325, 173);
            this.dgv_Carrito.Name = "dgv_Carrito";
            this.dgv_Carrito.ReadOnly = true;
            this.dgv_Carrito.Size = new System.Drawing.Size(325, 173);
            this.dgv_Carrito.TabIndex = 1;
            this.dgv_Carrito.Click += new System.EventHandler(this.dgv_Carrito_Click);
            // 
            // lb_Selec_productos
            // 
            this.lb_Selec_productos.AutoSize = true;
            this.lb_Selec_productos.Location = new System.Drawing.Point(12, 19);
            this.lb_Selec_productos.Name = "lb_Selec_productos";
            this.lb_Selec_productos.Size = new System.Drawing.Size(146, 13);
            this.lb_Selec_productos.TabIndex = 2;
            this.lb_Selec_productos.Text = "Agregar productos a la carrito";
            // 
            // lc_carrito
            // 
            this.lc_carrito.AutoSize = true;
            this.lc_carrito.Location = new System.Drawing.Point(683, 19);
            this.lc_carrito.Name = "lc_carrito";
            this.lc_carrito.Size = new System.Drawing.Size(37, 13);
            this.lc_carrito.TabIndex = 3;
            this.lc_carrito.Text = "Carrito";
            // 
            // lb_Cliente
            // 
            this.lb_Cliente.AutoSize = true;
            this.lb_Cliente.Location = new System.Drawing.Point(412, 19);
            this.lb_Cliente.Name = "lb_Cliente";
            this.lb_Cliente.Size = new System.Drawing.Size(39, 13);
            this.lb_Cliente.TabIndex = 4;
            this.lb_Cliente.Text = "Cliente";
            // 
            // lb_NombreApellido
            // 
            this.lb_NombreApellido.AutoSize = true;
            this.lb_NombreApellido.Location = new System.Drawing.Point(392, 69);
            this.lb_NombreApellido.Name = "lb_NombreApellido";
            this.lb_NombreApellido.Size = new System.Drawing.Size(0, 13);
            this.lb_NombreApellido.TabIndex = 6;
            // 
            // txt_Precio_estimado
            // 
            this.txt_Precio_estimado.BackColor = System.Drawing.Color.Beige;
            this.txt_Precio_estimado.Location = new System.Drawing.Point(653, 248);
            this.txt_Precio_estimado.Name = "txt_Precio_estimado";
            this.txt_Precio_estimado.ReadOnly = true;
            this.txt_Precio_estimado.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio_estimado.TabIndex = 7;
            // 
            // lb_Precio_estimado
            // 
            this.lb_Precio_estimado.AutoSize = true;
            this.lb_Precio_estimado.Location = new System.Drawing.Point(650, 232);
            this.lb_Precio_estimado.Name = "lb_Precio_estimado";
            this.lb_Precio_estimado.Size = new System.Drawing.Size(82, 13);
            this.lb_Precio_estimado.TabIndex = 8;
            this.lb_Precio_estimado.Text = "Precio estimado";
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.BackColor = System.Drawing.Color.Beige;
            this.nud_cantidad.Location = new System.Drawing.Point(555, 248);
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(81, 20);
            this.nud_cantidad.TabIndex = 9;
            this.nud_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_cantidad.ValueChanged += new System.EventHandler(this.nud_cantidad_ValueChanged);
            // 
            // btn_Eliminar_item_carrito
            // 
            this.btn_Eliminar_item_carrito.Location = new System.Drawing.Point(803, 245);
            this.btn_Eliminar_item_carrito.Name = "btn_Eliminar_item_carrito";
            this.btn_Eliminar_item_carrito.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar_item_carrito.TabIndex = 11;
            this.btn_Eliminar_item_carrito.Text = "Eliminar";
            this.btn_Eliminar_item_carrito.UseVisualStyleBackColor = true;
            this.btn_Eliminar_item_carrito.Click += new System.EventHandler(this.btn_Eliminar_item_carrito_Click);
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.BackColor = System.Drawing.Color.Beige;
            this.btn_Comprar.Location = new System.Drawing.Point(553, 297);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(200, 23);
            this.btn_Comprar.TabIndex = 12;
            this.btn_Comprar.Text = "Realizar Compra";
            this.btn_Comprar.UseVisualStyleBackColor = false;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // lb_Contador_cantidad
            // 
            this.lb_Contador_cantidad.AutoSize = true;
            this.lb_Contador_cantidad.Location = new System.Drawing.Point(552, 232);
            this.lb_Contador_cantidad.Name = "lb_Contador_cantidad";
            this.lb_Contador_cantidad.Size = new System.Drawing.Size(52, 13);
            this.lb_Contador_cantidad.TabIndex = 13;
            this.lb_Contador_cantidad.Text = "Unidades";
            // 
            // frmRealizar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(890, 402);
            this.Controls.Add(this.lb_Contador_cantidad);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.btn_Eliminar_item_carrito);
            this.Controls.Add(this.nud_cantidad);
            this.Controls.Add(this.lb_Precio_estimado);
            this.Controls.Add(this.txt_Precio_estimado);
            this.Controls.Add(this.lb_NombreApellido);
            this.Controls.Add(this.lb_Cliente);
            this.Controls.Add(this.lc_carrito);
            this.Controls.Add(this.lb_Selec_productos);
            this.Controls.Add(this.dgv_Carrito);
            this.Controls.Add(this.dgv_Gondola);
            this.Name = "frmRealizar_Compra";
            this.Text = "Realizar compra";
            this.Load += new System.EventHandler(this.frmRealizar_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gondola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Gondola;
        private System.Windows.Forms.DataGridView dgv_Carrito;
        private System.Windows.Forms.Label lb_Selec_productos;
        private System.Windows.Forms.Label lc_carrito;
        private System.Windows.Forms.Label lb_Cliente;
        private System.Windows.Forms.Label lb_NombreApellido;
        private System.Windows.Forms.TextBox txt_Precio_estimado;
        private System.Windows.Forms.Label lb_Precio_estimado;
        private System.Windows.Forms.NumericUpDown nud_cantidad;
        private System.Windows.Forms.Button btn_Eliminar_item_carrito;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.Label lb_Contador_cantidad;
    }
}