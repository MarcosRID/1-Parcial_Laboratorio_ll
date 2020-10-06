namespace Kiwk_E_Mart
{
    partial class frmRenovar_Stock
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
            this.dgv_Lista_productos = new System.Windows.Forms.DataGridView();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lb_ProductoSelec = new System.Windows.Forms.Label();
            this.lb_TituloProductoSelec = new System.Windows.Forms.Label();
            this.lb_Titulo_Cantidad = new System.Windows.Forms.Label();
            this.lb_Advertencia = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lista_productos
            // 
            this.dgv_Lista_productos.AllowUserToAddRows = false;
            this.dgv_Lista_productos.AllowUserToResizeColumns = false;
            this.dgv_Lista_productos.AllowUserToResizeRows = false;
            this.dgv_Lista_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Lista_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Lista_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Lista_productos.BackgroundColor = System.Drawing.Color.Beige;
            this.dgv_Lista_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Lista_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista_productos.Location = new System.Drawing.Point(55, 53);
            this.dgv_Lista_productos.Name = "dgv_Lista_productos";
            this.dgv_Lista_productos.ReadOnly = true;
            this.dgv_Lista_productos.Size = new System.Drawing.Size(557, 273);
            this.dgv_Lista_productos.TabIndex = 0;
            this.dgv_Lista_productos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_productos_CellContentDoubleClick);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Cantidad.BackColor = System.Drawing.Color.Beige;
            this.txt_Cantidad.Location = new System.Drawing.Point(134, 442);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(46, 20);
            this.txt_Cantidad.TabIndex = 1;
            // 
            // lb_ProductoSelec
            // 
            this.lb_ProductoSelec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_ProductoSelec.AutoSize = true;
            this.lb_ProductoSelec.BackColor = System.Drawing.Color.Beige;
            this.lb_ProductoSelec.Location = new System.Drawing.Point(131, 391);
            this.lb_ProductoSelec.Name = "lb_ProductoSelec";
            this.lb_ProductoSelec.Size = new System.Drawing.Size(16, 13);
            this.lb_ProductoSelec.TabIndex = 2;
            this.lb_ProductoSelec.Text = "...";
            // 
            // lb_TituloProductoSelec
            // 
            this.lb_TituloProductoSelec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_TituloProductoSelec.AutoSize = true;
            this.lb_TituloProductoSelec.Location = new System.Drawing.Point(131, 372);
            this.lb_TituloProductoSelec.Name = "lb_TituloProductoSelec";
            this.lb_TituloProductoSelec.Size = new System.Drawing.Size(118, 13);
            this.lb_TituloProductoSelec.TabIndex = 3;
            this.lb_TituloProductoSelec.Text = "Producto Seleccionado";
            // 
            // lb_Titulo_Cantidad
            // 
            this.lb_Titulo_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_Titulo_Cantidad.AutoSize = true;
            this.lb_Titulo_Cantidad.Location = new System.Drawing.Point(131, 426);
            this.lb_Titulo_Cantidad.Name = "lb_Titulo_Cantidad";
            this.lb_Titulo_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lb_Titulo_Cantidad.TabIndex = 4;
            this.lb_Titulo_Cantidad.Text = "Cantidad";
            // 
            // lb_Advertencia
            // 
            this.lb_Advertencia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_Advertencia.AutoSize = true;
            this.lb_Advertencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lb_Advertencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.lb_Advertencia.Location = new System.Drawing.Point(298, 396);
            this.lb_Advertencia.Name = "lb_Advertencia";
            this.lb_Advertencia.Size = new System.Drawing.Size(0, 13);
            this.lb_Advertencia.TabIndex = 5;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.AllowDrop = true;
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Aceptar.BackColor = System.Drawing.Color.Beige;
            this.btn_Aceptar.Location = new System.Drawing.Point(301, 412);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(84, 27);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackColor = System.Drawing.Color.Beige;
            this.btn_Salir.Location = new System.Drawing.Point(555, 446);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(84, 27);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // frmRenovar_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(651, 485);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lb_Advertencia);
            this.Controls.Add(this.lb_Titulo_Cantidad);
            this.Controls.Add(this.lb_TituloProductoSelec);
            this.Controls.Add(this.lb_ProductoSelec);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.dgv_Lista_productos);
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "frmRenovar_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renovar Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRenovar_Stock_FormClosing_1);
            this.Load += new System.EventHandler(this.frmRenovar_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lb_ProductoSelec;
        private System.Windows.Forms.Label lb_TituloProductoSelec;
        private System.Windows.Forms.Label lb_Titulo_Cantidad;
        private System.Windows.Forms.Label lb_Advertencia;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dgv_Lista_productos;
    }
}