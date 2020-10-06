using System;

namespace Kiwk_E_Mart
{
    partial class frmControl_Stock
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
            this.lb_Oracion = new System.Windows.Forms.Label();
            this.dgv_Listar_Filtrada = new System.Windows.Forms.DataGridView();
            this.cb_Selec_lista = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listar_Filtrada)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Oracion
            // 
            this.lb_Oracion.AutoSize = true;
            this.lb_Oracion.Location = new System.Drawing.Point(12, 45);
            this.lb_Oracion.Name = "lb_Oracion";
            this.lb_Oracion.Size = new System.Drawing.Size(106, 13);
            this.lb_Oracion.TabIndex = 0;
            this.lb_Oracion.Text = "Listar productos por :";
            // 
            // dgv_Listar_Filtrada
            // 
            this.dgv_Listar_Filtrada.AllowUserToDeleteRows = false;
            this.dgv_Listar_Filtrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Listar_Filtrada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Listar_Filtrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listar_Filtrada.Location = new System.Drawing.Point(260, 42);
            this.dgv_Listar_Filtrada.MaximumSize = new System.Drawing.Size(464, 342);
            this.dgv_Listar_Filtrada.MultiSelect = false;
            this.dgv_Listar_Filtrada.Name = "dgv_Listar_Filtrada";
            this.dgv_Listar_Filtrada.ReadOnly = true;
            this.dgv_Listar_Filtrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Listar_Filtrada.Size = new System.Drawing.Size(0, 0);
            this.dgv_Listar_Filtrada.TabIndex = 2;
            this.dgv_Listar_Filtrada.TabStop = false;
            // 
            // cb_Selec_lista
            // 
            this.cb_Selec_lista.BackColor = System.Drawing.Color.Beige;
            this.cb_Selec_lista.FormattingEnabled = true;
            this.cb_Selec_lista.Location = new System.Drawing.Point(124, 42);
            this.cb_Selec_lista.Name = "cb_Selec_lista";
            this.cb_Selec_lista.Size = new System.Drawing.Size(121, 21);
            this.cb_Selec_lista.TabIndex = 3;
            this.cb_Selec_lista.SelectionChangeCommitted += new System.EventHandler(this.cb_Selec_lista_SelectionChangeCommitted);
            // 
            // frmControl_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(727, 451);
            this.Controls.Add(this.cb_Selec_lista);
            this.Controls.Add(this.dgv_Listar_Filtrada);
            this.Controls.Add(this.lb_Oracion);
            this.Name = "frmControl_Stock";
            this.Text = "Control de Stock";
            this.Load += new System.EventHandler(this.frmControl_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listar_Filtrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Oracion;
        private System.Windows.Forms.DataGridView dgv_Listar_Filtrada;
        private System.Windows.Forms.ComboBox cb_Selec_lista;

        #region PROMIEDADES


        public System.Windows.Forms.ComboBox Cb_Selec_lista
        {
            get { return cb_Selec_lista; }
            set
            {
                if (!String.IsNullOrEmpty(value.ToString()))
                {
                    cb_Selec_lista = value;
                }

            }

        }


        #endregion
    }
}