namespace aplicandoConceptos
{
    partial class FrmPrincipal
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.buttonSaludo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMostrarPersonas = new System.Windows.Forms.Button();
            this.labelLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(9, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(12, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(219, 20);
            this.textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(12, 82);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(219, 20);
            this.textApellido.TabIndex = 3;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(9, 66);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido:";
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(12, 136);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(219, 20);
            this.textDNI.TabIndex = 5;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(9, 120);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 4;
            this.labelDNI.Text = "DNI";
            // 
            // buttonSaludo
            // 
            this.buttonSaludo.Location = new System.Drawing.Point(12, 183);
            this.buttonSaludo.Name = "buttonSaludo";
            this.buttonSaludo.Size = new System.Drawing.Size(219, 23);
            this.buttonSaludo.TabIndex = 6;
            this.buttonSaludo.Text = "Saludar";
            this.buttonSaludo.UseVisualStyleBackColor = true;
            this.buttonSaludo.Click += new System.EventHandler(this.buttonSaludo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 223);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 57);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonMostrarPersonas
            // 
            this.buttonMostrarPersonas.Location = new System.Drawing.Point(128, 223);
            this.buttonMostrarPersonas.Name = "buttonMostrarPersonas";
            this.buttonMostrarPersonas.Size = new System.Drawing.Size(103, 57);
            this.buttonMostrarPersonas.TabIndex = 8;
            this.buttonMostrarPersonas.Text = "Mostrar Personas";
            this.buttonMostrarPersonas.UseVisualStyleBackColor = true;
            this.buttonMostrarPersonas.Click += new System.EventHandler(this.buttonMostrarPersonas_Click);
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLista.Location = new System.Drawing.Point(260, 9);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(0, 13);
            this.labelLista.TabIndex = 9;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 287);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.buttonMostrarPersonas);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSaludo);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "FrmPrincipal";
            this.Text = " Bienvenido al Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Button buttonSaludo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMostrarPersonas;
        private System.Windows.Forms.Label labelLista;
    }
}

