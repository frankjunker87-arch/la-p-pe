namespace LaPape_DataTable
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.Location = new System.Drawing.Point(12, 163);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTabla.TabIndex = 0;
            this.btnCrearTabla.Text = "Crear Tabla";
            this.btnCrearTabla.UseVisualStyleBackColor = true;
            this.btnCrearTabla.Click += new System.EventHandler(this.btnCrearTabla_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(94, 163);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarVenta.TabIndex = 1;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 197);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.btnCrearTabla);
            this.Name = "Form1";
            this.Text = "LaPape";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTabla;
        private System.Windows.Forms.Button btnAgregarVenta;
    }
}

