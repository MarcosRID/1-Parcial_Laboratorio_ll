namespace Kiwk_E_Mart
{
    partial class frmLogin
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
            this.txt_NameUsuairo = new System.Windows.Forms.TextBox();
            this.txt_PassUsuario = new System.Windows.Forms.TextBox();
            this.btm_Aceptar = new System.Windows.Forms.Button();
            this.lb_NameUsuario = new System.Windows.Forms.Label();
            this.lb_PassUsuario = new System.Windows.Forms.Label();
            this.btm_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_NameUsuairo
            // 
            this.txt_NameUsuairo.BackColor = System.Drawing.Color.Beige;
            this.txt_NameUsuairo.Location = new System.Drawing.Point(83, 42);
            this.txt_NameUsuairo.Name = "txt_NameUsuairo";
            this.txt_NameUsuairo.Size = new System.Drawing.Size(100, 20);
            this.txt_NameUsuairo.TabIndex = 0;
            // 
            // txt_PassUsuario
            // 
            this.txt_PassUsuario.BackColor = System.Drawing.Color.Beige;
            this.txt_PassUsuario.Location = new System.Drawing.Point(83, 86);
            this.txt_PassUsuario.Name = "txt_PassUsuario";
            this.txt_PassUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_PassUsuario.TabIndex = 1;
            // 
            // btm_Aceptar
            // 
            this.btm_Aceptar.BackColor = System.Drawing.Color.Beige;
            this.btm_Aceptar.Location = new System.Drawing.Point(94, 133);
            this.btm_Aceptar.Name = "btm_Aceptar";
            this.btm_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btm_Aceptar.TabIndex = 2;
            this.btm_Aceptar.Text = "Aceptar";
            this.btm_Aceptar.UseVisualStyleBackColor = false;
            this.btm_Aceptar.Click += new System.EventHandler(this.btm_Aceptar_Click);
            // 
            // lb_NameUsuario
            // 
            this.lb_NameUsuario.AutoSize = true;
            this.lb_NameUsuario.Location = new System.Drawing.Point(29, 49);
            this.lb_NameUsuario.Name = "lb_NameUsuario";
            this.lb_NameUsuario.Size = new System.Drawing.Size(43, 13);
            this.lb_NameUsuario.TabIndex = 3;
            this.lb_NameUsuario.Text = "Usuario";
            // 
            // lb_PassUsuario
            // 
            this.lb_PassUsuario.AutoSize = true;
            this.lb_PassUsuario.Location = new System.Drawing.Point(29, 93);
            this.lb_PassUsuario.Name = "lb_PassUsuario";
            this.lb_PassUsuario.Size = new System.Drawing.Size(34, 13);
            this.lb_PassUsuario.TabIndex = 4;
            this.lb_PassUsuario.Text = "Clave";
            // 
            // btm_Cancelar
            // 
            this.btm_Cancelar.BackColor = System.Drawing.Color.Beige;
            this.btm_Cancelar.Location = new System.Drawing.Point(175, 197);
            this.btm_Cancelar.Name = "btm_Cancelar";
            this.btm_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btm_Cancelar.TabIndex = 5;
            this.btm_Cancelar.Text = "Cancelar";
            this.btm_Cancelar.UseVisualStyleBackColor = false;
            this.btm_Cancelar.Click += new System.EventHandler(this.btm_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(308, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btm_Cancelar);
            this.Controls.Add(this.lb_PassUsuario);
            this.Controls.Add(this.lb_NameUsuario);
            this.Controls.Add(this.btm_Aceptar);
            this.Controls.Add(this.txt_PassUsuario);
            this.Controls.Add(this.txt_NameUsuairo);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NameUsuairo;
        private System.Windows.Forms.TextBox txt_PassUsuario;
        private System.Windows.Forms.Button btm_Aceptar;
        private System.Windows.Forms.Label lb_NameUsuario;
        private System.Windows.Forms.Label lb_PassUsuario;
        private System.Windows.Forms.Button btm_Cancelar;
        private System.Windows.Forms.Label label1;
    }
}