namespace Kiwk_E_Mart
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoProcutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarNuevasComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem.Text = "Realizar compra";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // ventasPorEmpleadoToolStripMenuItem
            // 
            this.ventasPorEmpleadoToolStripMenuItem.Name = "ventasPorEmpleadoToolStripMenuItem";
            this.ventasPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ventasPorEmpleadoToolStripMenuItem.Text = "Ventas Por Empleado";
            this.ventasPorEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.ventasPorEmpleadoToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoProcutoToolStripMenuItem,
            this.realizarNuevasComprasToolStripMenuItem,
            this.controlDeStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // agregarNuevoProcutoToolStripMenuItem
            // 
            this.agregarNuevoProcutoToolStripMenuItem.Name = "agregarNuevoProcutoToolStripMenuItem";
            this.agregarNuevoProcutoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agregarNuevoProcutoToolStripMenuItem.Text = "Agregar nuevo procuto";
            this.agregarNuevoProcutoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoProcutoToolStripMenuItem_Click);
            // 
            // realizarNuevasComprasToolStripMenuItem
            // 
            this.realizarNuevasComprasToolStripMenuItem.Name = "realizarNuevasComprasToolStripMenuItem";
            this.realizarNuevasComprasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.realizarNuevasComprasToolStripMenuItem.Text = "Realizar nueva compra";
            this.realizarNuevasComprasToolStripMenuItem.Click += new System.EventHandler(this.realizarNuevasComprasToolStripMenuItem_Click);
            // 
            // controlDeStockToolStripMenuItem
            // 
            this.controlDeStockToolStripMenuItem.Name = "controlDeStockToolStripMenuItem";
            this.controlDeStockToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.controlDeStockToolStripMenuItem.Text = "Control de Stock";
            this.controlDeStockToolStripMenuItem.Click += new System.EventHandler(this.controlDeStockToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Kiwk_E_Mart.Properties.Resources.hay_tabla;
            this.ClientSize = new System.Drawing.Size(553, 391);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion del Comecio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoProcutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarNuevasComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeStockToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorEmpleadoToolStripMenuItem;
    }
}

